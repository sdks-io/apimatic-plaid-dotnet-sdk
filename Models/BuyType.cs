using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Buying an investment
/// </summary>
public record BuyType
{
    /// <summary>
    /// Assignment of short option holding
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assignment")]
    public string? Assignment { get; init; }

    /// <summary>
    /// Inflow of assets into a tax-advantaged account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contribution")]
    public string? Contribution { get; init; }

    /// <summary>
    /// Purchase to open or increase a position
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buy")]
    public string? Buy { get; init; }

    /// <summary>
    /// Purchase to close a short position
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buy to cover")]
    public string? BuyToCover { get; init; }

    /// <summary>
    /// Purchase using proceeds from a cash dividend
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dividend reinvestment")]
    public string? DividendReinvestment { get; init; }

    /// <summary>
    /// Purchase using proceeds from a cash interest payment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interest reinvestment")]
    public string? InterestReinvestment { get; init; }

    /// <summary>
    /// Purchase using long-term capital gain cash proceeds
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("long-term capital gain reinvestment")]
    public string? LongTermCapitalGainReinvestment { get; init; }

    /// <summary>
    /// Purchase using short-term capital gain cash proceeds
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("short-term capital gain reinvestment")]
    public string? ShortTermCapitalGainReinvestment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
