using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The verification refresh status. One of the following:
/// <para>
/// <c>"VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED"</c> User presence is required to refresh an income verification.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerificationRefreshStatus>))]
public sealed record VerificationRefreshStatus : OpenStringEnum<VerificationRefreshStatus>
{
    private VerificationRefreshStatus(string value) : base(value)
    {
    }

    public static readonly VerificationRefreshStatus VerificationRefreshStatusUserPresenceRequired = new(
        "VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED");

    public TResult Match<TResult>(Func<TResult> onVerificationRefreshStatusUserPresenceRequired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this ==
                VerificationRefreshStatusUserPresenceRequired => onVerificationRefreshStatusUserPresenceRequired(),
            _ => otherwise(Value)
        };

    public void Match(Action onVerificationRefreshStatusUserPresenceRequired, Action<string> otherwise)
    {
        if (this == VerificationRefreshStatusUserPresenceRequired) onVerificationRefreshStatusUserPresenceRequired();
        else otherwise(Value);
    }
}
