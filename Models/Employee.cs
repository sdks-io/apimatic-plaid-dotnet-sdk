using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Data about the employee.
/// </summary>
public record Employee
{
    /// <summary>
    /// The name of the employee.
    /// </summary>
    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    [JsonPropertyName("address")]
    public required Address2 Address { get; init; }

    /// <summary>
    /// Marital status of the employee.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("marital_status")]
    public string? MaritalStatus { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxpayer_id")]
    public TaxpayerId? TaxpayerId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
