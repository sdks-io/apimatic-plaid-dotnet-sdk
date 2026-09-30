using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when new bank transfer events are available. Receiving this webhook indicates you should fetch the new events from <c>/bank_transfer/event/sync</c>.
/// </summary>
public record BankTransfersEventsUpdateWebhook
{
    /// <summary>
    /// <c>BANK_TRANSFERS</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>BANK_TRANSFERS_EVENTS_UPDATE</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
