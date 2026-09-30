using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates the direction of the transfer: <c>outbound</c>: for API-initiated transfers
/// <c>inbound</c>: for payments received by the FBO account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankTransferDirection1>))]
public sealed record BankTransferDirection1 : OpenStringEnum<BankTransferDirection1>
{
    private BankTransferDirection1(string value) : base(value)
    {
    }

    public static readonly BankTransferDirection1 Inbound = new("inbound");

    public static readonly BankTransferDirection1 Outbound = new("outbound");

    public TResult Match<TResult>(Func<TResult> onInbound, Func<TResult> onOutbound, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Inbound => onInbound(),
            _ when this == Outbound => onOutbound(),
            _ => otherwise(Value)
        };

    public void Match(Action onInbound, Action onOutbound, Action<string> otherwise)
    {
        if (this == Inbound) onInbound();
        else if (this == Outbound) onOutbound();
        else otherwise(Value);
    }
}
