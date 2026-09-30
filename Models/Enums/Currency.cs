using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The ISO-4217 currency code of the payment. For standing orders, <c>"GBP"</c> must be used.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Currency>))]
public sealed record Currency : OpenStringEnum<Currency>
{
    private Currency(string value) : base(value)
    {
    }

    public static readonly Currency Gbp = new("GBP");

    public static readonly Currency Eur = new("EUR");

    public TResult Match<TResult>(Func<TResult> onGbp, Func<TResult> onEur, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Gbp => onGbp(),
            _ when this == Eur => onEur(),
            _ => otherwise(Value)
        };

    public void Match(Action onGbp, Action onEur, Action<string> otherwise)
    {
        if (this == Gbp) onGbp();
        else if (this == Eur) onEur();
        else otherwise(Value);
    }
}
