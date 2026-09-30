using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.ItemApi;

/// <summary>
/// The inputs of the ItemWebhookUpdate operation.
/// </summary>
public sealed record ItemWebhookUpdateOperationRequest
{
    public required ItemWebhookUpdateRequest Body { get; init; }
}
