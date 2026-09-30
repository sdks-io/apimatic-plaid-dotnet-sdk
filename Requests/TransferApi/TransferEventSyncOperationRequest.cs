using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.TransferApi;

/// <summary>
/// The inputs of the TransferEventSync operation.
/// </summary>
public sealed record TransferEventSyncOperationRequest
{
    public required TransferEventSyncRequest Body { get; init; }
}
