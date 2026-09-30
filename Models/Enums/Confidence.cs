using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Confidence>))]
public sealed record Confidence : OpenStringEnum<Confidence>
{
    private Confidence(string value) : base(value)
    {
    }

    public static readonly Confidence High = new("HIGH");

    public static readonly Confidence Low = new("LOW");

    public static readonly Confidence Unknown = new("UNKNOWN");

    public TResult Match<TResult>(Func<TResult> onHigh,
        Func<TResult> onLow,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == High => onHigh(),
            _ when this == Low => onLow(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onHigh, Action onLow, Action onUnknown, Action<string> otherwise)
    {
        if (this == High) onHigh();
        else if (this == Low) onLow();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
