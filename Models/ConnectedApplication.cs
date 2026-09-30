using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Describes the connected application for a particular end user.
/// </summary>
public record ConnectedApplication
{
    /// <summary>
    /// This field will map to the application ID that is returned from /item/applications/list, or provided to the institution in an oauth redirect.
    /// </summary>
    [JsonPropertyName("application_id")]
    public required string ApplicationId { get; init; }

    /// <summary>
    /// The name of the application
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// A URL that links to the application logo image (will be deprecated in the future, please use logo_url).
    /// </summary>
    [JsonPropertyName("logo")]
    public required string? Logo { get; init; }

    /// <summary>
    /// A URL that links to the application logo image.
    /// </summary>
    [JsonPropertyName("logo_url")]
    public required string? LogoUrl { get; init; }

    /// <summary>
    /// The URL for the application's website
    /// </summary>
    [JsonPropertyName("application_url")]
    public required string? ApplicationUrl { get; init; }

    /// <summary>
    /// A string provided by the connected app stating why they use their respective enabled products.
    /// </summary>
    [JsonPropertyName("reason_for_access")]
    public required string? ReasonForAccess { get; init; }

    /// <summary>
    /// The date this application was linked in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> (YYYY-MM-DD) format in UTC.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// (Deprecated) A list of enums representing the data collected and products enabled for this connected application.
    /// </summary>
    [JsonPropertyName("product_data_types")]
    public required IReadOnlyList<ProductDataType> ProductDataTypes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scopes")]
    public ScopesNullable? Scopes { get; init; }

    /// <summary>
    /// Scope of required and optional account features or content from a ConnectedApplication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requested_scopes")]
    public RequestedScopes? RequestedScopes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
