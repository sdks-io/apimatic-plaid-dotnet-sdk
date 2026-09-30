using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when new or updated holdings have been detected on an investment account. The webhook typically fires once per day, after market close, in response to any newly added holdings or price changes to existing holdings.
/// </summary>
public record HoldingsDefaultUpdateWebhook
{
    /// <summary>
    /// <c>HOLDINGS</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>DEFAULT_UPDATE</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The <c>item_id</c> of the Item associated with this webhook, warning, or error
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    /// <summary>
    /// We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues.  Error fields will be <c>null</c> if no error has occurred.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public Error? Error { get; init; }

    /// <summary>
    /// The number of new holdings reported since the last time this webhook was fired.
    /// </summary>
    [JsonPropertyName("new_holdings")]
    public required double NewHoldings { get; init; }

    /// <summary>
    /// The number of updated holdings reported since the last time this webhook was fired.
    /// </summary>
    [JsonPropertyName("updated_holdings")]
    public required double UpdatedHoldings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
