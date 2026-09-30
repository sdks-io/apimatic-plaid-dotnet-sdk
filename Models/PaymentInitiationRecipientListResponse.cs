using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationRecipientListResponse defines the response schema for <c>/payment_initiation/recipient/list</c>
/// </summary>
public record PaymentInitiationRecipientListResponse
{
    /// <summary>
    /// An array of payment recipients created for Payment Initiation
    /// </summary>
    [JsonPropertyName("recipients")]
    public required IReadOnlyList<PaymentInitiationRecipient> Recipients { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
