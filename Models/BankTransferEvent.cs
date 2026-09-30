using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Represents an event in the Bank Transfers API.
/// </summary>
public record BankTransferEvent
{
    /// <summary>
    /// Plaid’s unique identifier for this event. IDs are sequential unsigned 64-bit integers.
    /// </summary>
    [JsonPropertyName("event_id")]
    [Minimum(0)]
    public required int EventId { get; init; }

    /// <summary>
    /// The datetime when this event occurred. This will be of the form <c>2006-01-02T15:04:05Z</c>.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    /// <summary>
    /// The type of event that this bank transfer represents.
    /// <para>
    /// <c>pending</c>: A new transfer was created; it is in the pending state.
    /// </para>
    /// <para>
    /// <c>cancelled</c>: The transfer was cancelled by the client.
    /// </para>
    /// <para>
    /// <c>failed</c>: The transfer failed, no funds were moved.
    /// </para>
    /// <para>
    /// <c>posted</c>: The transfer has been successfully submitted to the payment network.
    /// </para>
    /// <para>
    /// <c>reversed</c>: A posted transfer was reversed.
    /// </para>
    /// <para>
    /// <c>receiver_pending</c>: The matching transfer was found as a pending transaction in the receiver's account
    /// </para>
    /// <para>
    /// <c>receiver_posted</c>: The matching transfer was found as a posted transaction in the receiver's account
    /// </para>
    /// </summary>
    [JsonPropertyName("event_type")]
    public required BankTransferEventType EventType { get; init; }

    /// <summary>
    /// The account ID associated with the bank transfer.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// Plaid’s unique identifier for a bank transfer.
    /// </summary>
    [JsonPropertyName("bank_transfer_id")]
    public required string BankTransferId { get; init; }

    /// <summary>
    /// The ID of the origination account that this balance belongs to.
    /// </summary>
    [JsonPropertyName("origination_account_id")]
    public required string? OriginationAccountId { get; init; }

    /// <summary>
    /// The type of bank transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.
    /// </summary>
    [JsonPropertyName("bank_transfer_type")]
    public required BankTransferType BankTransferType { get; init; }

    /// <summary>
    /// The bank transfer amount.
    /// </summary>
    [JsonPropertyName("bank_transfer_amount")]
    public required string BankTransferAmount { get; init; }

    /// <summary>
    /// The currency of the bank transfer amount.
    /// </summary>
    [JsonPropertyName("bank_transfer_iso_currency_code")]
    public required string BankTransferIsoCurrencyCode { get; init; }

    /// <summary>
    /// The failure reason if the type of this transfer is <c>"failed"</c> or <c>"reversed"</c>. Null value otherwise.
    /// </summary>
    [JsonPropertyName("failure_reason")]
    public required BankTransferFailure FailureReason { get; init; }

    /// <summary>
    /// Indicates the direction of the transfer: <c>outbound</c> for API-initiated transfers, or <c>inbound</c> for payments received by the FBO account.
    /// </summary>
    [JsonPropertyName("direction")]
    public required BankTransferDirection Direction { get; init; }

    /// <summary>
    /// The receiver details if the type of this event is <c>reciever_pending</c> or <c>reciever_posted</c>. Null value otherwise.
    /// </summary>
    [JsonPropertyName("receiver_details")]
    public required BankTransferReceiverDetails ReceiverDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
