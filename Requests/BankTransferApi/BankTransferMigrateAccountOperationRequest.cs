using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.BankTransferApi;

/// <summary>
/// The inputs of the BankTransferMigrateAccount operation.
/// </summary>
public sealed record BankTransferMigrateAccountOperationRequest
{
    public required BankTransferMigrateAccountRequest Body { get; init; }
}
