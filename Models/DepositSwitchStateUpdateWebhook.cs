using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when the status of a deposit switch request has changed.
/// </summary>
public record DepositSwitchStateUpdateWebhook
{
    /// <summary>
    /// <c>"DEPOSIT_SWITCH"</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook_type")]
    public string? WebhookType { get; init; }

    /// <summary>
    /// <c>"SWITCH_STATE_UPDATE"</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook_code")]
    public string? WebhookCode { get; init; }

    /// <summary>
    /// The state, or status, of the deposit switch.
    /// <para>
    /// <c>initialized</c>: The deposit switch has been initialized with the user entering the information required to submit the deposit switch request.
    /// </para>
    /// <para>
    /// <c>processing</c>: The deposit switch request has been submitted and is being processed.
    /// </para>
    /// <para>
    /// <c>completed</c>: The user's employer has fulfilled and completed the deposit switch request.
    /// </para>
    /// <para>
    /// <c>error</c>: There was an error processing the deposit switch request.
    /// </para>
    /// <para>
    /// For more information, see the <see href="/docs/api/products#deposit_switchget">Deposit Switch API reference</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }

    /// <summary>
    /// The ID of the deposit switch.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deposit_switch_id")]
    public string? DepositSwitchId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
