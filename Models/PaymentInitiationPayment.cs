using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationPayment defines a payment initiation payment
/// </summary>
public record PaymentInitiationPayment
{
    /// <summary>
    /// The ID of the payment. Like all Plaid identifiers, the <c>payment_id</c> is case sensitive.
    /// </summary>
    [JsonPropertyName("payment_id")]
    public required string PaymentId { get; init; }

    /// <summary>
    /// The amount and currency of a payment
    /// </summary>
    [JsonPropertyName("amount")]
    public required PaymentAmount Amount { get; init; }

    /// <summary>
    /// The status of the payment.
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
    [JsonPropertyName("status")]
    public required Status3 Status { get; init; }

    /// <summary>
    /// The ID of the recipient
    /// </summary>
    [JsonPropertyName("recipient_id")]
    public required string RecipientId { get; init; }

    /// <summary>
    /// A reference for the payment.
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; init; }

    /// <summary>
    /// The value of the reference sent to the bank after adjustment to pass bank validation rules.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjusted_reference")]
    public string? AdjustedReference { get; init; }

    /// <summary>
    /// The date and time of the last time the <c>status</c> was updated, in IS0 8601 format
    /// </summary>
    [JsonPropertyName("last_status_update")]
    public required DateTimeOffset LastStatusUpdate { get; init; }

    /// <summary>
    /// The schedule that the payment will be executed on. If a schedule is provided, the payment is automatically set up as a standing order. If no schedule is specified, the payment will be executed only once.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule")]
    public ExternalPaymentScheduleGet? Schedule { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund_details")]
    public ExternalPaymentRefundDetails? RefundDetails { get; init; }

    [JsonPropertyName("bacs")]
    public required SenderBacsNullable Bacs { get; init; }

    /// <summary>
    /// The International Bank Account Number (IBAN) for the sender, if specified in the <c>/payment_initiation/payment/create</c> call.
    /// </summary>
    [JsonPropertyName("iban")]
    public required string? Iban { get; init; }

    /// <summary>
    /// Initiated refunds associated with the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initiated_refunds")]
    public IReadOnlyList<PaymentInitiationRefund>? InitiatedRefunds { get; init; }

    /// <summary>
    /// The EMI (E-Money Institution) account that this payment is associated with, if any. This EMI account is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emi_account_id")]
    [MinLength(1)]
    public string? EmiAccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
