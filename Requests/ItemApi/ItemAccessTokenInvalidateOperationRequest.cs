using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.ItemApi;

/// <summary>
/// The inputs of the ItemAccessTokenInvalidate operation.
/// </summary>
public sealed record ItemAccessTokenInvalidateOperationRequest
{
    public required ItemAccessTokenInvalidateRequest Body { get; init; }
}
