using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to filter <c>/accounts/balance/get</c> results.
/// </summary>
public record AccountsBalanceGetRequestOptions
{
    /// <summary>
    /// A list of <c>account_ids</c> to retrieve for the Item. The default value is <c>null</c>.
    /// <para>
    /// Note: An error will be returned if a provided <c>account_id</c> is not associated with the Item.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_ids")]
    public IReadOnlyList<string>? AccountIds { get; init; }

    /// <summary>
    /// Timestamp in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the oldest acceptable balance when making a request to <c>/accounts/balance/get</c>.
    /// <para>
    /// If the balance that is pulled for <c>ins_128026</c> (Capital One) is older than the given timestamp, an <c>INVALID_REQUEST</c> error with the code of <c>LAST_UPDATED_DATETIME_OUT_OF_RANGE</c> will be returned with the most recent timestamp for the requested account contained in the response.
    /// </para>
    /// <para>
    /// This field is only used when the institution is <c>ins_128026</c> (Capital One), in which case a value must be provided or an <c>INVALID_REQUEST</c> error with the code of <c>INVALID_FIELD</c> will be returned. For all other institutions, this field is ignored.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_last_updated_datetime")]
    public DateTimeOffset? MinLastUpdatedDatetime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
