using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.DepositSwitch;

/// <summary>
/// The inputs of the DepositSwitchGet operation.
/// </summary>
public sealed record DepositSwitchGetOperationRequest
{
    public required DepositSwitchGetRequest Body { get; init; }
}
