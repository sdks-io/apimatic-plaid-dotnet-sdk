using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.DepositSwitch;

/// <summary>
/// The inputs of the DepositSwitchTokenCreate operation.
/// </summary>
public sealed record DepositSwitchTokenCreateOperationRequest
{
    public required DepositSwitchTokenCreateRequest Body { get; init; }
}
