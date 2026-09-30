using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains details about a security
/// </summary>
public record Security
{
    /// <summary>
    /// A unique, Plaid-specific identifier for the security, used to associate securities with holdings. Like all Plaid identifiers, the <c>security_id</c> is case sensitive.
    /// </summary>
    [JsonPropertyName("security_id")]
    public required string SecurityId { get; init; }

    /// <summary>
    /// 12-character ISIN, a globally unique securities identifier.
    /// </summary>
    [JsonPropertyName("isin")]
    public required string? Isin { get; init; }

    /// <summary>
    /// 9-character CUSIP, an identifier assigned to North American securities.
    /// </summary>
    [JsonPropertyName("cusip")]
    public required string? Cusip { get; init; }

    /// <summary>
    /// 7-character SEDOL, an identifier assigned to securities in the UK.
    /// </summary>
    [JsonPropertyName("sedol")]
    public required string? Sedol { get; init; }

    /// <summary>
    /// An identifier given to the security by the institution
    /// </summary>
    [JsonPropertyName("institution_security_id")]
    public required string? InstitutionSecurityId { get; init; }

    /// <summary>
    /// If <c>institution_security_id</c> is present, this field indicates the Plaid <c>institution_id</c> of the institution to whom the identifier belongs.
    /// </summary>
    [JsonPropertyName("institution_id")]
    public required string? InstitutionId { get; init; }

    /// <summary>
    /// In certain cases, Plaid will provide the ID of another security whose performance resembles this security, typically when the original security has low volume, or when a private security can be modeled with a publicly traded security.
    /// </summary>
    [JsonPropertyName("proxy_security_id")]
    public required string? ProxySecurityId { get; init; }

    /// <summary>
    /// A descriptive name for the security, suitable for display.
    /// </summary>
    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    /// <summary>
    /// The security’s trading symbol for publicly traded securities, and otherwise a short identifier if available.
    /// </summary>
    [JsonPropertyName("ticker_symbol")]
    public required string? TickerSymbol { get; init; }

    /// <summary>
    /// Indicates that a security is a highly liquid asset and can be treated like cash.
    /// </summary>
    [JsonPropertyName("is_cash_equivalent")]
    public required bool? IsCashEquivalent { get; init; }

    /// <summary>
    /// The security type of the holding. Valid security types are:
    /// <para>
    /// <c>cash</c>: Cash, currency, and money market funds
    /// </para>
    /// <para>
    /// <c>derivative</c>: Options, warrants, and other derivative instruments
    /// </para>
    /// <para>
    /// <c>equity</c>: Domestic and foreign equities
    /// </para>
    /// <para>
    /// <c>etf</c>: Multi-asset exchange-traded investment funds
    /// </para>
    /// <para>
    /// <c>fixed income</c>: Bonds and certificates of deposit (CDs)
    /// </para>
    /// <para>
    /// <c>loan</c>: Loans and loan receivables.
    /// </para>
    /// <para>
    /// <c>mutual fund</c>: Open- and closed-end vehicles pooling funds of multiple investors.
    /// </para>
    /// <para>
    /// <c>other</c>: Unknown or other investment types
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required string? Type { get; init; }

    /// <summary>
    /// Price of the security at the close of the previous trading session. <c>null</c> for non-public securities. If the security is a foreign currency or a cryptocurrency this field will be updated daily and will be priced in USD.
    /// </summary>
    [JsonPropertyName("close_price")]
    public required double? ClosePrice { get; init; }

    /// <summary>
    /// Date for which <c>close_price</c> is accurate. Always <c>null</c> if <c>close_price</c> is <c>null</c>.
    /// </summary>
    [JsonPropertyName("close_price_as_of")]
    public required DateTimeOffset? ClosePriceAsOf { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the price given. Always <c>null</c> if <c>unofficial_currency_code</c> is non-<c>null</c>.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the security. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
    /// <para>
    /// See the <see href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</see> for a full listing of supported <c>iso_currency_code</c>s.
    /// </para>
    /// </summary>
    [JsonPropertyName("unofficial_currency_code")]
    public required string? UnofficialCurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
