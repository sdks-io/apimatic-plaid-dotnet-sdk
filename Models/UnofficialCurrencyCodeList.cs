using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// List of unofficial currency codes
/// </summary>
public record UnofficialCurrencyCodeList
{
    /// <summary>
    /// Cardano
    /// </summary>
    [JsonPropertyName("ADA")]
    public required string Ada { get; init; }

    /// <summary>
    /// Basic Attention Token
    /// </summary>
    [JsonPropertyName("BAT")]
    public required string Bat { get; init; }

    /// <summary>
    /// Bitcoin Cash
    /// </summary>
    [JsonPropertyName("BCH")]
    public required string Bch { get; init; }

    /// <summary>
    /// Binance Coin
    /// </summary>
    [JsonPropertyName("BNB")]
    public required string Bnb { get; init; }

    /// <summary>
    /// Bitcoin
    /// </summary>
    [JsonPropertyName("BTC")]
    public required string Btc { get; init; }

    /// <summary>
    /// Bitcoin Gold
    /// </summary>
    [JsonPropertyName("BTG")]
    public required string Btg { get; init; }

    /// <summary>
    /// Chinese Yuan (offshore)
    /// </summary>
    [JsonPropertyName("CNH")]
    public required string Cnh { get; init; }

    /// <summary>
    /// Dash
    /// </summary>
    [JsonPropertyName("DASH")]
    public required string Dash { get; init; }

    /// <summary>
    /// Dogecoin
    /// </summary>
    [JsonPropertyName("DOGE")]
    public required string Doge { get; init; }

    /// <summary>
    /// Ethereum Classic
    /// </summary>
    [JsonPropertyName("ETC")]
    public required string Etc { get; init; }

    /// <summary>
    /// Ethereum
    /// </summary>
    [JsonPropertyName("ETH")]
    public required string Eth { get; init; }

    /// <summary>
    /// Pence sterling, i.e. British penny
    /// </summary>
    [JsonPropertyName("GBX")]
    public required string Gbx { get; init; }

    /// <summary>
    /// Lisk
    /// </summary>
    [JsonPropertyName("LSK")]
    public required string Lsk { get; init; }

    /// <summary>
    /// Neo
    /// </summary>
    [JsonPropertyName("NEO")]
    public required string Neo { get; init; }

    /// <summary>
    /// OmiseGO
    /// </summary>
    [JsonPropertyName("OMG")]
    public required string Omg { get; init; }

    /// <summary>
    /// Qtum
    /// </summary>
    [JsonPropertyName("QTUM")]
    public required string Qtum { get; init; }

    /// <summary>
    /// TehterUS
    /// </summary>
    [JsonPropertyName("USDT")]
    public required string Usdt { get; init; }

    /// <summary>
    /// Stellar Lumen
    /// </summary>
    [JsonPropertyName("XLM")]
    public required string Xlm { get; init; }

    /// <summary>
    /// Monero
    /// </summary>
    [JsonPropertyName("XMR")]
    public required string Xmr { get; init; }

    /// <summary>
    /// Ripple
    /// </summary>
    [JsonPropertyName("XRP")]
    public required string Xrp { get; init; }

    /// <summary>
    /// Zcash
    /// </summary>
    [JsonPropertyName("ZEC")]
    public required string Zec { get; init; }

    /// <summary>
    /// 0x
    /// </summary>
    [JsonPropertyName("ZRX")]
    public required string Zrx { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
