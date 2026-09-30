using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationRefund defines a payment initiation refund
/// </summary>
public record PaymentInitiationRefund
{
    /// <summary>
    /// The ID of the refund. Like all Plaid identifiers, the <c>refund_id</c> is case sensitive.
    /// </summary>
    [JsonPropertyName("refund_id")]
    public required string RefundId { get; init; }

    /// <summary>
    /// The amount and currency of a payment
    /// </summary>
    [JsonPropertyName("amount")]
    public required PaymentAmount Amount { get; init; }

    /// <summary>
    /// The status of the refund.
    /// <para>
    /// <c>PROCESSING</c>: The refund is currently being processed. The refund will automatically exit this state when processing is complete.
    /// </para>
    /// <para>
    /// <c>INITIATED</c>: The refund has been successfully initiated.
    /// </para>
    /// <para>
    /// <c>EXECUTED</c>: Indicates that the refund has been successfully executed.
    /// </para>
    /// <para>
    /// <c>FAILED</c>: The refund has failed to be executed. This error is retryable once the root cause is resolved.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status2 Status { get; init; }

    /// <summary>
    /// The date and time of the last time the <c>status</c> was updated, in IS0 8601 format
    /// </summary>
    [JsonPropertyName("last_status_update")]
    public required DateTimeOffset LastStatusUpdate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
