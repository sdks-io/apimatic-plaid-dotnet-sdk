using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The network or rails used for the transfer. Valid options are <c>ach</c> or <c>same-day-ach</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferNetwork>))]
public sealed record TransferNetwork : OpenStringEnum<TransferNetwork>
{
    private TransferNetwork(string value) : base(value)
    {
    }

    public static readonly TransferNetwork Ach = new("ach");

    public static readonly TransferNetwork SameDayAch = new("same-day-ach");

    public TResult Match<TResult>(Func<TResult> onAch, Func<TResult> onSameDayAch, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ach => onAch(),
            _ when this == SameDayAch => onSameDayAch(),
            _ => otherwise(Value)
        };

    public void Match(Action onAch, Action onSameDayAch, Action<string> otherwise)
    {
        if (this == Ach) onAch();
        else if (this == SameDayAch) onSameDayAch();
        else otherwise(Value);
    }
}
