using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when the status of an income verification instance has changed. It will typically take several minutes for this webhook to fire after the end user has uploaded their documents in the Document Income flow.
/// </summary>
public record IncomeVerificationStatusWebhook
{
    /// <summary>
    /// <c>"INCOME"</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>income_verification</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The <c>income_verification_id</c> of the verification instance whose status is being reported.
    /// </summary>
    [JsonPropertyName("income_verification_id")]
    public required string IncomeVerificationId { get; init; }

    /// <summary>
    /// <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>: The income verification status processing has completed.
    /// <para>
    /// <c>VERIFICATION_STATUS_UPLOAD_ERROR</c>: An upload error occurred when the end user attempted to upload their verification documentation.
    /// </para>
    /// <para>
    /// <c>VERIFICATION_STATUS_INVALID_TYPE</c>: The end user attempted to upload verification documentation in an unsupported file format.
    /// </para>
    /// <para>
    /// <c>VERIFICATION_STATUS_DOCUMENT_REJECTED</c>: The documentation uploaded by the end user was recognized as a supported file format, but not recognized as a valid paystub.
    /// </para>
    /// <para>
    /// <c>VERIFICATION_STATUS_PROCESSING_FAILED</c>: A failure occurred when attempting to process the verification documentation.
    /// </para>
    /// </summary>
    [JsonPropertyName("verification_status")]
    public required string VerificationStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
