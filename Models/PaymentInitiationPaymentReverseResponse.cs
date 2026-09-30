using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationPaymentReverseResponse defines the response schema for <c>/payment_initation/payment/reverse</c>
/// </summary>
public record PaymentInitiationPaymentReverseResponse
{
    /// <summary>
    /// A unique ID identifying the refund
    /// </summary>
    [JsonPropertyName("refund_id")]
    public required string RefundId { get; init; }

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
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
