using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The account subtype of the account, either <c>checking</c> or <c>savings</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountSubtype1>))]
public sealed record AccountSubtype1 : OpenStringEnum<AccountSubtype1>
{
    private AccountSubtype1(string value) : base(value)
    {
    }

    public static readonly AccountSubtype1 Checking = new("checking");

    public static readonly AccountSubtype1 Savings = new("savings");

    public TResult Match<TResult>(Func<TResult> onChecking, Func<TResult> onSavings, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Checking => onChecking(),
            _ when this == Savings => onSavings(),
            _ => otherwise(Value)
        };

    public void Match(Action onChecking, Action onSavings, Action<string> otherwise)
    {
        if (this == Checking) onChecking();
        else if (this == Savings) onSavings();
        else otherwise(Value);
    }
}
