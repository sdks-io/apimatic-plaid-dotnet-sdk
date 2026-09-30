using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.AssetReportApi;

/// <summary>
/// The inputs of the AssetReportAuditCopyGet operation.
/// </summary>
public sealed record AssetReportAuditCopyGetOperationRequest
{
    public required AssetReportAuditCopyGetRequest Body { get; init; }
}
