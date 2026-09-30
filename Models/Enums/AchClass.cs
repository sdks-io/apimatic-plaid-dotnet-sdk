using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Specifies the use case of the transfer.  Required for transfers on an ACH network.
/// <para>
/// <c>"arc"</c> - Accounts Receivable Entry
/// </para>
/// <para>
/// <c>"cbr</c>" - Cross Border Entry
/// </para>
/// <para>
/// <c>"ccd"</c> - Corporate Credit or Debit - fund transfer between two corporate bank accounts
/// </para>
/// <para>
/// <c>"cie"</c> - Customer Initiated Entry
/// </para>
/// <para>
/// <c>"cor"</c> - Automated Notification of Change
/// </para>
/// <para>
/// <c>"ctx"</c> - Corporate Trade Exchange
/// </para>
/// <para>
/// <c>"iat"</c> - International
/// </para>
/// <para>
/// <c>"mte"</c> - Machine Transfer Entry
/// </para>
/// <para>
/// <c>"pbr"</c> - Cross Border Entry
/// </para>
/// <para>
/// <c>"pop"</c> - Point-of-Purchase Entry
/// </para>
/// <para>
/// <c>"pos"</c> - Point-of-Sale Entry
/// </para>
/// <para>
/// <c>"ppd"</c> - Prearranged Payment or Deposit - the transfer is part of a pre-existing relationship with a consumer, eg. bill payment
/// </para>
/// <para>
/// <c>"rck"</c> - Re-presented Check Entry
/// </para>
/// <para>
/// <c>"tel"</c> - Telephone-Initiated Entry
/// </para>
/// <para>
/// <c>"web"</c> - Internet-Initiated Entry - debits from a consumer’s account where their authorization is obtained over the Internet
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AchClass>))]
public sealed record AchClass : OpenStringEnum<AchClass>
{
    private AchClass(string value) : base(value)
    {
    }

    public static readonly AchClass Arc = new("arc");

    public static readonly AchClass Cbr = new("cbr");

    public static readonly AchClass Ccd = new("ccd");

    public static readonly AchClass Cie = new("cie");

    public static readonly AchClass Cor = new("cor");

    public static readonly AchClass Ctx = new("ctx");

    public static readonly AchClass Iat = new("iat");

    public static readonly AchClass Mte = new("mte");

    public static readonly AchClass Pbr = new("pbr");

    public static readonly AchClass Pop = new("pop");

    public static readonly AchClass Pos = new("pos");

    public static readonly AchClass Ppd = new("ppd");

    public static readonly AchClass Rck = new("rck");

    public static readonly AchClass Tel = new("tel");

    public static readonly AchClass Web = new("web");

    public TResult Match<TResult>(Func<TResult> onArc,
        Func<TResult> onCbr,
        Func<TResult> onCcd,
        Func<TResult> onCie,
        Func<TResult> onCor,
        Func<TResult> onCtx,
        Func<TResult> onIat,
        Func<TResult> onMte,
        Func<TResult> onPbr,
        Func<TResult> onPop,
        Func<TResult> onPos,
        Func<TResult> onPpd,
        Func<TResult> onRck,
        Func<TResult> onTel,
        Func<TResult> onWeb,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Arc => onArc(),
            _ when this == Cbr => onCbr(),
            _ when this == Ccd => onCcd(),
            _ when this == Cie => onCie(),
            _ when this == Cor => onCor(),
            _ when this == Ctx => onCtx(),
            _ when this == Iat => onIat(),
            _ when this == Mte => onMte(),
            _ when this == Pbr => onPbr(),
            _ when this == Pop => onPop(),
            _ when this == Pos => onPos(),
            _ when this == Ppd => onPpd(),
            _ when this == Rck => onRck(),
            _ when this == Tel => onTel(),
            _ when this == Web => onWeb(),
            _ => otherwise(Value)
        };

    public void Match(Action onArc,
        Action onCbr,
        Action onCcd,
        Action onCie,
        Action onCor,
        Action onCtx,
        Action onIat,
        Action onMte,
        Action onPbr,
        Action onPop,
        Action onPos,
        Action onPpd,
        Action onRck,
        Action onTel,
        Action onWeb,
        Action<string> otherwise)
    {
        if (this == Arc) onArc();
        else if (this == Cbr) onCbr();
        else if (this == Ccd) onCcd();
        else if (this == Cie) onCie();
        else if (this == Cor) onCor();
        else if (this == Ctx) onCtx();
        else if (this == Iat) onIat();
        else if (this == Mte) onMte();
        else if (this == Pbr) onPbr();
        else if (this == Pop) onPop();
        else if (this == Pos) onPos();
        else if (this == Ppd) onPpd();
        else if (this == Rck) onRck();
        else if (this == Tel) onTel();
        else if (this == Web) onWeb();
        else otherwise(Value);
    }
}
