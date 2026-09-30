using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata about the Item.
/// </summary>
public record Item
{
    /// <summary>
    /// The Plaid Item ID. The <c>item_id</c> is always unique; linking the same account at the same institution twice will result in two Items with different <c>item_id</c> values. Like all Plaid identifiers, the <c>item_id</c> is case-sensitive.
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    /// <summary>
    /// The Plaid Institution ID associated with the Item. Field is <c>null</c> for Items created via Same Day Micro-deposits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_id")]
    public string? InstitutionId { get; init; }

    /// <summary>
    /// The URL registered to receive webhooks for the Item.
    /// </summary>
    [JsonPropertyName("webhook")]
    public required string? Webhook { get; init; }

    /// <summary>
    /// We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues.  Error fields will be <c>null</c> if no error has occurred.
    /// </summary>
    [JsonPropertyName("error")]
    public required Error Error { get; init; }

    /// <summary>
    /// A list of products available for the Item that have not yet been accessed.
    /// </summary>
    [JsonPropertyName("available_products")]
    public required IReadOnlyList<Products> AvailableProducts { get; init; }

    /// <summary>
    /// A list of products that have been billed for the Item. Note - <c>billed_products</c> is populated in all environments but only requests in Production are billed.
    /// </summary>
    [JsonPropertyName("billed_products")]
    public required IReadOnlyList<Products> BilledProducts { get; init; }

    /// <summary>
    /// The RFC 3339 timestamp after which the consent provided by the end user will expire. Upon consent expiration, the item will enter the <c>ITEM_LOGIN_REQUIRED</c> error state. To circumvent the <c>ITEM_LOGIN_REQUIRED</c> error and maintain continuous consent, the end user can reauthenticate via Link’s update mode in advance of the consent expiration time.
    /// <para>
    /// Note - This is only relevant for certain OAuth-based institutions. For all other institutions, this field will be null.
    /// </para>
    /// </summary>
    [JsonPropertyName("consent_expiration_time")]
    public required DateTimeOffset? ConsentExpirationTime { get; init; }

    /// <summary>
    /// Indicates whether an Item requires user interaction to be updated, which can be the case for Items with some forms of two-factor authentication.
    /// <para>
    /// <c>background</c> - Item can be updated in the background
    /// </para>
    /// <para>
    /// <c>user_present_required</c> - Item requires user interaction to be updated
    /// </para>
    /// </summary>
    [JsonPropertyName("update_type")]
    public required UpdateType UpdateType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
