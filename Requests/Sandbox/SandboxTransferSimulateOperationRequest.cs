using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Sandbox;

/// <summary>
/// The inputs of the SandboxTransferSimulate operation.
/// </summary>
public sealed record SandboxTransferSimulateOperationRequest
{
    public required SandboxTransferSimulateRequest Body { get; init; }
}
