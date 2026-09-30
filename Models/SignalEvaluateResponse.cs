using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// SignalEvaluateResponse defines the response schema for <c>/signal/income/evaluate</c>
/// </summary>
public record SignalEvaluateResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// Risk scoring details broken down by risk category.
    /// </summary>
    [JsonPropertyName("scores")]
    public required SignalEvaluateScores Scores { get; init; }

    /// <summary>
    /// The core attributes object contains additional data that can be used to assess the ACH return risk, such as past ACH return events, balance/transaction history, the Item’s connection history in the Plaid network, and identity change history.
    /// </summary>
    [JsonPropertyName("core_attributes")]
    public required SignalEvaluateCoreAttributes CoreAttributes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
