﻿using Common;
using Common.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace DataAnalysisService.DatabaseClients;

public class EvaluatedCommentsDatabaseClient : DatabaseClient<EvaluatedComment>
{
    private readonly IDbContextFactory<CommentsContext> _contextFactory;
    public EvaluatedCommentsDatabaseClient(IDbContextFactory<CommentsContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public override void Add(EvaluatedComment result)
    {
        using var context = _contextFactory.CreateDbContext();
        if (context.EvaluatedComments.Any(x => x.CommentId == result.CommentId)) return;
        context.Comments.Single(comment => comment.Id == result.CommentId).IncludedInEvaluatedComments.Add(result);
        context.SaveChanges();
        Log.Logger.Information("{0} comments evaluated", context.EvaluatedComments.Count());
    }

    public override List<EvaluatedComment> GetRange(CommentsQueryFilter filter)
    {
        using var context = _contextFactory.CreateDbContext();
        return context.EvaluatedComments
                .Include(comment => comment.RelatedComment)
                .AsParallel()
                .Where(c => filter.AuthorId <= 0 || c.RelatedComment.AuthorId == filter.AuthorId)
                .Where(c => filter.PostId <= 0 || c.RelatedComment.PostId == filter.PostId)
                .Where(c => filter.GroupId <= 0 || c.RelatedComment.GroupId == filter.GroupId)
                .Where(c => filter.FromDate.Year <= 1970 || c.RelatedComment.PostDate > filter.FromDate)
                .Where(c => filter.ToDate.Year <= 1970 || c.RelatedComment.PostDate < filter.ToDate)
                .ToList();
        //if (filter.AuthorId > 0)
        //    evaluatedComments = evaluatedComments.Where(c => c.RelatedComment.AuthorId == filter.AuthorId);
        //if (filter.PostId > 0)
        //    evaluatedComments = evaluatedComments.Where(c => c.RelatedComment.PostId == filter.PostId);
        //if (filter.GroupId > 0)
        //    evaluatedComments = evaluatedComments.Where(c => c.RelatedComment.GroupId == filter.GroupId);
        //if (filter.FromDate.Year > 0)
        //    evaluatedComments = evaluatedComments.Where(c => c.RelatedComment.PostDate.Ticks > filter.FromDate.Ticks);
        //if (filter.ToDate.Year > 0)
        //    evaluatedComments = evaluatedComments.Where(c => c.RelatedComment.PostDate.Ticks < filter.ToDate.Ticks);
        //return evaluatedComments.ToList();
    }

    public override void Clear()
    {
        using var context = _contextFactory.CreateDbContext();
        context.EvaluatedComments.RemoveRange(context.EvaluatedComments.ToList());
        context.SaveChanges();
    }
}