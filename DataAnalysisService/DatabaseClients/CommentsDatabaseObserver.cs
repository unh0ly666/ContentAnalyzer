﻿using Common;
using Common.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace DataAnalysisService.DatabaseClients;

public class CommentsDatabaseObserver : DatabaseObserver
{
    private CancellationTokenSource? _cancellation;
    private Action<Comment>? _dataProcessor;
    private readonly IDbContextFactory<CommentsContext> _contextFactory;
    private readonly int _observeDelay;

    public CommentsDatabaseObserver(IDbContextFactory<CommentsContext> contextFactory, int observeDelayMs)
    {
        _contextFactory = contextFactory;
        _observeDelay = observeDelayMs;
    }

    #region PublicInterface

    public override void StartLoading()
    {
        if (IsLoadingStarted) throw new Exception("Loading already started");
        if (_dataProcessor is null) throw new Exception($"Data processor not set {nameof(StopLoading)}");
        _cancellation = new CancellationTokenSource();
        IsLoadingStarted = true;
        var _ = StartLoadingLoop(_cancellation.Token);
        Log.Logger.Information("Loading started on with delay {_observeDelay}", _observeDelay);
    }

    public override void StopLoading()
    {
        if (!IsLoadingStarted) throw new Exception($"Loading already stopped {nameof(StopLoading)}");
        if (_dataProcessor is null) throw new Exception($"Data processor not set {nameof(StopLoading)}");

        _cancellation!.Cancel();
        IsLoadingStarted = false;
        Log.Logger.Information("Loading stopped");
    }

    public override void OnDataArrived(Action<Comment> handler) => _dataProcessor = handler;

    #endregion

    private async Task StartLoadingLoop(CancellationToken cancellationToken)
    {
        await Task.Run(async () =>
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                LoadData();
                await Task.Delay(_observeDelay, cancellationToken);
                Log.Logger.Information("Loading loop working");
            }
            Log.Logger.Information("Loading loop break");
        }, cancellationToken);
    }

    private void LoadData()
    {
        using var context = _contextFactory.CreateDbContext();
        var newComments = context.Comments
            .Where(c => !context.EvaluatedComments.Any(e => e.CommentId == c.Id));
            
        foreach (var comment in newComments)
        {
            _dataProcessor?.Invoke(comment);
        }
    }
}