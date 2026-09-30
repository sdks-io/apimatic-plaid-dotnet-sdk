using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Income;

/// <summary>
/// The inputs of the IncomeVerificationPaystubsGet operation.
/// </summary>
public sealed record IncomeVerificationPaystubsGetOperationRequest
{
    public required IncomeVerificationPaystubsGetRequest Body { get; init; }
}
