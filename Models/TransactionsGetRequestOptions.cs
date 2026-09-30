using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.
/// </summary>
public record TransactionsGetRequestOptions
{
    /// <summary>
    /// A list of <c>account_ids</c> to retrieve for the Item
    /// <para>
    /// Note: An error will be returned if a provided <c>account_id</c> is not associated with the Item.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_ids")]
    public IReadOnlyList<string>? AccountIds { get; init; }

    /// <summary>
    /// The number of transactions to fetch.
    /// </summary>
    [JsonPropertyName("count")]
    [Minimum(1)]
    [Maximum(500)]
    public int? Count { get; init; } = 100;

    /// <summary>
    /// The number of transactions to skip. The default value is 0.
    /// </summary>
    [JsonPropertyName("offset")]
    [Minimum(0)]
    public int? Offset { get; init; } = 0;

    /// <summary>
    /// Include the raw unparsed transaction description from the financial institution. This field is disabled by default. If you need this information in addition to the parsed data provided, contact your Plaid Account Manager.
    /// </summary>
    [JsonPropertyName("include_original_description")]
    public bool? IncludeOriginalDescription { get; init; } = false;

    /// <summary>
    /// Include the <c>personal_finance_category</c> object in the response. This feature is currently in beta – to request access, contact transactions-feedback@plaid.com.
    /// </summary>
    [JsonPropertyName("include_personal_finance_category_beta")]
    public bool? IncludePersonalFinanceCategoryBeta { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
