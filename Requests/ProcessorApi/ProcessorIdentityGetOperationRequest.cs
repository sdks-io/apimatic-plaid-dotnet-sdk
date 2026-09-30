using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.ProcessorApi;

/// <summary>
/// The inputs of the ProcessorIdentityGet operation.
/// </summary>
public sealed record ProcessorIdentityGetOperationRequest
{
    public required ProcessorIdentityGetRequest Body { get; init; }
}
