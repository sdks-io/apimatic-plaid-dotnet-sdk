using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A representation of the status health of a request type. Auth requests, Balance requests, Identity requests, Investments requests, Liabilities requests, Transactions updates, Investments updates, Liabilities updates, and Item logins each have their own status object.
/// </summary>
public record ProductStatus
{
    /// <summary>
    /// <c>HEALTHY</c>: the majority of requests are successful
    /// <c>DEGRADED</c>: only some requests are successful
    /// <c>DOWN</c>: all requests are failing
    /// </summary>
    [JsonPropertyName("status")]
    public required Status Status { get; init; }

    /// <summary>
    /// <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> formatted timestamp of the last status change for the institution.
    /// </summary>
    [JsonPropertyName("last_status_change")]
    public required DateTimeOffset LastStatusChange { get; init; }

    /// <summary>
    /// A detailed breakdown of the institution's performance for a request type. The values for <c>success</c>, <c>error_plaid</c>, and <c>error_institution</c> sum to 1.
    /// </summary>
    [JsonPropertyName("breakdown")]
    public required StatusBreakdown Breakdown { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
