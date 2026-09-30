using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Sandbox;

/// <summary>
/// The inputs of the SandboxPublicTokenCreate operation.
/// </summary>
public sealed record SandboxPublicTokenCreateOperationRequest
{
    public required SandboxPublicTokenCreateRequest Body { get; init; }
}
