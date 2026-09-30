using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A credit card type account. Supported products for <c>credit</c> accounts are: Balance, Transactions, Identity, and Liabilities.
/// </summary>
public record CreditAccount
{
    /// <summary>
    /// Bank-issued credit card
    /// </summary>
    [JsonPropertyName("credit card")]
    public required string CreditCard { get; init; }

    /// <summary>
    /// PayPal-issued credit card
    /// </summary>
    [JsonPropertyName("paypal")]
    public required string Paypal { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
