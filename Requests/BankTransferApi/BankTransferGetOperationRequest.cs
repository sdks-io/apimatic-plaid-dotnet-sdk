using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.BankTransferApi;

/// <summary>
/// The inputs of the BankTransferGet operation.
/// </summary>
public sealed record BankTransferGetOperationRequest
{
    public required BankTransferGetRequest Body { get; init; }
}
