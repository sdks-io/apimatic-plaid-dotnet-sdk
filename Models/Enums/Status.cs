using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// <c>HEALTHY</c>: the majority of requests are successful
/// <c>DEGRADED</c>: only some requests are successful
/// <c>DOWN</c>: all requests are failing
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status>))]
public sealed record Status : OpenStringEnum<Status>
{
    private Status(string value) : base(value)
    {
    }

    public static readonly Status Healthy = new("HEALTHY");

    public static readonly Status Degraded = new("DEGRADED");

    public static readonly Status Down = new("DOWN");

    public TResult Match<TResult>(Func<TResult> onHealthy,
        Func<TResult> onDegraded,
        Func<TResult> onDown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Healthy => onHealthy(),
            _ when this == Degraded => onDegraded(),
            _ when this == Down => onDown(),
            _ => otherwise(Value)
        };

    public void Match(Action onHealthy, Action onDegraded, Action onDown, Action<string> otherwise)
    {
        if (this == Healthy) onHealthy();
        else if (this == Degraded) onDegraded();
        else if (this == Down) onDown();
        else otherwise(Value);
    }
}
