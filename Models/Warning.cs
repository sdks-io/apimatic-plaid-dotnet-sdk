using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// It is possible for an Asset Report to be returned with missing account owner information. In such cases, the Asset Report will contain warning data in the response, indicating why obtaining the owner information failed.
/// </summary>
public record Warning
{
    /// <summary>
    /// The warning type, which will always be <c>ASSET_REPORT_WARNING</c>
    /// </summary>
    [JsonPropertyName("warning_type")]
    public required string WarningType { get; init; }

    /// <summary>
    /// The warning code identifies a specific kind of warning. Currently, the only possible warning code is <c>OWNERS_UNAVAILABLE</c>, which indicates that account-owner information is not available.
    /// </summary>
    [JsonPropertyName("warning_code")]
    public required string WarningCode { get; init; }

    /// <summary>
    /// An error object and associated <c>item_id</c> used to identify a specific Item and error when a batch operation operating on multiple Items has encountered an error in one of the Items.
    /// </summary>
    [JsonPropertyName("cause")]
    public required Cause Cause { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
