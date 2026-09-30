using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.ProcessorApi;

/// <summary>
/// The inputs of the ProcessorStripeBankAccountTokenCreate operation.
/// </summary>
public sealed record ProcessorStripeBankAccountTokenCreateOperationRequest
{
    public required ProcessorStripeBankAccountTokenCreateRequest Body { get; init; }
}
