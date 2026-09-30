using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>: The income verification status processing has completed.
/// <para>
/// <c>VERIFICATION_STATUS_DOCUMENT_REJECTED</c>: The documentation uploaded by the end user was recognized as a supported file format, but not recognized as a valid paystub.
/// </para>
/// <para>
/// <c>VERIFICATION_STATUS_PROCESSING_FAILED</c>: A failure occurred when attempting to process the verification documentation.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerificationStatus3>))]
public sealed record VerificationStatus3 : OpenStringEnum<VerificationStatus3>
{
    private VerificationStatus3(string value) : base(value)
    {
    }

    public static readonly VerificationStatus3 VerificationStatusProcessingComplete = new(
        "VERIFICATION_STATUS_PROCESSING_COMPLETE");

    public static readonly VerificationStatus3 VerificationStatusDocumentRejected = new(
        "VERIFICATION_STATUS_DOCUMENT_REJECTED");

    public static readonly VerificationStatus3 VerificationStatusProcessingFailed = new(
        "VERIFICATION_STATUS_PROCESSING_FAILED");

    public TResult Match<TResult>(Func<TResult> onVerificationStatusProcessingComplete,
        Func<TResult> onVerificationStatusDocumentRejected,
        Func<TResult> onVerificationStatusProcessingFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == VerificationStatusProcessingComplete => onVerificationStatusProcessingComplete(),
            _ when this == VerificationStatusDocumentRejected => onVerificationStatusDocumentRejected(),
            _ when this == VerificationStatusProcessingFailed => onVerificationStatusProcessingFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onVerificationStatusProcessingComplete,
        Action onVerificationStatusDocumentRejected,
        Action onVerificationStatusProcessingFailed,
        Action<string> otherwise)
    {
        if (this == VerificationStatusProcessingComplete) onVerificationStatusProcessingComplete();
        else if (this == VerificationStatusDocumentRejected) onVerificationStatusDocumentRejected();
        else if (this == VerificationStatusProcessingFailed) onVerificationStatusProcessingFailed();
        else otherwise(Value);
    }
}
