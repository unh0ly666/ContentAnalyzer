﻿using Common;
using Common.EntityFramework;
using DataAnalysisClient;
using Google.Protobuf.WellKnownTypes;

namespace DevTool.Models;

internal class AnalysisServiceClient : ServiceClient, IDisposable
{
    private readonly DataAnalysis.DataAnalysisClient _dataAnalysisClient;

    public override void StartService()
    {
        _dataAnalysisClient.StartAnalysisService(new StartAnalysisServiceRequest());
    }

    public override void StopService()
    {
        _dataAnalysisClient.StopAnalysisService(new StopAnalysisServiceRequest());
    }

    public override string GetLogFile(DateTime date)
    {
        var result = _dataAnalysisClient.GetLogs(new LogRequest { LogDate = Timestamp.FromDateTime(date.ToUniversalTime()) });
        return result.LogFile.ToStringUtf8();
    }

    public AnalysisServiceClient(string dataAnalysisServiceHost) : base(dataAnalysisServiceHost)
    {
        _dataAnalysisClient = new DataAnalysis.DataAnalysisClient(Channel);
    }

    public IEnumerable<EvaluatedComment> GetEvaluateResults(CommentsQueryFilter filter)
    {
        var requestFilter = new CommentsQueryFilterProto
        {
            AuthorId = filter.AuthorId,
            PostId = filter.PostId,
            GroupId = filter.GroupId,
            FromDate = new Timestamp { Seconds = new DateTimeOffset(filter.FromDate).ToUnixTimeSeconds() },
            ToDate = new Timestamp { Seconds = new DateTimeOffset(filter.ToDate).ToUnixTimeSeconds() }
        };
        var comments = _dataAnalysisClient.GetEvaluatedComments(new EvaluatedCommentsRequest { Filter = requestFilter });
        return comments.EvaluatedComments.Select(evaluateResultProto => new EvaluatedComment
        {
            Id = evaluateResultProto.Id,
            RelatedComment = new Comment
            {
                Id = evaluateResultProto.Comment.Id,
                CommentId = evaluateResultProto.Comment.CommentId,
                AuthorId = evaluateResultProto.Comment.AuthorId,
                GroupId = evaluateResultProto.Comment.GroupId,
                PostDate = evaluateResultProto.Comment.PostDate.ToDateTime(),
                PostId = evaluateResultProto.Comment.PostId,
                Text = evaluateResultProto.Comment.Text
            },
            CommentId = evaluateResultProto.CommentId,
            EvaluateCategory = evaluateResultProto.EvaluateCategory,
            EvaluateProbability = evaluateResultProto.EvaluateProbability
        });
    }

    public new void Dispose()
    {
        Channel.Dispose();
    }
}