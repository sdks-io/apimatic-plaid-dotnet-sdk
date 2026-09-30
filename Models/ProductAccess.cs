using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The product access being requested. Used to or disallow product access across all accounts. If unset, defaults to all products allowed.
/// </summary>
public record ProductAccess
{
    /// <summary>
    /// Allow access to statements. If unset, defaults to <c>true</c>.
    /// </summary>
    [JsonPropertyName("statements")]
    public bool? Statements { get; init; } = true;

    /// <summary>
    /// Allow access to the Identity product (name, email, phone, address). If unset, defaults to <c>true</c>.
    /// </summary>
    [JsonPropertyName("identity")]
    public bool? Identity { get; init; } = true;

    /// <summary>
    /// Allow access to account number details. If unset, defaults to <c>true</c>.
    /// </summary>
    [JsonPropertyName("auth")]
    public bool? Auth { get; init; } = true;

    /// <summary>
    /// Allow access to transaction details. If unset, defaults to <c>true</c>.
    /// </summary>
    [JsonPropertyName("transactions")]
    public bool? Transactions { get; init; } = true;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
