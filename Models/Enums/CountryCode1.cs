using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// ISO-3166-1 alpha-2 country code standard.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CountryCode1>))]
public sealed record CountryCode1 : OpenStringEnum<CountryCode1>
{
    private CountryCode1(string value) : base(value)
    {
    }

    public static readonly CountryCode1 Us = new("US");

    public static readonly CountryCode1 Ca = new("CA");

    public TResult Match<TResult>(Func<TResult> onUs, Func<TResult> onCa, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Us => onUs(),
            _ when this == Ca => onCa(),
            _ => otherwise(Value)
        };

    public void Match(Action onUs, Action onCa, Action<string> otherwise)
    {
        if (this == Us) onUs();
        else if (this == Ca) onCa();
        else otherwise(Value);
    }
}
