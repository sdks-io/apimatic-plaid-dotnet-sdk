using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.ItemApi;

/// <summary>
/// The inputs of the ItemGet operation.
/// </summary>
public sealed record ItemGetOperationRequest
{
    public required ItemGetRequest Body { get; init; }
}
