using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when Asset Report generation has failed. The resulting <c>error</c> will have an <c>error_type</c> of <c>ASSET_REPORT_ERROR</c>.
/// </summary>
public record AssetsErrorWebhook
{
    /// <summary>
    /// <c>ASSETS</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>ERROR</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues.  Error fields will be <c>null</c> if no error has occurred.
    /// </summary>
    [JsonPropertyName("error")]
    public required Error Error { get; init; }

    /// <summary>
    /// The ID associated with the Asset Report.
    /// </summary>
    [JsonPropertyName("asset_report_id")]
    public required string AssetReportId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
