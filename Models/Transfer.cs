using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Represents a transfer within the Transfers API.
/// </summary>
public record Transfer
{
    /// <summary>
    /// Plaid’s unique identifier for a transfer.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

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
    /// The account ID that should be credited/debited for this transfer.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.
    /// </summary>
    [JsonPropertyName("type")]
    public required TransferType1 Type { get; init; }

    /// <summary>
    /// The legal name and other information for the account holder.
    /// </summary>
    [JsonPropertyName("user")]
    public required TransferUserInResponse User { get; init; }

    /// <summary>
    /// The amount of the transfer (decimal string with two digits of precision e.g. “10.00”).
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// The description of the transfer.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The datetime when this transfer was created. This will be of the form <c>2006-01-02T15:04:05Z</c>
    /// </summary>
    [JsonPropertyName("created")]
    public required DateTimeOffset Created { get; init; }

    /// <summary>
    /// The status of the transfer.
    /// </summary>
    [JsonPropertyName("status")]
    public required TransferStatus Status { get; init; }

    /// <summary>
    /// The network or rails used for the transfer. Valid options are <c>ach</c> or <c>same-day-ach</c>.
    /// </summary>
    [JsonPropertyName("network")]
    public required TransferNetwork Network { get; init; }

    /// <summary>
    /// When <c>true</c>, you can still cancel this transfer.
    /// </summary>
    [JsonPropertyName("cancellable")]
    public required bool Cancellable { get; init; }

    /// <summary>
    /// The failure reason if the type of this transfer is <c>"failed"</c> or <c>"reversed"</c>. Null value otherwise.
    /// </summary>
    [JsonPropertyName("failure_reason")]
    public required TransferFailure FailureReason { get; init; }

    /// <summary>
    /// The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply:
    /// - The JSON values must be Strings (no nested JSON objects allowed)
    /// - Only ASCII characters may be used
    /// - Maximum of 50 key/value pairs
    /// - Maximum key length of 40 characters
    /// - Maximum value length of 500 characters
    /// </summary>
    [JsonPropertyName("metadata")]
    public required IReadOnlyDictionary<string, string> Metadata { get; init; }

    /// <summary>
    /// Plaid’s unique identifier for the origination account that was used for this transfer.
    /// </summary>
    [JsonPropertyName("origination_account_id")]
    public required string OriginationAccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
