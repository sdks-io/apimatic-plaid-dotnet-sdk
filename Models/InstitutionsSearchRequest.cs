using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// InstitutionsSearchRequest defines the request schema for <c>/institutions/search</c>
/// </summary>
public record InstitutionsSearchRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The search query. Institutions with names matching the query are returned
    /// </summary>
    [JsonPropertyName("query")]
    public required string Query { get; init; }

    /// <summary>
    /// Filter the Institutions based on whether they support all products listed in <c>products</c>. Provide <c>null</c> to get institutions regardless of supported products. Note that when <c>auth</c> is specified as a product, if you are enabled for Instant Match or Automated Micro-deposits, institutions that support those products will be returned even if <c>auth</c> is not present in their product array.
    /// </summary>
    [JsonPropertyName("products")]
    [MinLength(1)]
    public required IReadOnlyList<Products> Products { get; init; }

    /// <summary>
    /// Specify an array of Plaid-supported country codes this institution supports, using the ISO-3166-1 alpha-2 country code standard.
    /// </summary>
    [JsonPropertyName("country_codes")]
    public required IReadOnlyList<CountryCode> CountryCodes { get; init; }

    /// <summary>
    /// An optional object to filter <c>/institutions/search</c> results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public InstitutionsSearchRequestOptions? Options { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
