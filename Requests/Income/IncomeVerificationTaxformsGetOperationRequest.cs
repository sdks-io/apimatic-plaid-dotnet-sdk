using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Income;

/// <summary>
/// The inputs of the IncomeVerificationTaxformsGet operation.
/// </summary>
public sealed record IncomeVerificationTaxformsGetOperationRequest
{
    public required IncomeVerificationTaxformsGetRequest Body { get; init; }
}
