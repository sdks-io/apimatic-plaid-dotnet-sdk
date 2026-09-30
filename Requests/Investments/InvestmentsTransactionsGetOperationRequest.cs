using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Investments;

/// <summary>
/// The inputs of the InvestmentsTransactionsGet operation.
/// </summary>
public sealed record InvestmentsTransactionsGetOperationRequest
{
    public required InvestmentsTransactionsGetRequest Body { get; init; }
}
