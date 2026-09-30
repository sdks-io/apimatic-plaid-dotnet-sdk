using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Selling an investment
/// </summary>
public record SellType
{
    /// <summary>
    /// Outflow of assets from a tax-advantaged account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distribution")]
    public string? Distribution { get; init; }

    /// <summary>
    /// Exercise of an option or warrant contract
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exercise")]
    public string? Exercise { get; init; }

    /// <summary>
    /// Sell to close or decrease an existing holding
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sell")]
    public string? Sell { get; init; }

    /// <summary>
    /// Sell to open a short position
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sell short")]
    public string? SellShort { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
