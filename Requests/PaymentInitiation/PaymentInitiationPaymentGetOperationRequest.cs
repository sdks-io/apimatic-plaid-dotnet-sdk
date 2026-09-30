using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.PaymentInitiation;

/// <summary>
/// The inputs of the PaymentInitiationPaymentGet operation.
/// </summary>
public sealed record PaymentInitiationPaymentGetOperationRequest
{
    public required PaymentInitiationPaymentGetRequest Body { get; init; }
}
