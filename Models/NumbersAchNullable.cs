using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

public record NumbersAchNullable
{
    /// <summary>
    /// The Plaid account ID associated with the account numbers
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The ACH account number for the account.
    /// <para>
    /// Note that when using OAuth with Chase Bank (<c>ins_56</c>), Chase will issue "tokenized" routing and account numbers, which are not the user's actual account and routing numbers. These tokenized numbers should work identically to normal account and routing numbers. The digits returned in the mask field will continue to reflect the actual account number, rather than the tokenized account number. If a user revokes their permissions to your app, the tokenized numbers will continue to work for ACH deposits, but not withdrawals.
    /// </para>
    /// </summary>
    [JsonPropertyName("account")]
    public required string Account { get; init; }

    /// <summary>
    /// The ACH routing number for the account. If the institution is <c>ins_56</c>, this may be a tokenized routing number. For more information, see the description of the <c>account</c> field.
    /// </summary>
    [JsonPropertyName("routing")]
    public required string Routing { get; init; }

    /// <summary>
    /// The wire transfer routing number for the account, if available
    /// </summary>
    [JsonPropertyName("wire_routing")]
    public required string? WireRouting { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
