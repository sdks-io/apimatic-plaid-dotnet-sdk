using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specify payroll data on the account.
/// </summary>
public record IncomeOverride
{
    /// <summary>
    /// A list of paystubs associated with the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paystubs")]
    public IReadOnlyList<PaystubOverride>? Paystubs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
