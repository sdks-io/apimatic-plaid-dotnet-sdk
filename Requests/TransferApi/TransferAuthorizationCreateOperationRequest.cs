using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.TransferApi;

/// <summary>
/// The inputs of the TransferAuthorizationCreate operation.
/// </summary>
public sealed record TransferAuthorizationCreateOperationRequest
{
    public required TransferAuthorizationCreateRequest Body { get; init; }
}
