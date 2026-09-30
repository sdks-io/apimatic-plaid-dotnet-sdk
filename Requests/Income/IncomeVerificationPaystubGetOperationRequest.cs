using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Income;

/// <summary>
/// The inputs of the IncomeVerificationPaystubGet operation.
/// </summary>
public sealed record IncomeVerificationPaystubGetOperationRequest
{
    public required IncomeVerificationPaystubGetRequest Body { get; init; }
}
