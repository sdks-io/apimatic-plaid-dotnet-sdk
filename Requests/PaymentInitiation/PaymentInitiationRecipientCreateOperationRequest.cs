using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.PaymentInitiation;

/// <summary>
/// The inputs of the PaymentInitiationRecipientCreate operation.
/// </summary>
public sealed record PaymentInitiationRecipientCreateOperationRequest
{
    public required PaymentInitiationRecipientCreateRequest Body { get; init; }
}
