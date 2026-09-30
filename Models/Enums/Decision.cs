using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Decision>))]
public sealed record Decision : OpenStringEnum<Decision>
{
    private Decision(string value) : base(value)
    {
    }

    public static readonly Decision Approved = new("approved");

    public static readonly Decision Permitted = new("permitted");

    public static readonly Decision Declined = new("declined");

    public TResult Match<TResult>(Func<TResult> onApproved,
        Func<TResult> onPermitted,
        Func<TResult> onDeclined,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Approved => onApproved(),
            _ when this == Permitted => onPermitted(),
            _ when this == Declined => onDeclined(),
            _ => otherwise(Value)
        };

    public void Match(Action onApproved, Action onPermitted, Action onDeclined, Action<string> otherwise)
    {
        if (this == Approved) onApproved();
        else if (this == Permitted) onPermitted();
        else if (this == Declined) onDeclined();
        else otherwise(Value);
    }
}
