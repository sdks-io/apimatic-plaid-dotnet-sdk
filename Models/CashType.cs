using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Activity that modifies a cash position
/// </summary>
public record CashType
{
    /// <summary>
    /// Fees paid for account maintenance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account fee")]
    public string? AccountFee { get; init; }

    /// <summary>
    /// Inflow of assets into a tax-advantaged account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contribution")]
    public string? Contribution { get; init; }

    /// <summary>
    /// Inflow of cash into an account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deposit")]
    public string? Deposit { get; init; }

    /// <summary>
    /// Inflow of cash from a dividend
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dividend")]
    public string? Dividend { get; init; }

    /// <summary>
    /// Inflow of stock from a distribution
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stock distribution")]
    public string? StockDistribution { get; init; }

    /// <summary>
    /// Inflow of cash from interest
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interest")]
    public string? Interest { get; init; }

    /// <summary>
    /// Fees paid for legal charges or services
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legal fee")]
    public string? LegalFee { get; init; }

    /// <summary>
    /// Long-term capital gain received as cash
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("long-term capital gain")]
    public string? LongTermCapitalGain { get; init; }

    /// <summary>
    /// Fees paid for investment management of a mutual fund or other pooled investment vehicle
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("management fee")]
    public string? ManagementFee { get; init; }

    /// <summary>
    /// Fees paid for maintaining margin debt
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("margin expense")]
    public string? MarginExpense { get; init; }

    /// <summary>
    /// Inflow of cash from a non-qualified dividend
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("non-qualified dividend")]
    public string? NonQualifiedDividend { get; init; }

    /// <summary>
    /// Taxes paid on behalf of the investor for non-residency in investment jurisdiction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("non-resident tax")]
    public string? NonResidentTax { get; init; }

    /// <summary>
    /// Pending inflow of cash
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pending credit")]
    public string? PendingCredit { get; init; }

    /// <summary>
    /// Pending outflow of cash
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pending debit")]
    public string? PendingDebit { get; init; }

    /// <summary>
    /// Inflow of cash from a qualified dividend
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qualified dividend")]
    public string? QualifiedDividend { get; init; }

    /// <summary>
    /// Short-term capital gain received as cash
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("short-term capital gain")]
    public string? ShortTermCapitalGain { get; init; }

    /// <summary>
    /// Taxes paid on behalf of the investor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax")]
    public string? Tax { get; init; }

    /// <summary>
    /// Taxes withheld on behalf of the customer
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax withheld")]
    public string? TaxWithheld { get; init; }

    /// <summary>
    /// Fees incurred for transfer of a holding or account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfer fee")]
    public string? TransferFee { get; init; }

    /// <summary>
    /// Fees related to adminstration of a trust account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trust fee")]
    public string? TrustFee { get; init; }

    /// <summary>
    /// Unqualified capital gain received as cash
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unqualified gain")]
    public string? UnqualifiedGain { get; init; }

    /// <summary>
    /// Outflow of cash from an account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("withdrawal")]
    public string? Withdrawal { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
