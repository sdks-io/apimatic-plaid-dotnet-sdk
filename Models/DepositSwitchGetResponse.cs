using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// DepositSwitchGetResponse defines the response schema for <c>/deposit_switch/get</c>
/// </summary>
public record DepositSwitchGetResponse
{
    /// <summary>
    /// The ID of the deposit switch.
    /// </summary>
    [JsonPropertyName("deposit_switch_id")]
    public required string DepositSwitchId { get; init; }

    /// <summary>
    /// The ID of the bank account the direct deposit was switched to.
    /// </summary>
    [JsonPropertyName("target_account_id")]
    public required string? TargetAccountId { get; init; }

    /// <summary>
    /// The ID of the Item the direct deposit was switched to.
    /// </summary>
    [JsonPropertyName("target_item_id")]
    public required string? TargetItemId { get; init; }

    /// <summary>
    /// The state, or status, of the deposit switch.
    /// <list type="bullet">
    ///   <item><description><c>initialized</c> – The deposit switch has been initialized with the user entering the information required to submit the deposit switch request.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>processing</c> – The deposit switch request has been submitted and is being processed.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>completed</c> – The user's employer has fulfilled the deposit switch request.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>error</c> – There was an error processing the deposit switch request.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("state")]
    public required State State { get; init; }

    /// <summary>
    /// The method used to make the deposit switch.
    /// <list type="bullet">
    ///   <item><description><c>instant</c> – User instantly switched their direct deposit to a new or existing bank account by connecting their payroll or employer account.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>mail</c> – User requested that Plaid contact their employer by mail to make the direct deposit switch.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>pdf</c> – User generated a PDF or email to be sent to their employer with the information necessary to make the deposit switch.'</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("switch_method")]
    public SwitchMethod? SwitchMethod { get; init; }

    /// <summary>
    /// When <c>true</c>, user’s direct deposit goes to multiple banks. When false, user’s direct deposit only goes to the target account. Always <c>null</c> if the deposit switch has not been completed.
    /// </summary>
    [JsonPropertyName("account_has_multiple_allocations")]
    public required bool? AccountHasMultipleAllocations { get; init; }

    /// <summary>
    /// When <c>true</c>, the target account is allocated the remainder of direct deposit after all other allocations have been deducted. When <c>false</c>, user’s direct deposit is allocated as a percent or amount. Always <c>null</c> if the deposit switch has not been completed.
    /// </summary>
    [JsonPropertyName("is_allocated_remainder")]
    public required bool? IsAllocatedRemainder { get; init; }

    /// <summary>
    /// The percentage of direct deposit allocated to the target account. Always <c>null</c> if the target account is not allocated a percentage or if the deposit switch has not been completed or if <c>is_allocated_remainder</c> is true.
    /// </summary>
    [JsonPropertyName("percent_allocated")]
    public required double? PercentAllocated { get; init; }

    /// <summary>
    /// The dollar amount of direct deposit allocated to the target account. Always <c>null</c> if the target account is not allocated an amount or if the deposit switch has not been completed.
    /// </summary>
    [JsonPropertyName("amount_allocated")]
    public required double? AmountAllocated { get; init; }

    /// <summary>
    /// The name of the employer selected by the user. If the user did not select an employer, the value returned is <c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employer_name")]
    public string? EmployerName { get; init; }

    /// <summary>
    /// The ID of the employer selected by the user. If the user did not select an employer, the value returned is <c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employer_id")]
    public string? EmployerId { get; init; }

    /// <summary>
    /// The name of the institution selected by the user. If the user did not select an institution, the value returned is <c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_name")]
    public string? InstitutionName { get; init; }

    /// <summary>
    /// The ID of the institution selected by the user. If the user did not select an institution, the value returned is <c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_id")]
    public string? InstitutionId { get; init; }

    /// <summary>
    /// <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> date the deposit switch was created.
    /// </summary>
    [JsonPropertyName("date_created")]
    public required DateTimeOffset DateCreated { get; init; }

    /// <summary>
    /// <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> date the deposit switch was completed. Always <c>null</c> if the deposit switch has not been completed.
    /// </summary>
    [JsonPropertyName("date_completed")]
    public required DateTimeOffset? DateCompleted { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
