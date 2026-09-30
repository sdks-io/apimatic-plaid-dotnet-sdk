using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An account type holding cash, in which funds are deposited. Supported products for <c>depository</c> accounts are: Auth, Balance, Transactions, Identity, Payment Initiation, and Assets.
/// </summary>
public record DepositoryAccount
{
    /// <summary>
    /// Checking account
    /// </summary>
    [JsonPropertyName("checking")]
    public required string Checking { get; init; }

    /// <summary>
    /// Savings account
    /// </summary>
    [JsonPropertyName("savings")]
    public required string Savings { get; init; }

    /// <summary>
    /// Health Savings Account (US only) that can only hold cash
    /// </summary>
    [JsonPropertyName("hsa")]
    public required string Hsa { get; init; }

    /// <summary>
    /// Certificate of deposit account
    /// </summary>
    [JsonPropertyName("cd")]
    public required string Cd { get; init; }

    /// <summary>
    /// Money market account
    /// </summary>
    [JsonPropertyName("money market")]
    public required string MoneyMarket { get; init; }

    /// <summary>
    /// PayPal depository account
    /// </summary>
    [JsonPropertyName("paypal")]
    public required string Paypal { get; init; }

    /// <summary>
    /// Prepaid debit card
    /// </summary>
    [JsonPropertyName("prepaid")]
    public required string Prepaid { get; init; }

    /// <summary>
    /// A cash management account, typically a cash account at a brokerage
    /// </summary>
    [JsonPropertyName("cash management")]
    public required string CashManagement { get; init; }

    /// <summary>
    /// An Electronic Benefit Transfer (EBT) account, used by certain public assistance programs to distribute funds (US only)
    /// </summary>
    [JsonPropertyName("ebt")]
    public required string Ebt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
