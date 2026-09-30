using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to filter <c>/institutions/get</c> results.
/// </summary>
public record InstitutionsGetRequestOptions
{
    /// <summary>
    /// Filter the Institutions based on which products they support.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("products")]
    public IReadOnlyList<Products>? Products { get; init; }

    /// <summary>
    /// Specify an array of routing numbers to filter institutions. The response will only return institutions that match all of the routing numbers in the array.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routing_numbers")]
    public IReadOnlyList<string>? RoutingNumbers { get; init; }

    /// <summary>
    /// Limit results to institutions with or without OAuth login flows. This is primarily relevant to institutions with European country codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oauth")]
    public bool? Oauth { get; init; }

    /// <summary>
    /// When <c>true</c>, return the institution's homepage URL, logo and primary brand color.
    /// <para>
    /// Note that Plaid does not own any of the logos shared by the API, and that by accessing or using these logos, you agree that you are doing so at your own risk and will, if necessary, obtain all required permissions from the appropriate rights holders and adhere to any applicable usage guidelines. Plaid disclaims all express or implied warranties with respect to the logos.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_optional_metadata")]
    public bool? IncludeOptionalMetadata { get; init; }

    /// <summary>
    /// When <c>true</c>, returns metadata related to the Auth product indicating which auth methods are supported.
    /// </summary>
    [JsonPropertyName("include_auth_metadata")]
    public bool? IncludeAuthMetadata { get; init; } = false;

    /// <summary>
    /// When <c>true</c>, returns metadata related to the Payment Initiation product indicating which payment configurations are supported.
    /// </summary>
    [JsonPropertyName("include_payment_initiation_metadata")]
    public bool? IncludePaymentInitiationMetadata { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
