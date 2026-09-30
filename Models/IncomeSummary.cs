using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The verified fields from a paystub verification. All fields are provided as reported on the paystub.
/// </summary>
public record IncomeSummary
{
    [JsonPropertyName("employer_name")]
    public required EmployerIncomeSummaryFieldString EmployerName { get; init; }

    [JsonPropertyName("employee_name")]
    public required EmployeeIncomeSummaryFieldString EmployeeName { get; init; }

    [JsonPropertyName("ytd_gross_income")]
    public required YtdGrossIncomeSummaryFieldNumber YtdGrossIncome { get; init; }

    [JsonPropertyName("ytd_net_income")]
    public required YtdNetIncomeSummaryFieldNumber YtdNetIncome { get; init; }

    [JsonPropertyName("pay_frequency")]
    public required PayFrequency PayFrequency { get; init; }

    [JsonPropertyName("projected_wage")]
    public required ProjectedIncomeSummaryFieldNumber ProjectedWage { get; init; }

    /// <summary>
    /// Information about the matched direct deposit transaction used to verify a user's payroll information.
    /// </summary>
    [JsonPropertyName("verified_transaction")]
    public required TransactionData VerifiedTransaction { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
