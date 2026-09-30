using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Scope of required and optional account features or content from a ConnectedApplication.
/// </summary>
public record RequestedScopes
{
    /// <summary>
    /// The product access being requested. Used to or disallow product access across all accounts. If unset, defaults to all products allowed.
    /// </summary>
    [JsonPropertyName("required_product_access")]
    public required ProductAccess RequiredProductAccess { get; init; }

    /// <summary>
    /// The product access being requested. Used to or disallow product access across all accounts. If unset, defaults to all products allowed.
    /// </summary>
    [JsonPropertyName("optional_product_access")]
    public required ProductAccess OptionalProductAccess { get; init; }

    /// <summary>
    /// Enumerates the account subtypes that the application wishes for the user to be able to select from. For more details refer to Plaid documentation on account filters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_filters")]
    public AccountFilter? AccountFilters { get; init; }

    /// <summary>
    /// The application requires that accounts be limited to a specific cardinality.
    /// <c>MULTI_SELECT</c>: indicates that the user should be allowed to pick multiple accounts.
    /// <c>SINGLE_SELECT</c>: indicates that the user should be allowed to pick only a single account.
    /// <c>ALL</c>: indicates that the user must share all of their accounts and should not be given the opportunity to de-select
    /// </summary>
    [JsonPropertyName("account_selection_cardinality")]
    public required AccountSelectionCardinality AccountSelectionCardinality { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
