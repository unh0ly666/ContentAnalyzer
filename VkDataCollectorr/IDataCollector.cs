﻿using VkDataCollector.Data;

namespace VkDataCollector;

internal interface IDataCollector
{
    public void AddCommunity(long communityId);
    public void StartCollecting();
    public void StopCollecting();
    public void Subscribe(Action<IDataFrame> handler);
}