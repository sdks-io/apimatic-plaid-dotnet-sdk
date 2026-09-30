using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/transfer/authorization/create</c>
/// </summary>
public record TransferAuthorizationCreateRequest
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
    /// The Plaid <c>access_token</c> for the account that will be debited or credited.
    /// </summary>
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; init; }

    /// <summary>
    /// The Plaid <c>account_id</c> for the account that will be debited or credited.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.
    /// </summary>
    [JsonPropertyName("type")]
    public required TransferType1 Type { get; init; }

    /// <summary>
    /// The network or rails used for the transfer. Valid options are <c>ach</c> or <c>same-day-ach</c>.
    /// </summary>
    [JsonPropertyName("network")]
    public required TransferNetwork Network { get; init; }

    /// <summary>
    /// The amount of the transfer (decimal string with two digits of precision e.g. “10.00”).
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// Specifies the use case of the transfer.  Required for transfers on an ACH network.
    /// <para>
    /// <c>"arc"</c> - Accounts Receivable Entry
    /// </para>
    /// <para>
    /// <c>"cbr</c>" - Cross Border Entry
    /// </para>
    /// <para>
    /// <c>"ccd"</c> - Corporate Credit or Debit - fund transfer between two corporate bank accounts
    /// </para>
    /// <para>
    /// <c>"cie"</c> - Customer Initiated Entry
    /// </para>
    /// <para>
    /// <c>"cor"</c> - Automated Notification of Change
    /// </para>
    /// <para>
    /// <c>"ctx"</c> - Corporate Trade Exchange
    /// </para>
    /// <para>
    /// <c>"iat"</c> - International
    /// </para>
    /// <para>
    /// <c>"mte"</c> - Machine Transfer Entry
    /// </para>
    /// <para>
    /// <c>"pbr"</c> - Cross Border Entry
    /// </para>
    /// <para>
    /// <c>"pop"</c> - Point-of-Purchase Entry
    /// </para>
    /// <para>
    /// <c>"pos"</c> - Point-of-Sale Entry
    /// </para>
    /// <para>
    /// <c>"ppd"</c> - Prearranged Payment or Deposit - the transfer is part of a pre-existing relationship with a consumer, eg. bill payment
    /// </para>
    /// <para>
    /// <c>"rck"</c> - Re-presented Check Entry
    /// </para>
    /// <para>
    /// <c>"tel"</c> - Telephone-Initiated Entry
    /// </para>
    /// <para>
    /// <c>"web"</c> - Internet-Initiated Entry - debits from a consumer’s account where their authorization is obtained over the Internet
    /// </para>
    /// </summary>
    [JsonPropertyName("ach_class")]
    public required AchClass AchClass { get; init; }

    /// <summary>
    /// The legal name and other information for the account holder.
    /// </summary>
    [JsonPropertyName("user")]
    public required TransferUserInRequest User { get; init; }

    /// <summary>
    /// Information about the device being used to initiate the authorization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device")]
    public TransferAuthorizationDevice? Device { get; init; }

    /// <summary>
    /// Plaid's unique identifier for the origination account for this authorization. If not specified, the default account will be used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("origination_account_id")]
    public string? OriginationAccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
