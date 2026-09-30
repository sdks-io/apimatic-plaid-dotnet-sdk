using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Institutions;

/// <summary>
/// The inputs of the InstitutionsGet operation.
/// </summary>
public sealed record InstitutionsGetOperationRequest
{
    public required InstitutionsGetRequest Body { get; init; }
}
