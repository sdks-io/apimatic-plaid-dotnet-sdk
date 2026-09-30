using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.TransferApi;

/// <summary>
/// The inputs of the TransferGet operation.
/// </summary>
public sealed record TransferGetOperationRequest
{
    public required TransferGetRequest Body { get; init; }
}
