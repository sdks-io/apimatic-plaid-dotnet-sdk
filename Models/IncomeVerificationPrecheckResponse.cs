using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// IncomeVerificationPrecheckResponse defines the response schema for <c>/income/verification/precheck</c>.
/// </summary>
public record IncomeVerificationPrecheckResponse
{
    /// <summary>
    /// ID of the precheck.
    /// </summary>
    [JsonPropertyName("precheck_id")]
    public required string PrecheckId { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// The confidence that Plaid can support the user in the income verification flow. One of the following:
    /// <para>
    /// <c>"HIGH"</c>: This precheck information submitted is definitively tied to a Plaid-supported integration.
    /// </para>
    /// <para>
    /// "<c>LOW</c>": This precheck information submitted is known not to be supported by Plaid.
    /// </para>
    /// <para>
    /// <c>"UNKNOWN"</c>: It was not possible to determine if the user is supportable with the information passed.
    /// </para>
    /// </summary>
    [JsonPropertyName("confidence")]
    public required Confidence Confidence { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
