using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

public record PersonalFinanceCategory2
{
    /// <summary>
    /// A high level category that communicates the broad category of the transaction.
    /// </summary>
    [JsonPropertyName("primary")]
    public required string Primary { get; init; }

    /// <summary>
    /// Provides additional granularity to the primary categorization.
    /// </summary>
    [JsonPropertyName("detailed")]
    public required string Detailed { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
