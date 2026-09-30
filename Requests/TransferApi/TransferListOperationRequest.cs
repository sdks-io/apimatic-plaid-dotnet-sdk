using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.TransferApi;

/// <summary>
/// The inputs of the TransferList operation.
/// </summary>
public sealed record TransferListOperationRequest
{
    public required TransferListRequest Body { get; init; }
}
