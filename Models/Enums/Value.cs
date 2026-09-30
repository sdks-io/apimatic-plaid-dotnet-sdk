using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The frequency of the pay period.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Value>))]
public sealed record Value : OpenStringEnum<Value>
{
    private Value(string value) : base(value)
    {
    }

    public static readonly Value Monthly = new("monthly");

    public static readonly Value Semimonthly = new("semimonthly");

    public static readonly Value Weekly = new("weekly");

    public static readonly Value Biweekly = new("biweekly");

    public static readonly Value Unknown = new("unknown");

    public static readonly Value Null = new("null");

    public TResult Match<TResult>(Func<TResult> onMonthly,
        Func<TResult> onSemimonthly,
        Func<TResult> onWeekly,
        Func<TResult> onBiweekly,
        Func<TResult> onUnknown,
        Func<TResult> onNull,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Monthly => onMonthly(),
            _ when this == Semimonthly => onSemimonthly(),
            _ when this == Weekly => onWeekly(),
            _ when this == Biweekly => onBiweekly(),
            _ when this == Unknown => onUnknown(),
            _ when this == Null => onNull(),
            _ => otherwise(Value)
        };

    public void Match(Action onMonthly,
        Action onSemimonthly,
        Action onWeekly,
        Action onBiweekly,
        Action onUnknown,
        Action onNull,
        Action<string> otherwise)
    {
        if (this == Monthly) onMonthly();
        else if (this == Semimonthly) onSemimonthly();
        else if (this == Weekly) onWeekly();
        else if (this == Biweekly) onBiweekly();
        else if (this == Unknown) onUnknown();
        else if (this == Null) onNull();
        else otherwise(Value);
    }
}
