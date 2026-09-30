using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// If the user is currently serving in the US military, the branch of the military they are serving in
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Branch>))]
public sealed record Branch : OpenStringEnum<Branch>
{
    private Branch(string value) : base(value)
    {
    }

    public static readonly Branch AirForce = new("AIR FORCE");

    public static readonly Branch Army = new("ARMY");

    public static readonly Branch CoastGuard = new("COAST GUARD");

    public static readonly Branch Marines = new("MARINES");

    public static readonly Branch Navy = new("NAVY");

    public TResult Match<TResult>(Func<TResult> onAirForce,
        Func<TResult> onArmy,
        Func<TResult> onCoastGuard,
        Func<TResult> onMarines,
        Func<TResult> onNavy,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AirForce => onAirForce(),
            _ when this == Army => onArmy(),
            _ when this == CoastGuard => onCoastGuard(),
            _ when this == Marines => onMarines(),
            _ when this == Navy => onNavy(),
            _ => otherwise(Value)
        };

    public void Match(Action onAirForce,
        Action onArmy,
        Action onCoastGuard,
        Action onMarines,
        Action onNavy,
        Action<string> otherwise)
    {
        if (this == AirForce) onAirForce();
        else if (this == Army) onArmy();
        else if (this == CoastGuard) onCoastGuard();
        else if (this == Marines) onMarines();
        else if (this == Navy) onNavy();
        else otherwise(Value);
    }
}
