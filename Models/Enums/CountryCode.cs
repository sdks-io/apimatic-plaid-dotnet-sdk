using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// ISO-3166-1 alpha-2 country code standard.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CountryCode>))]
public sealed record CountryCode : OpenStringEnum<CountryCode>
{
    private CountryCode(string value) : base(value)
    {
    }

    public static readonly CountryCode Us = new("US");

    public static readonly CountryCode Gb = new("GB");

    public static readonly CountryCode Es = new("ES");

    public static readonly CountryCode Nl = new("NL");

    public static readonly CountryCode Fr = new("FR");

    public static readonly CountryCode Ie = new("IE");

    public static readonly CountryCode Ca = new("CA");

    public TResult Match<TResult>(Func<TResult> onUs,
        Func<TResult> onGb,
        Func<TResult> onEs,
        Func<TResult> onNl,
        Func<TResult> onFr,
        Func<TResult> onIe,
        Func<TResult> onCa,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Us => onUs(),
            _ when this == Gb => onGb(),
            _ when this == Es => onEs(),
            _ when this == Nl => onNl(),
            _ when this == Fr => onFr(),
            _ when this == Ie => onIe(),
            _ when this == Ca => onCa(),
            _ => otherwise(Value)
        };

    public void Match(Action onUs,
        Action onGb,
        Action onEs,
        Action onNl,
        Action onFr,
        Action onIe,
        Action onCa,
        Action<string> otherwise)
    {
        if (this == Us) onUs();
        else if (this == Gb) onGb();
        else if (this == Es) onEs();
        else if (this == Nl) onNl();
        else if (this == Fr) onFr();
        else if (this == Ie) onIe();
        else if (this == Ca) onCa();
        else otherwise(Value);
    }
}
