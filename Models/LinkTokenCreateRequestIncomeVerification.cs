using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the Income (beta) product. This field is required if <c>income_verification</c> is included in the <c>products</c> array.
/// </summary>
public record LinkTokenCreateRequestIncomeVerification
{
    /// <summary>
    /// The <c>income_verification_id</c> of the verification instance, as provided by <c>/income/verification/create</c>.
    /// </summary>
    [JsonPropertyName("income_verification_id")]
    public required string IncomeVerificationId { get; init; }

    /// <summary>
    /// The <c>asset_report_id</c> of an asset report associated with the user, as provided by <c>/asset_report/create</c>. Providing an <c>asset_report_id</c> is optional and can be used to verify the user through a streamlined flow. If provided, the bank linking flow will be skipped.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("asset_report_id")]
    public string? AssetReportId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
