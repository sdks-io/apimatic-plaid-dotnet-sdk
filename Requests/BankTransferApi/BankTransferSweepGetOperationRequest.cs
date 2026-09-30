using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.BankTransferApi;

/// <summary>
/// The inputs of the BankTransferSweepGet operation.
/// </summary>
public sealed record BankTransferSweepGetOperationRequest
{
    public required BankTransferSweepGetRequest Body { get; init; }
}
