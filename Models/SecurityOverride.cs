using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specify the security associated with the holding or investment transaction. When inputting custom security data to the Sandbox, Plaid will perform post-data-retrieval normalization and enrichment. These processes may cause the data returned by the Sandbox to be slightly different from the data you input. An ISO-4217 currency code and a security identifier (<c>ticker_symbol</c>, <c>cusip</c>, <c>isin</c>, or <c>sedol</c>) are required.
/// </summary>
public record SecurityOverride
{
    /// <summary>
    /// 12-character ISIN, a globally unique securities identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isin")]
    public string? Isin { get; init; }

    /// <summary>
    /// 9-character CUSIP, an identifier assigned to North American securities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cusip")]
    public string? Cusip { get; init; }

    /// <summary>
    /// 7-character SEDOL, an identifier assigned to securities in the UK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sedol")]
    public string? Sedol { get; init; }

    /// <summary>
    /// A descriptive name for the security, suitable for display.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The security’s trading symbol for publicly traded securities, and otherwise a short identifier if available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ticker_symbol")]
    public string? TickerSymbol { get; init; }

    /// <summary>
    /// Either a valid <c>iso_currency_code</c> or <c>unofficial_currency_code</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
