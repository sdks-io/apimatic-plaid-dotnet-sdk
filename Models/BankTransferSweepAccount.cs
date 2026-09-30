using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The account where the funds are swept to.
/// </summary>
public record BankTransferSweepAccount
{
    [JsonPropertyName("account_number")]
    public required string AccountNumber { get; init; }

    [JsonPropertyName("routing_number")]
    public required string RoutingNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
