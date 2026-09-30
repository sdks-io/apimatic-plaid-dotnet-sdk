using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Sandbox;

/// <summary>
/// The inputs of the SandboxProcessorTokenCreate operation.
/// </summary>
public sealed record SandboxProcessorTokenCreateOperationRequest
{
    public required SandboxProcessorTokenCreateRequest Body { get; init; }
}
