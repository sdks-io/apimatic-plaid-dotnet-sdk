using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the Payment Initiation (Europe) product. This field is required if <c>payment_initiation</c> is included in the <c>products</c> array.
/// </summary>
public record LinkTokenCreateRequestPaymentInitiation
{
    /// <summary>
    /// The <c>payment_id</c> provided by the <c>/payment_initiation/payment/create</c> endpoint.
    /// </summary>
    [JsonPropertyName("payment_id")]
    [MinLength(1)]
    public required string PaymentId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
