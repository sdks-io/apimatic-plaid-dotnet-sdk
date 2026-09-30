using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Sandbox;

/// <summary>
/// The inputs of the SandboxOauthSelectAccounts operation.
/// </summary>
public sealed record SandboxOauthSelectAccountsOperationRequest
{
    public required SandboxOauthSelectAccountsRequest Body { get; init; }
}
