using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// DepositSwitchCreateRequest defines the request schema for <c>/deposit_switch/create</c>
/// </summary>
public record DepositSwitchCreateRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// Access token for the target Item, typically provided in the Import Item response.
    /// </summary>
    [JsonPropertyName("target_access_token")]
    public required string TargetAccessToken { get; init; }

    /// <summary>
    /// Plaid Account ID that specifies the target bank account. This account will become the recipient for a user's direct deposit.
    /// </summary>
    [JsonPropertyName("target_account_id")]
    public required string TargetAccountId { get; init; }

    /// <summary>
    /// ISO-3166-1 alpha-2 country code standard.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country_code")]
    public CountryCode1? CountryCode { get; init; }

    /// <summary>
    /// Options to configure the <c>/deposit_switch/create</c> request. If provided, cannot be <c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public DepositSwitchCreateRequestOptions? Options { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
