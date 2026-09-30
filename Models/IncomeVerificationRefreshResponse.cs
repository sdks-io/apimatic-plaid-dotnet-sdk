using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// IncomeVerificationRequestResponse defines the response schema for <c>/income/verification/refresh</c>
/// </summary>
public record IncomeVerificationRefreshResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// The verification refresh status. One of the following:
    /// <para>
    /// <c>"VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED"</c> User presence is required to refresh an income verification.
    /// </para>
    /// </summary>
    [JsonPropertyName("verification_refresh_status")]
    public required string VerificationRefreshStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
