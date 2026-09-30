using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// SandboxPublicTokenCreateRequestOptionsTransactions is an optional set of parameters corresponding to transactions options.
/// </summary>
public record SandboxPublicTokenCreateRequestOptionsTransactions
{
    /// <summary>
    /// The earliest date for which to fetch transaction history. Dates should be formatted as YYYY-MM-DD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public DateTimeOffset? StartDate { get; init; }

    /// <summary>
    /// The most recent date for which to fetch transaction history. Dates should be formatted as YYYY-MM-DD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public DateTimeOffset? EndDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
