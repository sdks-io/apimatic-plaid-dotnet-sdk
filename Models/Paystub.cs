using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing data extracted from the end user's paystub.
/// </summary>
public record Paystub
{
    /// <summary>
    /// An object with the deduction information found on a paystub.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deductions")]
    public Deductions? Deductions { get; init; }

    /// <summary>
    /// An identifier of the document referenced by the document metadata.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("doc_id")]
    public string? DocId { get; init; }

    /// <summary>
    /// An object representing both a breakdown of earnings on a paystub and the total earnings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("earnings")]
    public Earnings? Earnings { get; init; }

    [JsonPropertyName("employer")]
    public required Employer2 Employer { get; init; }

    /// <summary>
    /// Data about the employee.
    /// </summary>
    [JsonPropertyName("employee")]
    public required Employee Employee { get; init; }

    /// <summary>
    /// An object representing employment details found on a paystub.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employment_details")]
    public EmploymentDetails? EmploymentDetails { get; init; }

    /// <summary>
    /// An object representing information about the net pay amount on the paystub.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("net_pay")]
    public NetPay? NetPay { get; init; }

    /// <summary>
    /// Details about the pay period.
    /// </summary>
    [JsonPropertyName("pay_period_details")]
    public required PayPeriodDetails PayPeriodDetails { get; init; }

    /// <summary>
    /// An object representing details that can be found on the paystub.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paystub_details")]
    public PaystubDetails? PaystubDetails { get; init; }

    [JsonPropertyName("income_breakdown")]
    public required IReadOnlyList<IncomeBreakdown> IncomeBreakdown { get; init; }

    /// <summary>
    /// The amount of income earned year to date, as based on paystub data.
    /// </summary>
    [JsonPropertyName("ytd_earnings")]
    public required PaystubYtdDetails YtdEarnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
