using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// DepositSwitchCreateResponse defines the response schema for <c>/deposit_switch/create</c>
/// </summary>
public record DepositSwitchCreateResponse
{
    /// <summary>
    /// ID of the deposit switch. This ID is persisted throughout the lifetime of the deposit switch.
    /// </summary>
    [JsonPropertyName("deposit_switch_id")]
    public required string DepositSwitchId { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
