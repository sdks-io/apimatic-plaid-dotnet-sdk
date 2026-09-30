using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Sandbox;

/// <summary>
/// The inputs of the SandboxIncomeFireWebhook operation.
/// </summary>
public sealed record SandboxIncomeFireWebhookOperationRequest
{
    public required SandboxIncomeFireWebhookRequest Body { get; init; }
}
