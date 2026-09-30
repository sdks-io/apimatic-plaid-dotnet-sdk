using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object specifying information about the end user who will be linking their account.
/// </summary>
public record LinkTokenCreateRequestUser
{
    /// <summary>
    /// A unique ID representing the end user. Typically this will be a user ID number from your application. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>. It is currently used as a means of searching logs for the given user in the Plaid Dashboard.
    /// </summary>
    [JsonPropertyName("client_user_id")]
    public required string ClientUserId { get; init; }

    /// <summary>
    /// The user's full legal name. This is an optional field used in the <see href="https://plaid.com/docs/link/returning-user">returning user experience</see> to associate Items to the user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legal_name")]
    public string? LegalName { get; init; }

    /// <summary>
    /// The user's phone number in <see href="https://en.wikipedia.org/wiki/E.164">E.164</see> format. This field is optional, but required to enable the <see href="https://plaid.com/docs/link/returning-user">returning user experience</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// The date and time the phone number was verified in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (<c>YYYY-MM-DDThh:mm:ssZ</c>). This field is optional, but required to enable any <see href="https://plaid.com/docs/link/returning-user">returning user experience</see>.
    /// <para>
    ///  Only pass a verification time for a phone number that you have verified. If you have performed verification but don’t have the time, you may supply a signal value of the start of the UNIX epoch.
    /// </para>
    /// <para>
    ///  Example: <c>2020-01-01T00:00:00Z</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number_verified_time")]
    public DateTimeOffset? PhoneNumberVerifiedTime { get; init; }

    /// <summary>
    /// The user's email address. This field is optional, but required to enable the <see href="https://plaid.com/docs/link/returning-user/#enabling-the-returning-user-experience">pre-authenticated returning user flow</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The date and time the email address was verified in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (<c>YYYY-MM-DDThh:mm:ssZ</c>). This is an optional field used in the <see href="https://plaid.com/docs/link/returning-user">returning user experience</see>.
    /// <para>
    ///  Only pass a verification time for an email address that you have verified. If you have performed verification but don’t have the time, you may supply a signal value of the start of the UNIX epoch.
    /// </para>
    /// <para>
    ///  Example: <c>2020-01-01T00:00:00Z</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address_verified_time")]
    public DateTimeOffset? EmailAddressVerifiedTime { get; init; }

    /// <summary>
    /// To be provided in the format "ddd-dd-dddd". This field is optional and will support not-yet-implemented functionality for new products.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ssn")]
    public string? Ssn { get; init; }

    /// <summary>
    /// To be provided in the format "yyyy-mm-dd". This field is optional and will support not-yet-implemented functionality for new products.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date_of_birth")]
    public DateTimeOffset? DateOfBirth { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
