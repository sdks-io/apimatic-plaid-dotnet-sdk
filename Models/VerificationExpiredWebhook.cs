using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when an Item was not verified via automated micro-deposits after ten days since the automated micro-deposit was made.
/// </summary>
public record VerificationExpiredWebhook
{
    /// <summary>
    /// <c>AUTH</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>VERIFICATION_EXPIRED</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The <c>item_id</c> of the Item associated with this webhook, warning, or error
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    /// <summary>
    /// The <c>account_id</c> of the account associated with the webhook
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
