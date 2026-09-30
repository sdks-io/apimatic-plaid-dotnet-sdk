using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional set of options to be used when configuring the Item. If specified, must not be <c>null</c>.
/// </summary>
public record SandboxProcessorTokenCreateRequestOptions
{
    /// <summary>
    /// Test username to use for the creation of the Sandbox Item. Default value is <c>user_good</c>.
    /// </summary>
    [JsonPropertyName("override_username")]
    public string? OverrideUsername { get; init; } = "user_good";

    /// <summary>
    /// Test password to use for the creation of the Sandbox Item. Default value is <c>pass_good</c>.
    /// </summary>
    [JsonPropertyName("override_password")]
    public string? OverridePassword { get; init; } = "pass_good";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
