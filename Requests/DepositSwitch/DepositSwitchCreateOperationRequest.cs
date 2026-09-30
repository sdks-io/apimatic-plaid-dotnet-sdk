using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.DepositSwitch;

/// <summary>
/// The inputs of the DepositSwitchCreate operation.
/// </summary>
public sealed record DepositSwitchCreateOperationRequest
{
    public required DepositSwitchCreateRequest Body { get; init; }
}
