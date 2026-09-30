using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.AssetReportApi;

/// <summary>
/// The inputs of the AssetReportPdfGet operation.
/// </summary>
public sealed record AssetReportPdfGetOperationRequest
{
    public required AssetReportPdfGetRequest Body { get; init; }
}
