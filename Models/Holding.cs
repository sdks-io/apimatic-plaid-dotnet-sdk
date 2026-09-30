using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A securities holding at an institution.
/// </summary>
public record Holding
{
    /// <summary>
    /// The Plaid <c>account_id</c> associated with the holding.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The Plaid <c>security_id</c> associated with the holding.
    /// </summary>
    [JsonPropertyName("security_id")]
    public required string SecurityId { get; init; }

    /// <summary>
    /// The last price given by the institution for this security.
    /// </summary>
    [JsonPropertyName("institution_price")]
    public required double InstitutionPrice { get; init; }

    /// <summary>
    /// The date at which <c>institution_price</c> was current.
    /// </summary>
    [JsonPropertyName("institution_price_as_of")]
    public required DateTimeOffset? InstitutionPriceAsOf { get; init; }

    /// <summary>
    /// The value of the holding, as reported by the institution.
    /// </summary>
    [JsonPropertyName("institution_value")]
    public required double InstitutionValue { get; init; }

    /// <summary>
    /// The cost basis of the holding.
    /// </summary>
    [JsonPropertyName("cost_basis")]
    public required double? CostBasis { get; init; }

    /// <summary>
    /// The total quantity of the asset held, as reported by the financial institution. If the security is an option, <c>quantity</c> will reflect the total number of options (typically the number of contracts multiplied by 100), not the number of contracts.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required double Quantity { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the holding. Always <c>null</c> if <c>unofficial_currency_code</c> is non-<c>null</c>.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the holding. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
    /// <para>
    /// See the <see href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</see> for a full listing of supported <c>iso_currency_code</c>s.
    /// </para>
    /// </summary>
    [JsonPropertyName("unofficial_currency_code")]
    public required string? UnofficialCurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
