using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// DepositSwitchTokenCreateResponse defines the response schema for <c>/deposit_switch/token/create</c>
/// </summary>
public record DepositSwitchTokenCreateResponse
{
    /// <summary>
    /// Deposit switch token, used to initialize Link for the Deposit Switch product
    /// </summary>
    [JsonPropertyName("deposit_switch_token")]
    public required string DepositSwitchToken { get; init; }

    /// <summary>
    /// Expiration time of the token, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format
    /// </summary>
    [JsonPropertyName("deposit_switch_token_expiration_time")]
    public required string DepositSwitchTokenExpirationTime { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
