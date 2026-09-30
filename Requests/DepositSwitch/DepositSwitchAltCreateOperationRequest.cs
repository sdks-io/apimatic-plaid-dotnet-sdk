using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.DepositSwitch;

/// <summary>
/// The inputs of the DepositSwitchAltCreate operation.
/// </summary>
public sealed record DepositSwitchAltCreateOperationRequest
{
    public required DepositSwitchAltCreateRequest Body { get; init; }
}
