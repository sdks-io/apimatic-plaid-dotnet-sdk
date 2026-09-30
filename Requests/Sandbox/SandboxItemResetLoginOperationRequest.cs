using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Sandbox;

/// <summary>
/// The inputs of the SandboxItemResetLogin operation.
/// </summary>
public sealed record SandboxItemResetLoginOperationRequest
{
    public required SandboxItemResetLoginRequest Body { get; init; }
}
