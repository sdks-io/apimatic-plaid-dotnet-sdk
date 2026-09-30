using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Transactions;

/// <summary>
/// The inputs of the TransactionsRefresh operation.
/// </summary>
public sealed record TransactionsRefreshOperationRequest
{
    public required TransactionsRefreshRequest Body { get; init; }
}
