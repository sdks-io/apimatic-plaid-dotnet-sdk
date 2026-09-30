using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Commonly used term to describe the line item.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CanonicalDescription>))]
public sealed record CanonicalDescription : OpenStringEnum<CanonicalDescription>
{
    private CanonicalDescription(string value) : base(value)
    {
    }

    public static readonly CanonicalDescription Bonus = new("BONUS");

    public static readonly CanonicalDescription Commission = new("COMMISSION");

    public static readonly CanonicalDescription Overtime = new("OVERTIME");

    public static readonly CanonicalDescription PaidTimeOff = new("PAID TIME OFF");

    public static readonly CanonicalDescription RegularPay = new("REGULAR PAY");

    public static readonly CanonicalDescription Vacation = new("VACATION");

    public static readonly CanonicalDescription EmployeeMedicare = new("EMPLOYEE MEDICARE");

    public static readonly CanonicalDescription Fica = new("FICA");

    public static readonly CanonicalDescription SocialSecurityEmployeeTax = new("SOCIAL SECURITY EMPLOYEE TAX");

    public static readonly CanonicalDescription Medical = new("MEDICAL");

    public static readonly CanonicalDescription Vision = new("VISION");

    public static readonly CanonicalDescription Dental = new("DENTAL");

    public static readonly CanonicalDescription NetPay = new("NET PAY");

    public static readonly CanonicalDescription Taxes = new("TAXES");

    public static readonly CanonicalDescription NotFound = new("NOT_FOUND");

    public static readonly CanonicalDescription Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onBonus,
        Func<TResult> onCommission,
        Func<TResult> onOvertime,
        Func<TResult> onPaidTimeOff,
        Func<TResult> onRegularPay,
        Func<TResult> onVacation,
        Func<TResult> onEmployeeMedicare,
        Func<TResult> onFica,
        Func<TResult> onSocialSecurityEmployeeTax,
        Func<TResult> onMedical,
        Func<TResult> onVision,
        Func<TResult> onDental,
        Func<TResult> onNetPay,
        Func<TResult> onTaxes,
        Func<TResult> onNotFound,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Bonus => onBonus(),
            _ when this == Commission => onCommission(),
            _ when this == Overtime => onOvertime(),
            _ when this == PaidTimeOff => onPaidTimeOff(),
            _ when this == RegularPay => onRegularPay(),
            _ when this == Vacation => onVacation(),
            _ when this == EmployeeMedicare => onEmployeeMedicare(),
            _ when this == Fica => onFica(),
            _ when this == SocialSecurityEmployeeTax => onSocialSecurityEmployeeTax(),
            _ when this == Medical => onMedical(),
            _ when this == Vision => onVision(),
            _ when this == Dental => onDental(),
            _ when this == NetPay => onNetPay(),
            _ when this == Taxes => onTaxes(),
            _ when this == NotFound => onNotFound(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onBonus,
        Action onCommission,
        Action onOvertime,
        Action onPaidTimeOff,
        Action onRegularPay,
        Action onVacation,
        Action onEmployeeMedicare,
        Action onFica,
        Action onSocialSecurityEmployeeTax,
        Action onMedical,
        Action onVision,
        Action onDental,
        Action onNetPay,
        Action onTaxes,
        Action onNotFound,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Bonus) onBonus();
        else if (this == Commission) onCommission();
        else if (this == Overtime) onOvertime();
        else if (this == PaidTimeOff) onPaidTimeOff();
        else if (this == RegularPay) onRegularPay();
        else if (this == Vacation) onVacation();
        else if (this == EmployeeMedicare) onEmployeeMedicare();
        else if (this == Fica) onFica();
        else if (this == SocialSecurityEmployeeTax) onSocialSecurityEmployeeTax();
        else if (this == Medical) onMedical();
        else if (this == Vision) onVision();
        else if (this == Dental) onDental();
        else if (this == NetPay) onNetPay();
        else if (this == Taxes) onTaxes();
        else if (this == NotFound) onNotFound();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
