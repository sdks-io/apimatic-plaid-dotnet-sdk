using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// TransferAuthorization contains the authorization decision for a proposed transfer
/// </summary>
public record TransferAuthorization
{
    /// <summary>
    /// Plaid’s unique identifier for a transfer authorization.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The datetime representing when the authorization was created, in the format "2006-01-02T15:04:05Z".
    /// </summary>
    [JsonPropertyName("created")]
    public required string Created { get; init; }

    /// <summary>
    /// A decision regarding the proposed transfer.
    /// <para>
    /// <c>approved</c> – The proposed transfer has received the end user's consent and has been approved for processing. Plaid has also reviewed the proposed transfer and has approved it for processing.
    /// </para>
    /// <para>
    /// <c>permitted</c> – Plaid was unable to fetch the information required to approve or decline the proposed transfer. You may proceed with the transfer, but further review is recommended. Plaid is awaiting further instructions from the client.
    /// </para>
    /// <para>
    /// <c>declined</c> – Plaid reviewed the proposed transfer and declined processing. Refer to the <c>code</c> field in the <c>decision_rationale</c> object for details.
    /// </para>
    /// </summary>
    [JsonPropertyName("decision")]
    public required Decision Decision { get; init; }

    /// <summary>
    /// The rationale for Plaid's decision regarding a proposed transfer. Will be null for <c>approved</c> decisions.
    /// </summary>
    [JsonPropertyName("decision_rationale")]
    public required TransferAuthorizationDecisionRationale DecisionRationale { get; init; }

    /// <summary>
    /// Details regarding the proposed transfer.
    /// </summary>
    [JsonPropertyName("proposed_transfer")]
    public required TransferAuthorizationProposedTransfer ProposedTransfer { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
