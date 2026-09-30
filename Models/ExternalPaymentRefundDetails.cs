using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

public record ExternalPaymentRefundDetails
{
    /// <summary>
    /// The name of the account holder.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The International Bank Account Number (IBAN) for the account.
    /// </summary>
    [JsonPropertyName("iban")]
    public required string? Iban { get; init; }

    [JsonPropertyName("bacs")]
    public required RecipientBacsNullable Bacs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
