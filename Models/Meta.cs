using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Allows specifying the metadata of the test account
/// </summary>
public record Meta
{
    /// <summary>
    /// The account's name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The account's official name
    /// </summary>
    [JsonPropertyName("official_name")]
    public required string OfficialName { get; init; }

    /// <summary>
    /// The account's limit
    /// </summary>
    [JsonPropertyName("limit")]
    public required double Limit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
