using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

public record DepositSwitchTargetUser
{
    /// <summary>
    /// The given name (first name) of the user.
    /// </summary>
    [JsonPropertyName("given_name")]
    public required string GivenName { get; init; }

    /// <summary>
    /// The family name (last name) of the user.
    /// </summary>
    [JsonPropertyName("family_name")]
    public required string FamilyName { get; init; }

    /// <summary>
    /// The phone number of the user. The endpoint can accept a variety of phone number formats, including E.164.
    /// </summary>
    [JsonPropertyName("phone")]
    public required string Phone { get; init; }

    /// <summary>
    /// The email address of the user.
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    /// <summary>
    /// The user's address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public DepositSwitchAddressData? Address { get; init; }

    /// <summary>
    /// The taxpayer ID of the user, generally their SSN, EIN, or TIN.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_payer_id")]
    public string? TaxPayerId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
