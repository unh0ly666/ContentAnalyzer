﻿namespace DataCollectionService.BusinessLogicLayer.SocialNetworkClients.VkClient;

public class Config
{
    public ulong ApplicationId { get; init; }
    public string SecureKey { get; init; }
    public string ServiceAccessKey { get; init; }
    public int ScanPostDelay { get; init; }
    public int ScanCommentsDelay { get; init; }
    public int ObservedPostQueueSize { get; init; }
}