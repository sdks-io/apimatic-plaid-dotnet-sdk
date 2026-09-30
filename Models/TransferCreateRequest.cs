using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/transfer/create</c>
/// </summary>
public record TransferCreateRequest
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
    /// A random key provided by the client, per unique transfer. Maximum of 50 characters.
    /// <para>
    /// The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. For example, if a request to create a transfer fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single transfer is created.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MaxLength(50)]
    public required string IdempotencyKey { get; init; }

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
    /// Plaid’s unique identifier for a transfer authorization.
    /// </summary>
    [JsonPropertyName("authorization_id")]
    public required string AuthorizationId { get; init; }

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
    /// The transfer description. Maximum of 10 characters.
    /// </summary>
    [JsonPropertyName("description")]
    [MaxLength(10)]
    public required string Description { get; init; }

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
    /// The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply:
    /// - The JSON values must be Strings (no nested JSON objects allowed)
    /// - Only ASCII characters may be used
    /// - Maximum of 50 key/value pairs
    /// - Maximum key length of 40 characters
    /// - Maximum value length of 500 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }

    /// <summary>
    /// Plaid’s unique identifier for the origination account for this transfer. If you have more than one origination account, this value must be specified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("origination_account_id")]
    public string? OriginationAccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
