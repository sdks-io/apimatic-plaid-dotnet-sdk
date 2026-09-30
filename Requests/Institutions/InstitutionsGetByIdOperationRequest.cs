using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Institutions;

/// <summary>
/// The inputs of the InstitutionsGetById operation.
/// </summary>
public sealed record InstitutionsGetByIdOperationRequest
{
    public required InstitutionsGetByIdRequest Body { get; init; }
}
