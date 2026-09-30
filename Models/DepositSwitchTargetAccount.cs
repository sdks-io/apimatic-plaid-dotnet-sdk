using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

public record DepositSwitchTargetAccount
{
    /// <summary>
    /// Account number for deposit switch destination
    /// </summary>
    [JsonPropertyName("account_number")]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// Routing number for deposit switch destination
    /// </summary>
    [JsonPropertyName("routing_number")]
    public required string RoutingNumber { get; init; }

    /// <summary>
    /// The name of the deposit switch destination account, as it will be displayed to the end user in the Deposit Switch interface. It is not required to match the name used in online banking.
    /// </summary>
    [JsonPropertyName("account_name")]
    public required string AccountName { get; init; }

    /// <summary>
    /// The account subtype of the account, either <c>checking</c> or <c>savings</c>.
    /// </summary>
    [JsonPropertyName("account_subtype")]
    public required AccountSubtype1 AccountSubtype { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
