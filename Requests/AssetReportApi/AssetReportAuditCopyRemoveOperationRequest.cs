using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.AssetReportApi;

/// <summary>
/// The inputs of the AssetReportAuditCopyRemove operation.
/// </summary>
public sealed record AssetReportAuditCopyRemoveOperationRequest
{
    public required AssetReportAuditCopyRemoveRequest Body { get; init; }
}
