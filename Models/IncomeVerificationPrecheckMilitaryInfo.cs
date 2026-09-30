using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

public record IncomeVerificationPrecheckMilitaryInfo
{
    /// <summary>
    /// Is the user currently active duty in the US military
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_active_duty")]
    public bool? IsActiveDuty { get; init; }

    /// <summary>
    /// If the user is currently serving in the US military, the branch of the military they are serving in
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("branch")]
    public Branch? Branch { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
