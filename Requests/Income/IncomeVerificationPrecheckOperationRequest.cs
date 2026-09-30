using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Income;

/// <summary>
/// The inputs of the IncomeVerificationPrecheck operation.
/// </summary>
public sealed record IncomeVerificationPrecheckOperationRequest
{
    public required IncomeVerificationPrecheckRequest Body { get; init; }
}
