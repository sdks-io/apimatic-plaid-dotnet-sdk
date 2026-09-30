using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

public record Taxform
{
    /// <summary>
    /// The type of tax document.
    /// </summary>
    [JsonPropertyName("document_type")]
    public required string DocumentType { get; init; }

    /// <summary>
    /// W2 is an object that represents income data taken from a W2 tax document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("w2")]
    public W2? W2 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
