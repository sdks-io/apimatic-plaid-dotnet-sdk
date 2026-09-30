using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// SandboxIncomeFireWebhookRequest defines the request schema for <c>/sandbox/income/fire_webhook</c>
/// </summary>
public record SandboxIncomeFireWebhookRequest
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
    /// The ID of the verification.
    /// </summary>
    [JsonPropertyName("income_verification_id")]
    public required string IncomeVerificationId { get; init; }

    /// <summary>
    /// The URL to which the webhook should be sent.
    /// </summary>
    [JsonPropertyName("webhook")]
    public required string Webhook { get; init; }

    /// <summary>
    /// <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>: The income verification status processing has completed.
    /// <para>
    /// <c>VERIFICATION_STATUS_DOCUMENT_REJECTED</c>: The documentation uploaded by the end user was recognized as a supported file format, but not recognized as a valid paystub.
    /// </para>
    /// <para>
    /// <c>VERIFICATION_STATUS_PROCESSING_FAILED</c>: A failure occurred when attempting to process the verification documentation.
    /// </para>
    /// </summary>
    [JsonPropertyName("verification_status")]
    public required VerificationStatus3 VerificationStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
