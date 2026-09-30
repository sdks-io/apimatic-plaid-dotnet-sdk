using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The previous status of the payment.
/// <para>
/// <c>PAYMENT_STATUS_INPUT_NEEDED</c>: This is the initial state of all payments. It indicates that the payment is waiting on user input to continue processing. A payment may re-enter this state later on if further input is needed.
/// </para>
/// <para>
/// <c>PAYMENT_STATUS_PROCESSING</c>: The payment is currently being processed. The payment will automatically exit this state when processing is complete.
/// </para>
/// <para>
/// <c>PAYMENT_STATUS_INITIATED</c>: The payment has been successfully initiated and is considered complete.
/// </para>
/// <para>
/// <c>PAYMENT_STATUS_COMPLETED</c>: Indicates that the standing order has been successfully established. This state is only used for standing orders.
/// </para>
/// <para>
/// <c>PAYMENT_STATUS_INSUFFICIENT_FUNDS</c>: The payment has failed due to insufficient funds.
/// </para>
/// <para>
/// <c>PAYMENT_STATUS_FAILED</c>: The payment has failed to be initiated. This error is retryable once the root cause is resolved.
/// </para>
/// <para>
/// <c>PAYMENT_STATUS_BLOCKED</c>: The payment has been blocked. This is a retryable error.
/// </para>
/// <para>
/// <c>PAYMENT_STATUS_UNKNOWN</c>: The payment status is unknown.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OldPaymentStatus>))]
public sealed record OldPaymentStatus : OpenStringEnum<OldPaymentStatus>
{
    private OldPaymentStatus(string value) : base(value)
    {
    }

    public static readonly OldPaymentStatus PaymentStatusInputNeeded = new("PAYMENT_STATUS_INPUT_NEEDED");

    public static readonly OldPaymentStatus PaymentStatusProcessing = new("PAYMENT_STATUS_PROCESSING");

    public static readonly OldPaymentStatus PaymentStatusInitiated = new("PAYMENT_STATUS_INITIATED");

    public static readonly OldPaymentStatus PaymentStatusCompleted = new("PAYMENT_STATUS_COMPLETED");

    public static readonly OldPaymentStatus PaymentStatusInsufficientFunds = new("PAYMENT_STATUS_INSUFFICIENT_FUNDS");

    public static readonly OldPaymentStatus PaymentStatusFailed = new("PAYMENT_STATUS_FAILED");

    public static readonly OldPaymentStatus PaymentStatusBlocked = new("PAYMENT_STATUS_BLOCKED");

    public static readonly OldPaymentStatus PaymentStatusUnknown = new("PAYMENT_STATUS_UNKNOWN");

    public TResult Match<TResult>(Func<TResult> onPaymentStatusInputNeeded,
        Func<TResult> onPaymentStatusProcessing,
        Func<TResult> onPaymentStatusInitiated,
        Func<TResult> onPaymentStatusCompleted,
        Func<TResult> onPaymentStatusInsufficientFunds,
        Func<TResult> onPaymentStatusFailed,
        Func<TResult> onPaymentStatusBlocked,
        Func<TResult> onPaymentStatusUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PaymentStatusInputNeeded => onPaymentStatusInputNeeded(),
            _ when this == PaymentStatusProcessing => onPaymentStatusProcessing(),
            _ when this == PaymentStatusInitiated => onPaymentStatusInitiated(),
            _ when this == PaymentStatusCompleted => onPaymentStatusCompleted(),
            _ when this == PaymentStatusInsufficientFunds => onPaymentStatusInsufficientFunds(),
            _ when this == PaymentStatusFailed => onPaymentStatusFailed(),
            _ when this == PaymentStatusBlocked => onPaymentStatusBlocked(),
            _ when this == PaymentStatusUnknown => onPaymentStatusUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onPaymentStatusInputNeeded,
        Action onPaymentStatusProcessing,
        Action onPaymentStatusInitiated,
        Action onPaymentStatusCompleted,
        Action onPaymentStatusInsufficientFunds,
        Action onPaymentStatusFailed,
        Action onPaymentStatusBlocked,
        Action onPaymentStatusUnknown,
        Action<string> otherwise)
    {
        if (this == PaymentStatusInputNeeded) onPaymentStatusInputNeeded();
        else if (this == PaymentStatusProcessing) onPaymentStatusProcessing();
        else if (this == PaymentStatusInitiated) onPaymentStatusInitiated();
        else if (this == PaymentStatusCompleted) onPaymentStatusCompleted();
        else if (this == PaymentStatusInsufficientFunds) onPaymentStatusInsufficientFunds();
        else if (this == PaymentStatusFailed) onPaymentStatusFailed();
        else if (this == PaymentStatusBlocked) onPaymentStatusBlocked();
        else if (this == PaymentStatusUnknown) onPaymentStatusUnknown();
        else otherwise(Value);
    }
}
