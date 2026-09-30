using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the refund.
/// <para>
/// <c>PROCESSING</c>: The refund is currently being processed. The refund will automatically exit this state when processing is complete.
/// </para>
/// <para>
/// <c>INITIATED</c>: The refund has been successfully initiated.
/// </para>
/// <para>
/// <c>EXECUTED</c>: Indicates that the refund has been successfully executed.
/// </para>
/// <para>
/// <c>FAILED</c>: The refund has failed to be executed. This error is retryable once the root cause is resolved.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status2>))]
public sealed record Status2 : OpenStringEnum<Status2>
{
    private Status2(string value) : base(value)
    {
    }

    public static readonly Status2 Processing = new("PROCESSING");

    public static readonly Status2 Executed = new("EXECUTED");

    public static readonly Status2 Initiated = new("INITIATED");

    public static readonly Status2 Failed = new("FAILED");

    public TResult Match<TResult>(Func<TResult> onProcessing,
        Func<TResult> onExecuted,
        Func<TResult> onInitiated,
        Func<TResult> onFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Processing => onProcessing(),
            _ when this == Executed => onExecuted(),
            _ when this == Initiated => onInitiated(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onProcessing,
        Action onExecuted,
        Action onInitiated,
        Action onFailed,
        Action<string> otherwise)
    {
        if (this == Processing) onProcessing();
        else if (this == Executed) onExecuted();
        else if (this == Initiated) onInitiated();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
