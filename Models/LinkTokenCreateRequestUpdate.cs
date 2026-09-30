using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for <see href="https://plaid.com/docs/link/update-mode">update mode</see>.
/// </summary>
public record LinkTokenCreateRequestUpdate
{
    /// <summary>
    /// If <c>true</c>, enables <see href="https://plaid.com/docs/link/update-mode/#using-update-mode-to-request-new-accounts">update mode with Account Select</see>.
    /// </summary>
    [JsonPropertyName("account_selection_enabled")]
    public bool? AccountSelectionEnabled { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
