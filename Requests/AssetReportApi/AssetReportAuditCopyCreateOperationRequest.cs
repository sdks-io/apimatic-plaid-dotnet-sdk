using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.AssetReportApi;

/// <summary>
/// The inputs of the AssetReportAuditCopyCreate operation.
/// </summary>
public sealed record AssetReportAuditCopyCreateOperationRequest
{
    public required AssetReportAuditCopyCreateRequest Body { get; init; }
}
