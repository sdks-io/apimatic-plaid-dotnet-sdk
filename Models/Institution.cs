using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Details relating to a specific financial institution
/// </summary>
public record Institution
{
    /// <summary>
    /// Unique identifier for the institution
    /// </summary>
    [JsonPropertyName("institution_id")]
    public required string InstitutionId { get; init; }

    /// <summary>
    /// The official name of the institution
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// A list of the Plaid products supported by the institution. Note that only institutions that support Instant Auth will return <c>auth</c> in the product array; institutions that do not list <c>auth</c> may still support other Auth methods such as Instant Match or Automated Micro-deposit Verification. For more details, see <see href="https://plaid.com/docs/auth/coverage/">Full Auth coverage</see>.
    /// </summary>
    [JsonPropertyName("products")]
    public required IReadOnlyList<Products> Products { get; init; }

    /// <summary>
    /// A list of the country codes supported by the institution.
    /// </summary>
    [JsonPropertyName("country_codes")]
    public required IReadOnlyList<CountryCode> CountryCodes { get; init; }

    /// <summary>
    /// The URL for the institution's website
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }

    /// <summary>
    /// Hexadecimal representation of the primary color used by the institution
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary_color")]
    public string? PrimaryColor { get; init; }

    /// <summary>
    /// Base64 encoded representation of the institution's logo
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo")]
    public string? Logo { get; init; }

    /// <summary>
    /// A partial list of routing numbers associated with the institution. This list is provided for the purpose of looking up institutions by routing number. It is not comprehensive and should never be used as a complete list of routing numbers for an institution.
    /// </summary>
    [JsonPropertyName("routing_numbers")]
    public required IReadOnlyList<string?> RoutingNumbers { get; init; }

    /// <summary>
    /// Indicates that the institution has an OAuth login flow. This is primarily relevant to institutions with European country codes.
    /// </summary>
    [JsonPropertyName("oauth")]
    public required bool Oauth { get; init; }

    /// <summary>
    /// The status of an institution is determined by the health of its Item logins, Transactions updates, Investments updates, Liabilities updates, Auth requests, Balance requests, Identity requests, Investments requests, and Liabilities requests. A login attempt is conducted during the initial Item add in Link. If there is not enough traffic to accurately calculate an institution's status, Plaid will return null rather than potentially inaccurate data.
    /// <para>
    /// Institution status is accessible in the Dashboard and via the API using the <c>/institutions/get_by_id</c> endpoint with the <c>include_status</c> option set to true. Note that institution status is not available in the Sandbox environment.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public InstitutionStatus? Status { get; init; }

    /// <summary>
    /// Metadata that captures what specific payment configurations an institution supports when making Payment Initiation requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_initiation_metadata")]
    public PaymentInitiationMetadata? PaymentInitiationMetadata { get; init; }

    /// <summary>
    /// Metadata that captures information about the Auth features of an institution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auth_metadata")]
    public AuthMetadata? AuthMetadata { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
