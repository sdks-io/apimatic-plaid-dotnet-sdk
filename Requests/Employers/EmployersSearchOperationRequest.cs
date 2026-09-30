using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Employers;

/// <summary>
/// The inputs of the EmployersSearch operation.
/// </summary>
public sealed record EmployersSearchOperationRequest
{
    public required EmployersSearchRequest Body { get; init; }
}
