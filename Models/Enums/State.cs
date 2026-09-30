using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The state, or status, of the deposit switch.
/// <list type="bullet">
///   <item><description><c>initialized</c> – The deposit switch has been initialized with the user entering the information required to submit the deposit switch request.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>processing</c> – The deposit switch request has been submitted and is being processed.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>completed</c> – The user's employer has fulfilled the deposit switch request.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>error</c> – There was an error processing the deposit switch request.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State>))]
public sealed record State : OpenStringEnum<State>
{
    private State(string value) : base(value)
    {
    }

    public static readonly State Initialized = new("initialized");

    public static readonly State Processing = new("processing");

    public static readonly State Completed = new("completed");

    public static readonly State Error = new("error");

    public TResult Match<TResult>(Func<TResult> onInitialized,
        Func<TResult> onProcessing,
        Func<TResult> onCompleted,
        Func<TResult> onError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Initialized => onInitialized(),
            _ when this == Processing => onProcessing(),
            _ when this == Completed => onCompleted(),
            _ when this == Error => onError(),
            _ => otherwise(Value)
        };

    public void Match(Action onInitialized,
        Action onProcessing,
        Action onCompleted,
        Action onError,
        Action<string> otherwise)
    {
        if (this == Initialized) onInitialized();
        else if (this == Processing) onProcessing();
        else if (this == Completed) onCompleted();
        else if (this == Error) onError();
        else otherwise(Value);
    }
}
