using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The rationale for Plaid's decision regarding a proposed transfer. Will be null for <c>approved</c> decisions.
/// </summary>
public record TransferAuthorizationDecisionRationale
{
    /// <summary>
    /// A code representing the rationale for permitting or declining the proposed transfer. Possible values are:
    /// <para>
    /// <c>NSF</c> – Transaction likely to result in a return due to insufficient funds.
    /// </para>
    /// <para>
    /// <c>RISK</c> - Transaction is high-risk.
    /// </para>
    /// <para>
    /// <c>MANUALLY_VERIFIED_ITEM</c> – Item created via same-day micro deposits, limited information available. Plaid can only offer <c>permitted</c> as a transaction decision.
    /// </para>
    /// <para>
    /// <c>LOGIN_REQUIRED</c> – Unable to collect the account information required for an authorization decision due to Item staleness. Can be rectified using Link update mode.
    /// </para>
    /// <para>
    /// <c>ERROR</c> – Unable to collect the account information required for an authorization decision due to an error.
    /// </para>
    /// </summary>
    [JsonPropertyName("code")]
    public required Code Code { get; init; }

    /// <summary>
    /// A human-readable description of the code associated with a permitted transfer or transfer decline.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
