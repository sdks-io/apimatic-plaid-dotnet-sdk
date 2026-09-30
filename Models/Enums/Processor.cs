using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The processor you are integrating with.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Processor>))]
public sealed record Processor : OpenStringEnum<Processor>
{
    private Processor(string value) : base(value)
    {
    }

    public static readonly Processor Achq = new("achq");

    public static readonly Processor Alpaca = new("alpaca");

    public static readonly Processor Astra = new("astra");

    public static readonly Processor Check = new("check");

    public static readonly Processor Checkbook = new("checkbook");

    public static readonly Processor Circle = new("circle");

    public static readonly Processor Drivewealth = new("drivewealth");

    public static readonly Processor Dwolla = new("dwolla");

    public static readonly Processor Galileo = new("galileo");

    public static readonly Processor Lithic = new("lithic");

    public static readonly Processor ModernTreasury = new("modern_treasury");

    public static readonly Processor Moov = new("moov");

    public static readonly Processor Ocrolus = new("ocrolus");

    public static readonly Processor PrimeTrust = new("prime_trust");

    public static readonly Processor Rize = new("rize");

    public static readonly Processor SilaMoney = new("sila_money");

    public static readonly Processor SvbApi = new("svb_api");

    public static readonly Processor TreasuryPrime = new("treasury_prime");

    public static readonly Processor Unit = new("unit");

    public static readonly Processor Vesta = new("vesta");

    public static readonly Processor Vopay = new("vopay");

    public static readonly Processor Wyre = new("wyre");

    public TResult Match<TResult>(Func<TResult> onAchq,
        Func<TResult> onAlpaca,
        Func<TResult> onAstra,
        Func<TResult> onCheck,
        Func<TResult> onCheckbook,
        Func<TResult> onCircle,
        Func<TResult> onDrivewealth,
        Func<TResult> onDwolla,
        Func<TResult> onGalileo,
        Func<TResult> onLithic,
        Func<TResult> onModernTreasury,
        Func<TResult> onMoov,
        Func<TResult> onOcrolus,
        Func<TResult> onPrimeTrust,
        Func<TResult> onRize,
        Func<TResult> onSilaMoney,
        Func<TResult> onSvbApi,
        Func<TResult> onTreasuryPrime,
        Func<TResult> onUnit,
        Func<TResult> onVesta,
        Func<TResult> onVopay,
        Func<TResult> onWyre,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Achq => onAchq(),
            _ when this == Alpaca => onAlpaca(),
            _ when this == Astra => onAstra(),
            _ when this == Check => onCheck(),
            _ when this == Checkbook => onCheckbook(),
            _ when this == Circle => onCircle(),
            _ when this == Drivewealth => onDrivewealth(),
            _ when this == Dwolla => onDwolla(),
            _ when this == Galileo => onGalileo(),
            _ when this == Lithic => onLithic(),
            _ when this == ModernTreasury => onModernTreasury(),
            _ when this == Moov => onMoov(),
            _ when this == Ocrolus => onOcrolus(),
            _ when this == PrimeTrust => onPrimeTrust(),
            _ when this == Rize => onRize(),
            _ when this == SilaMoney => onSilaMoney(),
            _ when this == SvbApi => onSvbApi(),
            _ when this == TreasuryPrime => onTreasuryPrime(),
            _ when this == Unit => onUnit(),
            _ when this == Vesta => onVesta(),
            _ when this == Vopay => onVopay(),
            _ when this == Wyre => onWyre(),
            _ => otherwise(Value)
        };

    public void Match(Action onAchq,
        Action onAlpaca,
        Action onAstra,
        Action onCheck,
        Action onCheckbook,
        Action onCircle,
        Action onDrivewealth,
        Action onDwolla,
        Action onGalileo,
        Action onLithic,
        Action onModernTreasury,
        Action onMoov,
        Action onOcrolus,
        Action onPrimeTrust,
        Action onRize,
        Action onSilaMoney,
        Action onSvbApi,
        Action onTreasuryPrime,
        Action onUnit,
        Action onVesta,
        Action onVopay,
        Action onWyre,
        Action<string> otherwise)
    {
        if (this == Achq) onAchq();
        else if (this == Alpaca) onAlpaca();
        else if (this == Astra) onAstra();
        else if (this == Check) onCheck();
        else if (this == Checkbook) onCheckbook();
        else if (this == Circle) onCircle();
        else if (this == Drivewealth) onDrivewealth();
        else if (this == Dwolla) onDwolla();
        else if (this == Galileo) onGalileo();
        else if (this == Lithic) onLithic();
        else if (this == ModernTreasury) onModernTreasury();
        else if (this == Moov) onMoov();
        else if (this == Ocrolus) onOcrolus();
        else if (this == PrimeTrust) onPrimeTrust();
        else if (this == Rize) onRize();
        else if (this == SilaMoney) onSilaMoney();
        else if (this == SvbApi) onSvbApi();
        else if (this == TreasuryPrime) onTreasuryPrime();
        else if (this == Unit) onUnit();
        else if (this == Vesta) onVesta();
        else if (this == Vopay) onVopay();
        else if (this == Wyre) onWyre();
        else otherwise(Value);
    }
}
