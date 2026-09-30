using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.ItemApi;

/// <summary>
/// The inputs of the ItemApplicationScopesUpdate operation.
/// </summary>
public sealed record ItemApplicationScopesUpdateOperationRequest
{
    public required ItemApplicationScopesUpdateRequest Body { get; init; }
}
