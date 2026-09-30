using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about the pay period.
/// </summary>
public record PayPeriodDetails
{
    /// <summary>
    /// The pay period start date, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format: "yyyy-mm-dd".
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset? StartDate { get; init; }

    /// <summary>
    /// The pay period end date, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format: "yyyy-mm-dd".
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// The date on which the paystub was issued, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ("yyyy-mm-dd").
    /// </summary>
    [JsonPropertyName("pay_day")]
    public required DateTimeOffset? PayDay { get; init; }

    /// <summary>
    /// Total earnings before tax.
    /// </summary>
    [JsonPropertyName("gross_earnings")]
    public required double? GrossEarnings { get; init; }

    /// <summary>
    /// The net amount of the paycheck.
    /// </summary>
    [JsonPropertyName("check_amount")]
    public required double? CheckAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
