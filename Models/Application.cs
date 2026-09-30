using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata about the application
/// </summary>
public record Application
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
    /// The date this application was linked in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> (YYYY-MM-DD) format in UTC.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
