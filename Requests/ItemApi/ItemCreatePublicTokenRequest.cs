using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.ItemApi;

/// <summary>
/// The inputs of the ItemCreatePublicToken operation.
/// </summary>
public sealed record ItemCreatePublicTokenRequest
{
    public required ItemPublicTokenCreateRequest Body { get; init; }
}
