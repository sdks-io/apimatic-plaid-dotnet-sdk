using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues.  Error fields will be <c>null</c> if no error has occurred.
/// </summary>
public record ErrorError
{
    /// <summary>
    /// A broad categorization of the error. Safe for programatic use.
    /// </summary>
    [JsonPropertyName("error_type")]
    public required ErrorType ErrorType { get; init; }

    /// <summary>
    /// The particular error code. Safe for programmatic use.
    /// </summary>
    [JsonPropertyName("error_code")]
    public required string ErrorCode { get; init; }

    /// <summary>
    /// A developer-friendly representation of the error code. This may change over time and is not safe for programmatic use.
    /// </summary>
    [JsonPropertyName("error_message")]
    public required string ErrorMessage { get; init; }

    /// <summary>
    /// A user-friendly representation of the error code. <c>null</c> if the error is not related to user action.
    /// <para>
    /// This may change over time and is not safe for programmatic use.
    /// </para>
    /// </summary>
    [JsonPropertyName("display_message")]
    public required string? DisplayMessage { get; init; }

    /// <summary>
    /// A unique ID identifying the request, to be used for troubleshooting purposes. This field will be omitted in errors provided by webhooks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_id")]
    public string? RequestId { get; init; }

    /// <summary>
    /// In the Assets product, a request can pertain to more than one Item. If an error is returned for such a request, <c>causes</c> will return an array of errors containing a breakdown of these errors on the individual Item level, if any can be identified.
    /// <para>
    /// <c>causes</c> will only be provided for the <c>error_type</c> <c>ASSET_REPORT_ERROR</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("causes")]
    public IReadOnlyList<object>? Causes { get; init; }

    /// <summary>
    /// The HTTP status code associated with the error. This will only be returned in the response body when the error information is provided via a webhook.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public double? Status { get; init; }

    /// <summary>
    /// The URL of a Plaid documentation page with more information about the error
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documentation_url")]
    public string? DocumentationUrl { get; init; }

    /// <summary>
    /// Suggested steps for resolving the error
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suggested_action")]
    public string? SuggestedAction { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
