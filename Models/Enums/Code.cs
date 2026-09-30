using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A code representing the rationale for permitting or declining the proposed transfer. Possible values are:
/// <para>
/// <c>NSF</c> – Transaction likely to result in a return due to insufficient funds.
/// </para>
/// <para>
/// <c>RISK</c> - Transaction is high-risk.
/// </para>
/// <para>
/// <c>MANUALLY_VERIFIED_ITEM</c> – Item created via same-day micro deposits, limited information available. Plaid can only offer <c>permitted</c> as a transaction decision.
/// </para>
/// <para>
/// <c>LOGIN_REQUIRED</c> – Unable to collect the account information required for an authorization decision due to Item staleness. Can be rectified using Link update mode.
/// </para>
/// <para>
/// <c>ERROR</c> – Unable to collect the account information required for an authorization decision due to an error.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Code>))]
public sealed record Code : OpenStringEnum<Code>
{
    private Code(string value) : base(value)
    {
    }

    public static readonly Code Nsf = new("NSF");

    public static readonly Code Risk = new("RISK");

    public static readonly Code ManuallyVerifiedItem = new("MANUALLY_VERIFIED_ITEM");

    public static readonly Code LoginRequired = new("LOGIN_REQUIRED");

    public static readonly Code Error = new("ERROR");

    public TResult Match<TResult>(Func<TResult> onNsf,
        Func<TResult> onRisk,
        Func<TResult> onManuallyVerifiedItem,
        Func<TResult> onLoginRequired,
        Func<TResult> onError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Nsf => onNsf(),
            _ when this == Risk => onRisk(),
            _ when this == ManuallyVerifiedItem => onManuallyVerifiedItem(),
            _ when this == LoginRequired => onLoginRequired(),
            _ when this == Error => onError(),
            _ => otherwise(Value)
        };

    public void Match(Action onNsf,
        Action onRisk,
        Action onManuallyVerifiedItem,
        Action onLoginRequired,
        Action onError,
        Action<string> otherwise)
    {
        if (this == Nsf) onNsf();
        else if (this == Risk) onRisk();
        else if (this == ManuallyVerifiedItem) onManuallyVerifiedItem();
        else if (this == LoginRequired) onLoginRequired();
        else if (this == Error) onError();
        else otherwise(Value);
    }
}
