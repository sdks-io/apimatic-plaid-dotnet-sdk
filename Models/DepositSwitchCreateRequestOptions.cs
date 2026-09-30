using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Options to configure the <c>/deposit_switch/create</c> request. If provided, cannot be <c>null</c>.
/// </summary>
public record DepositSwitchCreateRequestOptions
{
    /// <summary>
    /// The URL registered to receive webhooks when the status of a deposit switch request has changed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook")]
    public string? Webhook { get; init; }

    /// <summary>
    /// An array of access tokens corresponding to transaction items to use when attempting to match the user to their Payroll Provider. These tokens must be created by the same client id as the one creating the switch, and have access to the transactions product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_item_access_tokens")]
    [MinLength(1)]
    [MaxLength(99)]
    public IReadOnlyList<string>? TransactionItemAccessTokens { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
