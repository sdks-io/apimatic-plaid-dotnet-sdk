using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// SignalDecisionReportRequest defines the request schema for <c>/signal/decision/report</c>
/// </summary>
public record SignalDecisionReportRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// Must be the same as the <c>client_transaction_id</c> supplied when calling <c>/signal/evaluate</c>
    /// </summary>
    [JsonPropertyName("client_transaction_id")]
    public required string ClientTransactionId { get; init; }

    /// <summary>
    /// <c>true</c> if the ACH transaction was initiated, <c>false</c> otherwise.
    /// </summary>
    [JsonPropertyName("initiated")]
    public required bool Initiated { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
