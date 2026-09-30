using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Link;

/// <summary>
/// The inputs of the LinkTokenGet operation.
/// </summary>
public sealed record LinkTokenGetOperationRequest
{
    public required LinkTokenGetRequest Body { get; init; }
}
