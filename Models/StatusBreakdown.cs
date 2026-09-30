using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A detailed breakdown of the institution's performance for a request type. The values for <c>success</c>, <c>error_plaid</c>, and <c>error_institution</c> sum to 1.
/// </summary>
public record StatusBreakdown
{
    /// <summary>
    /// The percentage of login attempts that are successful, expressed as a decimal.
    /// </summary>
    [JsonPropertyName("success")]
    public required double Success { get; init; }

    /// <summary>
    /// The percentage of logins that are failing due to an internal Plaid issue, expressed as a decimal.
    /// </summary>
    [JsonPropertyName("error_plaid")]
    public required double ErrorPlaid { get; init; }

    /// <summary>
    /// The percentage of logins that are failing due to an issue in the institution's system, expressed as a decimal.
    /// </summary>
    [JsonPropertyName("error_institution")]
    public required double ErrorInstitution { get; init; }

    /// <summary>
    /// The <c>refresh_interval</c> may be <c>DELAYED</c> or <c>STOPPED</c> even when the success rate is high. This value is only returned for Transactions status breakdowns.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refresh_interval")]
    public RefreshInterval? RefreshInterval { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
