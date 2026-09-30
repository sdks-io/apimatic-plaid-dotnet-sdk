using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The schema below describes the various <c>types</c> and corresponding <c>subtypes</c> that Plaid recognizes and reports for financial institution accounts.
/// </summary>
public record StandaloneAccountType
{
    /// <summary>
    /// An account type holding cash, in which funds are deposited. Supported products for <c>depository</c> accounts are: Auth, Balance, Transactions, Identity, Payment Initiation, and Assets.
    /// </summary>
    [JsonPropertyName("depository")]
    public required DepositoryAccount Depository { get; init; }

    /// <summary>
    /// A credit card type account. Supported products for <c>credit</c> accounts are: Balance, Transactions, Identity, and Liabilities.
    /// </summary>
    [JsonPropertyName("credit")]
    public required CreditAccount Credit { get; init; }

    /// <summary>
    /// A loan type account. Supported products for <c>loan</c> accounts are: Balance, Liabilities, and Transactions.
    /// </summary>
    [JsonPropertyName("loan")]
    public required LoanAccount Loan { get; init; }

    /// <summary>
    /// An investment account. Supported products for <c>investment</c> accounts are: Balance and Investments.
    /// </summary>
    [JsonPropertyName("investment")]
    public required InvestmentAccountSubtype Investment { get; init; }

    /// <summary>
    /// Other or unknown account type. Supported products for <c>other</c> accounts are: Balance, Transactions, Identity, and Assets.
    /// </summary>
    [JsonPropertyName("other")]
    public required string Other { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
