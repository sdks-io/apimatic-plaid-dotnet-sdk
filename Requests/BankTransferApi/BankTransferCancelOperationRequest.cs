using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.BankTransferApi;

/// <summary>
/// The inputs of the BankTransferCancel operation.
/// </summary>
public sealed record BankTransferCancelOperationRequest
{
    public required BankTransferCancelRequest Body { get; init; }
}
