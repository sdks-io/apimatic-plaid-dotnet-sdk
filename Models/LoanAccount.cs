using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A loan type account. Supported products for <c>loan</c> accounts are: Balance, Liabilities, and Transactions.
/// </summary>
public record LoanAccount
{
    /// <summary>
    /// Auto loan
    /// </summary>
    [JsonPropertyName("auto")]
    public required string Auto { get; init; }

    /// <summary>
    /// Business loan
    /// </summary>
    [JsonPropertyName("business")]
    public required string Business { get; init; }

    /// <summary>
    /// Commercial loan
    /// </summary>
    [JsonPropertyName("commercial")]
    public required string Commercial { get; init; }

    /// <summary>
    /// Construction loan
    /// </summary>
    [JsonPropertyName("construction")]
    public required string Construction { get; init; }

    /// <summary>
    /// Consumer loan
    /// </summary>
    [JsonPropertyName("consumer")]
    public required string Consumer { get; init; }

    /// <summary>
    /// Home Equity Line of Credit (HELOC)
    /// </summary>
    [JsonPropertyName("home equity")]
    public required string HomeEquity { get; init; }

    /// <summary>
    /// General loan
    /// </summary>
    [JsonPropertyName("loan")]
    public required string Loan { get; init; }

    /// <summary>
    /// Mortgage loan
    /// </summary>
    [JsonPropertyName("mortgage")]
    public required string Mortgage { get; init; }

    /// <summary>
    /// Pre-approved overdraft account, usually tied to a checking account
    /// </summary>
    [JsonPropertyName("overdraft")]
    public required string Overdraft { get; init; }

    /// <summary>
    /// Pre-approved line of credit
    /// </summary>
    [JsonPropertyName("line of credit")]
    public required string LineOfCredit { get; init; }

    /// <summary>
    /// Student loan
    /// </summary>
    [JsonPropertyName("student")]
    public required string Student { get; init; }

    /// <summary>
    /// Other loan type or unknown loan type
    /// </summary>
    [JsonPropertyName("other")]
    public required string Other { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
