using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when Plaid detects a new account for Items created or updated with <see href="https://plaid.com/docs/link/customization/#account-select">Account Select v2</see>. Upon receiving this webhook, you can prompt your users to share new accounts with you through <see href="https://plaid.com/docs/link/update-mode/#using-update-mode-to-request-new-accounts">Account Select v2 update mode</see>.
/// </summary>
public record NewAccountsAvailableWebhook
{
    /// <summary>
    /// <c>ITEM</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook_type")]
    public string? WebhookType { get; init; }

    /// <summary>
    /// <c>NEW_ACCOUNTS_AVAILABLE</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook_code")]
    public string? WebhookCode { get; init; }

    /// <summary>
    /// The <c>item_id</c> of the Item associated with this webhook, warning, or error
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_id")]
    public string? ItemId { get; init; }

    /// <summary>
    /// We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues.  Error fields will be <c>null</c> if no error has occurred.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public Error? Error { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
