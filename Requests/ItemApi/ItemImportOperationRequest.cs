using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.ItemApi;

/// <summary>
/// The inputs of the ItemImport operation.
/// </summary>
public sealed record ItemImportOperationRequest
{
    public required ItemImportRequest Body { get; init; }
}
