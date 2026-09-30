using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Represents an event in the Transfers API.
/// </summary>
public record TransferEvent
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
    /// The type of event that this transfer represents.
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
    /// </summary>
    [JsonPropertyName("event_type")]
    public required TransferEventType EventType { get; init; }

    /// <summary>
    /// The account ID associated with the transfer.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// Plaid’s unique identifier for a transfer.
    /// </summary>
    [JsonPropertyName("transfer_id")]
    public required string TransferId { get; init; }

    /// <summary>
    /// The ID of the origination account that this balance belongs to.
    /// </summary>
    [JsonPropertyName("origination_account_id")]
    public required string? OriginationAccountId { get; init; }

    /// <summary>
    /// The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.
    /// </summary>
    [JsonPropertyName("transfer_type")]
    public required TransferType1 TransferType { get; init; }

    /// <summary>
    /// The amount of the transfer (decimal string with two digits of precision e.g. “10.00”).
    /// </summary>
    [JsonPropertyName("transfer_amount")]
    public required string TransferAmount { get; init; }

    /// <summary>
    /// The failure reason if the type of this transfer is <c>"failed"</c> or <c>"reversed"</c>. Null value otherwise.
    /// </summary>
    [JsonPropertyName("failure_reason")]
    public required TransferFailure FailureReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
