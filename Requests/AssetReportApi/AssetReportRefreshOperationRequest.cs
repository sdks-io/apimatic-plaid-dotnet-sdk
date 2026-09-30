using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.AssetReportApi;

/// <summary>
/// The inputs of the AssetReportRefresh operation.
/// </summary>
public sealed record AssetReportRefreshOperationRequest
{
    public required AssetReportRefreshRequest Body { get; init; }
}
