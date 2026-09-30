using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.WebhookVerificationKey;

/// <summary>
/// The inputs of the WebhookVerificationKeyGet operation.
/// </summary>
public sealed record WebhookVerificationKeyGetOperationRequest
{
    public required WebhookVerificationKeyGetRequest Body { get; init; }
}
