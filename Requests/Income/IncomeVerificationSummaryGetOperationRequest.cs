using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Income;

/// <summary>
/// The inputs of the IncomeVerificationSummaryGet operation.
/// </summary>
public sealed record IncomeVerificationSummaryGetOperationRequest
{
    public required IncomeVerificationSummaryGetRequest Body { get; init; }
}
