using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.ProcessorApi;

/// <summary>
/// The inputs of the ProcessorAuthGet operation.
/// </summary>
public sealed record ProcessorAuthGetOperationRequest
{
    public required ProcessorAuthGetRequest Body { get; init; }
}
