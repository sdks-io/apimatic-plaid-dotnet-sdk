using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An identifier classifying the transaction type.
/// <para>
/// This field is only populated for European institutions. For institutions in the US and Canada, this field is set to <c>null</c>.
/// </para>
/// <para>
/// <c>adjustment:</c> Bank adjustment
/// </para>
/// <para>
/// <c>atm:</c> Cash deposit or withdrawal via an automated teller machine
/// </para>
/// <para>
/// <c>bank charge:</c> Charge or fee levied by the institution
/// </para>
/// <para>
/// <c>bill payment</c>: Payment of a bill
/// </para>
/// <para>
/// <c>cash:</c> Cash deposit or withdrawal
/// </para>
/// <para>
/// <c>cashback:</c> Cash withdrawal while making a debit card purchase
/// </para>
/// <para>
/// <c>cheque:</c> Document ordering the payment of money to another person or organization
/// </para>
/// <para>
/// <c>direct debit:</c> Automatic withdrawal of funds initiated by a third party at a regular interval
/// </para>
/// <para>
/// <c>interest:</c> Interest earned or incurred
/// </para>
/// <para>
/// <c>purchase:</c> Purchase made with a debit or credit card
/// </para>
/// <para>
/// <c>standing order:</c> Payment instructed by the account holder to a third party at a regular interval
/// </para>
/// <para>
/// <c>transfer:</c> Transfer of money between accounts
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionCode>))]
public sealed record TransactionCode : OpenStringEnum<TransactionCode>
{
    private TransactionCode(string value) : base(value)
    {
    }

    public static readonly TransactionCode Adjustment = new("adjustment");

    public static readonly TransactionCode Atm = new("atm");

    public static readonly TransactionCode BankCharge = new("bank charge");

    public static readonly TransactionCode BillPayment = new("bill payment");

    public static readonly TransactionCode Cash = new("cash");

    public static readonly TransactionCode Cashback = new("cashback");

    public static readonly TransactionCode Cheque = new("cheque");

    public static readonly TransactionCode DirectDebit = new("direct debit");

    public static readonly TransactionCode Interest = new("interest");

    public static readonly TransactionCode Purchase = new("purchase");

    public static readonly TransactionCode StandingOrder = new("standing order");

    public static readonly TransactionCode Transfer = new("transfer");

    public TResult Match<TResult>(Func<TResult> onAdjustment,
        Func<TResult> onAtm,
        Func<TResult> onBankCharge,
        Func<TResult> onBillPayment,
        Func<TResult> onCash,
        Func<TResult> onCashback,
        Func<TResult> onCheque,
        Func<TResult> onDirectDebit,
        Func<TResult> onInterest,
        Func<TResult> onPurchase,
        Func<TResult> onStandingOrder,
        Func<TResult> onTransfer,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Adjustment => onAdjustment(),
            _ when this == Atm => onAtm(),
            _ when this == BankCharge => onBankCharge(),
            _ when this == BillPayment => onBillPayment(),
            _ when this == Cash => onCash(),
            _ when this == Cashback => onCashback(),
            _ when this == Cheque => onCheque(),
            _ when this == DirectDebit => onDirectDebit(),
            _ when this == Interest => onInterest(),
            _ when this == Purchase => onPurchase(),
            _ when this == StandingOrder => onStandingOrder(),
            _ when this == Transfer => onTransfer(),
            _ => otherwise(Value)
        };

    public void Match(Action onAdjustment,
        Action onAtm,
        Action onBankCharge,
        Action onBillPayment,
        Action onCash,
        Action onCashback,
        Action onCheque,
        Action onDirectDebit,
        Action onInterest,
        Action onPurchase,
        Action onStandingOrder,
        Action onTransfer,
        Action<string> otherwise)
    {
        if (this == Adjustment) onAdjustment();
        else if (this == Atm) onAtm();
        else if (this == BankCharge) onBankCharge();
        else if (this == BillPayment) onBillPayment();
        else if (this == Cash) onCash();
        else if (this == Cashback) onCashback();
        else if (this == Cheque) onCheque();
        else if (this == DirectDebit) onDirectDebit();
        else if (this == Interest) onInterest();
        else if (this == Purchase) onPurchase();
        else if (this == StandingOrder) onStandingOrder();
        else if (this == Transfer) onTransfer();
        else otherwise(Value);
    }
}
