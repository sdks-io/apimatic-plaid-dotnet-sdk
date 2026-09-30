using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// IncomeVerificationDocumentsDownloadResponse defines the response schema for <c>/income/verification/documents/download</c>.
/// </summary>
public record IncomeVerificationDocumentsDownloadResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
