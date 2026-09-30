using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The receiver details if the type of this event is <c>reciever_pending</c> or <c>reciever_posted</c>. Null value otherwise.
/// </summary>
public record BankTransferReceiverDetails
{
    /// <summary>
    /// The sign of the available balance for the receiver bank account associated with the receiver event at the time the matching transaction was found. Can be <c>positive</c>, <c>negative</c>, or null if the balance was not available at the time.
    /// </summary>
    [JsonPropertyName("available_balance")]
    public required AvailableBalance AvailableBalance { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
