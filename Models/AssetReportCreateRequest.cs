using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// AssetReportCreateRequest defines the request schema for <c>/asset_report/create</c>
/// </summary>
public record AssetReportCreateRequest
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
    /// An array of access tokens corresponding to the Items that will be included in the report. The <c>assets</c> product must have been initialized for the Items during link; the Assets product cannot be added after initialization.
    /// </summary>
    [JsonPropertyName("access_tokens")]
    [MinLength(1)]
    [MaxLength(99)]
    public required IReadOnlyList<string> AccessTokens { get; init; }

    /// <summary>
    /// The maximum integer number of days of history to include in the Asset Report. If using Fannie Mae Day 1 Certainty, <c>days_requested</c> must be at least 61 for new originations or at least 31 for refinancings.
    /// </summary>
    [JsonPropertyName("days_requested")]
    [Minimum(0)]
    [Maximum(730)]
    public required int DaysRequested { get; init; }

    /// <summary>
    /// An optional object to filter <c>/asset_report/create</c> results. If provided, must be non-<c>null</c>. The optional <c>user</c> object is required for the report to be eligible for Fannie Mae's Day 1 Certainty program.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public AssetReportCreateRequestOptions? Options { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
