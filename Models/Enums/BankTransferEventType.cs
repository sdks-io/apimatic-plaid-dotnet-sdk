using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of event that this bank transfer represents.
/// <para>
/// <c>pending</c>: A new transfer was created; it is in the pending state.
/// </para>
/// <para>
/// <c>cancelled</c>: The transfer was cancelled by the client.
/// </para>
/// <para>
/// <c>failed</c>: The transfer failed, no funds were moved.
/// </para>
/// <para>
/// <c>posted</c>: The transfer has been successfully submitted to the payment network.
/// </para>
/// <para>
/// <c>reversed</c>: A posted transfer was reversed.
/// </para>
/// <para>
/// <c>receiver_pending</c>: The matching transfer was found as a pending transaction in the receiver's account
/// </para>
/// <para>
/// <c>receiver_posted</c>: The matching transfer was found as a posted transaction in the receiver's account
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankTransferEventType>))]
public sealed record BankTransferEventType : OpenStringEnum<BankTransferEventType>
{
    private BankTransferEventType(string value) : base(value)
    {
    }

    public static readonly BankTransferEventType Pending = new("pending");

    public static readonly BankTransferEventType Cancelled = new("cancelled");

    public static readonly BankTransferEventType Failed = new("failed");

    public static readonly BankTransferEventType Posted = new("posted");

    public static readonly BankTransferEventType Reversed = new("reversed");

    public static readonly BankTransferEventType ReceiverPending = new("receiver_pending");

    public static readonly BankTransferEventType ReceiverPosted = new("receiver_posted");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onCancelled,
        Func<TResult> onFailed,
        Func<TResult> onPosted,
        Func<TResult> onReversed,
        Func<TResult> onReceiverPending,
        Func<TResult> onReceiverPosted,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Cancelled => onCancelled(),
            _ when this == Failed => onFailed(),
            _ when this == Posted => onPosted(),
            _ when this == Reversed => onReversed(),
            _ when this == ReceiverPending => onReceiverPending(),
            _ when this == ReceiverPosted => onReceiverPosted(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onCancelled,
        Action onFailed,
        Action onPosted,
        Action onReversed,
        Action onReceiverPending,
        Action onReceiverPosted,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Cancelled) onCancelled();
        else if (this == Failed) onFailed();
        else if (this == Posted) onPosted();
        else if (this == Reversed) onReversed();
        else if (this == ReceiverPending) onReceiverPending();
        else if (this == ReceiverPosted) onReceiverPosted();
        else otherwise(Value);
    }
}
