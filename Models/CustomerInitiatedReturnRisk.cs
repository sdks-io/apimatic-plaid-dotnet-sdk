using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// The object contains a risk score and a risk tier that evaluate the transaction return risk of an unauthorized debit. Common return codes in this category include: “R05”, "R07", "R10", "R11", "R29". These returns typically have a return time frame of up to 60 calendar days. During this period, the customer of financial institutions can dispute a transaction as unauthorized.
/// </summary>
public record CustomerInitiatedReturnRisk
{
    /// <summary>
    /// A score from 0-99 that indicates the transaction return risk: a higher risk score suggests a higher return likelihood.
    /// </summary>
    [JsonPropertyName("score")]
    [Minimum(0)]
    [Maximum(100)]
    public required int Score { get; init; }

    /// <summary>
    /// A tier corresponding to the projected likelihood that the transaction, if initiated, will be subject to a return.
    /// <para>
    /// In the <c>customer_initiated_return_risk</c> object, there are five risk tiers corresponding to the scores:
    ///   1: Predicted customer-initiated return incidence rate between 0.00% - 0.02%
    ///   2: Predicted customer-initiated return incidence rate between 0.02% - 0.05%
    ///   3: Predicted customer-initiated return incidence rate between 0.05% - 0.1%
    ///   4: Predicted customer-initiated return incidence rate between 0.1% - 0.5%
    ///   5: Predicted customer-initiated return incidence rate greater than 0.5%
    /// </para>
    /// </summary>
    [JsonPropertyName("risk_tier")]
    [Minimum(1)]
    [Maximum(5)]
    public required int RiskTier { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
