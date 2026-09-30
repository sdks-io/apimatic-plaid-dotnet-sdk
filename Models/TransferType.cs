using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Activity that modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer
/// </summary>
public record TransferType
{
    /// <summary>
    /// Assignment of short option holding
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assignment")]
    public string? Assignment { get; init; }

    /// <summary>
    /// Increase or decrease in quantity of item
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjustment")]
    public string? Adjustment { get; init; }

    /// <summary>
    /// Exercise of an option or warrant contract
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exercise")]
    public string? Exercise { get; init; }

    /// <summary>
    /// Expiration of an option or warrant contract
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expire")]
    public string? Expire { get; init; }

    /// <summary>
    /// Stock exchanged at a pre-defined ratio as part of a merger between companies
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merger")]
    public string? Merger { get; init; }

    /// <summary>
    /// Inflow of stock from spin-off transaction of an existing holding
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("spin off")]
    public string? SpinOff { get; init; }

    /// <summary>
    /// Inflow of stock from a forward split of an existing holding
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("split")]
    public string? Split { get; init; }

    /// <summary>
    /// Movement of assets into or out of an account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfer")]
    public string? Transfer { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
