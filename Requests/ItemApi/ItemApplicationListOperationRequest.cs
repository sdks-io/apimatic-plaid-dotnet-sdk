using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.ItemApi;

/// <summary>
/// The inputs of the ItemApplicationList operation.
/// </summary>
public sealed record ItemApplicationListOperationRequest
{
    public required ItemApplicationListRequest Body { get; init; }
}
