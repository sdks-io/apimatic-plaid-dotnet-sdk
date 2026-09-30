using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the transfer.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferStatus>))]
public sealed record TransferStatus : OpenStringEnum<TransferStatus>
{
    private TransferStatus(string value) : base(value)
    {
    }

    public static readonly TransferStatus Pending = new("pending");

    public static readonly TransferStatus Posted = new("posted");

    public static readonly TransferStatus Cancelled = new("cancelled");

    public static readonly TransferStatus Failed = new("failed");

    public static readonly TransferStatus Reversed = new("reversed");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onPosted,
        Func<TResult> onCancelled,
        Func<TResult> onFailed,
        Func<TResult> onReversed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Posted => onPosted(),
            _ when this == Cancelled => onCancelled(),
            _ when this == Failed => onFailed(),
            _ when this == Reversed => onReversed(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onPosted,
        Action onCancelled,
        Action onFailed,
        Action onReversed,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Posted) onPosted();
        else if (this == Cancelled) onCancelled();
        else if (this == Failed) onFailed();
        else if (this == Reversed) onReversed();
        else otherwise(Value);
    }
}
