using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.ItemApi;

/// <summary>
/// The inputs of the ItemPublicTokenExchange operation.
/// </summary>
public sealed record ItemPublicTokenExchangeOperationRequest
{
    public required ItemPublicTokenExchangeRequest Body { get; init; }
}
