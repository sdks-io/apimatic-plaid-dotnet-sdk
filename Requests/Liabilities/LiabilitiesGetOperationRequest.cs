using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Liabilities;

/// <summary>
/// The inputs of the LiabilitiesGet operation.
/// </summary>
public sealed record LiabilitiesGetOperationRequest
{
    public required LiabilitiesGetRequest Body { get; init; }
}
