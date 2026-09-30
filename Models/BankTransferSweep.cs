using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// BankTransferSweep describes a sweep transfer.
/// </summary>
public record BankTransferSweep
{
    /// <summary>
    /// Identifier of the sweep.
    /// </summary>
    [JsonPropertyName("id")]
    [Minimum(0)]
    public required long Id { get; init; }

    /// <summary>
    /// Identifier of the sweep transfer.
    /// </summary>
    [JsonPropertyName("transfer_id")]
    public required string? TransferId { get; init; }

    /// <summary>
    /// The datetime when the sweep occurred, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// The amount of the sweep.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// The currency of the sweep, e.g. "USD".
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    /// <summary>
    /// The account where the funds are swept to.
    /// </summary>
    [JsonPropertyName("sweep_account")]
    public required BankTransferSweepAccount SweepAccount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
