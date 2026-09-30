using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Fees on the account, e.g. commission, bookkeeping, options-related.
/// </summary>
public record FeeType
{
    /// <summary>
    /// Fees paid for account maintenance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account fee")]
    public string? AccountFee { get; init; }

    /// <summary>
    /// Increase or decrease in quantity of item
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjustment")]
    public string? Adjustment { get; init; }

    /// <summary>
    /// Inflow of cash from a dividend
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dividend")]
    public string? Dividend { get; init; }

    /// <summary>
    /// Inflow of cash from interest
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interest")]
    public string? Interest { get; init; }

    /// <summary>
    /// Inflow of cash from interest receivable
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interest receivable")]
    public string? InterestReceivable { get; init; }

    /// <summary>
    /// Long-term capital gain received as cash
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("long-term capital gain")]
    public string? LongTermCapitalGain { get; init; }

    /// <summary>
    /// Fees paid for legal charges or services
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legal fee")]
    public string? LegalFee { get; init; }

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
    /// Inflow of cash from a qualified dividend
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qualified dividend")]
    public string? QualifiedDividend { get; init; }

    /// <summary>
    /// Repayment of loan principal
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return of principal")]
    public string? ReturnOfPrincipal { get; init; }

    /// <summary>
    /// Short-term capital gain received as cash
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("short-term capital gain")]
    public string? ShortTermCapitalGain { get; init; }

    /// <summary>
    /// Inflow of stock from a distribution
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stock distribution")]
    public string? StockDistribution { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
