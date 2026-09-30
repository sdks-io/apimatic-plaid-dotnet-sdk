using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the Auth product. This field is currently only required if using the Flexible Auth product (currently in closed beta).
/// </summary>
public record LinkTokenCreateRequestAuth
{
    /// <summary>
    /// The optional Auth flow to use. Currently only used to enable Flexible Auth.
    /// </summary>
    [JsonPropertyName("flow_type")]
    public required string FlowType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
