using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Income;

/// <summary>
/// The inputs of the IncomeVerificationRefresh operation.
/// </summary>
public sealed record IncomeVerificationRefreshOperationRequest
{
    public required IncomeVerificationRefreshRequest Body { get; init; }
}
