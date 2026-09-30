using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.ProcessorApi;

/// <summary>
/// The inputs of the ProcessorBankTransferCreate operation.
/// </summary>
public sealed record ProcessorBankTransferCreateOperationRequest
{
    public required ProcessorBankTransferCreateRequest Body { get; init; }
}
