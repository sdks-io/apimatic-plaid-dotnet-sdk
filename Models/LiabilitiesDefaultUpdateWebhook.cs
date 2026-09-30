using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The webhook of type <c>LIABILITIES</c> and code <c>DEFAULT_UPDATE</c> will be fired when new or updated liabilities have been detected on a liabilities item.
/// </summary>
public record LiabilitiesDefaultUpdateWebhook
{
    /// <summary>
    /// <c>LIABILITIES</c>
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
    [JsonPropertyName("error")]
    public required Error Error { get; init; }

    /// <summary>
    /// An array of <c>account_id</c>'s for accounts that contain new liabilities.
    /// </summary>
    [JsonPropertyName("account_ids_with_new_liabilities")]
    public required IReadOnlyList<string> AccountIdsWithNewLiabilities { get; init; }

    /// <summary>
    /// An object with keys of <c>account_id</c>'s that are mapped to their respective liabilities fields that changed.
    /// <para>
    /// Example: <c>{ "XMBvvyMGQ1UoLbKByoMqH3nXMj84ALSdE5B58": ["past_amount_due"] }</c>
    /// </para>
    /// </summary>
    [JsonPropertyName("account_ids_with_updated_liabilities")]
    public required IReadOnlyDictionary<string, object> AccountIdsWithUpdatedLiabilities { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
