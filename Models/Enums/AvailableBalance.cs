using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The sign of the available balance for the receiver bank account associated with the receiver event at the time the matching transaction was found. Can be <c>positive</c>, <c>negative</c>, or null if the balance was not available at the time.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AvailableBalance>))]
public sealed record AvailableBalance : OpenStringEnum<AvailableBalance>
{
    private AvailableBalance(string value) : base(value)
    {
    }

    public static readonly AvailableBalance Positive = new("positive");

    public static readonly AvailableBalance Negative = new("negative");

    public TResult Match<TResult>(Func<TResult> onPositive,
        Func<TResult> onNegative,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Positive => onPositive(),
            _ when this == Negative => onNegative(),
            _ => otherwise(Value)
        };

    public void Match(Action onPositive, Action onNegative, Action<string> otherwise)
    {
        if (this == Positive) onPositive();
        else if (this == Negative) onNegative();
        else otherwise(Value);
    }
}
