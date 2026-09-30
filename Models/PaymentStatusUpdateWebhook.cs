using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when the status of a payment has changed.
/// </summary>
public record PaymentStatusUpdateWebhook
{
    /// <summary>
    /// <c>PAYMENT_INITIATION</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>PAYMENT_STATUS_UPDATE</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// The <c>payment_id</c> for the payment being updated
    /// </summary>
    [JsonPropertyName("payment_id")]
    public required string PaymentId { get; init; }

    /// <summary>
    /// The new status of the payment.
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
    [JsonPropertyName("new_payment_status")]
    public required NewPaymentStatus NewPaymentStatus { get; init; }

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
    [JsonPropertyName("old_payment_status")]
    public required OldPaymentStatus OldPaymentStatus { get; init; }

    /// <summary>
    /// The original value of the reference when creating the payment.
    /// </summary>
    [JsonPropertyName("original_reference")]
    public required string? OriginalReference { get; init; }

    /// <summary>
    /// The value of the reference sent to the bank after adjustment to pass bank validation rules.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjusted_reference")]
    public string? AdjustedReference { get; init; }

    /// <summary>
    /// The original value of the <c>start_date</c> provided during the creation of a standing order. If the payment is not a standing order, this field will be <c>null</c>.
    /// </summary>
    [JsonPropertyName("original_start_date")]
    public required DateTimeOffset? OriginalStartDate { get; init; }

    /// <summary>
    /// The start date sent to the bank after adjusting for holidays or weekends.  Will be provided in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD). If the start date did not require adjustment, or if the payment is not a standing order, this field will be <c>null</c>.
    /// </summary>
    [JsonPropertyName("adjusted_start_date")]
    public required DateTimeOffset? AdjustedStartDate { get; init; }

    /// <summary>
    /// The timestamp of the update, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format, e.g. <c>"2017-09-14T14:42:19.350Z"</c>
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    /// <summary>
    /// We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues.  Error fields will be <c>null</c> if no error has occurred.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public Error? Error { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
