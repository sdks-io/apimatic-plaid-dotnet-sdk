using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A list of products that an institution can support. All Items must be initialized with at least one product. The Balance product is always available and does not need to be specified during initialization.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Products>))]
public sealed record Products : OpenStringEnum<Products>
{
    private Products(string value) : base(value)
    {
    }

    public static readonly Products Assets = new("assets");

    public static readonly Products Auth = new("auth");

    public static readonly Products Balance = new("balance");

    public static readonly Products Identity = new("identity");

    public static readonly Products Investments = new("investments");

    public static readonly Products Liabilities = new("liabilities");

    public static readonly Products PaymentInitiation = new("payment_initiation");

    public static readonly Products Transactions = new("transactions");

    public static readonly Products CreditDetails = new("credit_details");

    public static readonly Products Income = new("income");

    public static readonly Products IncomeVerification = new("income_verification");

    public static readonly Products DepositSwitch = new("deposit_switch");

    public static readonly Products StandingOrders = new("standing_orders");

    public static readonly Products Transfer = new("transfer");

    public TResult Match<TResult>(Func<TResult> onAssets,
        Func<TResult> onAuth,
        Func<TResult> onBalance,
        Func<TResult> onIdentity,
        Func<TResult> onInvestments,
        Func<TResult> onLiabilities,
        Func<TResult> onPaymentInitiation,
        Func<TResult> onTransactions,
        Func<TResult> onCreditDetails,
        Func<TResult> onIncome,
        Func<TResult> onIncomeVerification,
        Func<TResult> onDepositSwitch,
        Func<TResult> onStandingOrders,
        Func<TResult> onTransfer,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Assets => onAssets(),
            _ when this == Auth => onAuth(),
            _ when this == Balance => onBalance(),
            _ when this == Identity => onIdentity(),
            _ when this == Investments => onInvestments(),
            _ when this == Liabilities => onLiabilities(),
            _ when this == PaymentInitiation => onPaymentInitiation(),
            _ when this == Transactions => onTransactions(),
            _ when this == CreditDetails => onCreditDetails(),
            _ when this == Income => onIncome(),
            _ when this == IncomeVerification => onIncomeVerification(),
            _ when this == DepositSwitch => onDepositSwitch(),
            _ when this == StandingOrders => onStandingOrders(),
            _ when this == Transfer => onTransfer(),
            _ => otherwise(Value)
        };

    public void Match(Action onAssets,
        Action onAuth,
        Action onBalance,
        Action onIdentity,
        Action onInvestments,
        Action onLiabilities,
        Action onPaymentInitiation,
        Action onTransactions,
        Action onCreditDetails,
        Action onIncome,
        Action onIncomeVerification,
        Action onDepositSwitch,
        Action onStandingOrders,
        Action onTransfer,
        Action<string> otherwise)
    {
        if (this == Assets) onAssets();
        else if (this == Auth) onAuth();
        else if (this == Balance) onBalance();
        else if (this == Identity) onIdentity();
        else if (this == Investments) onInvestments();
        else if (this == Liabilities) onLiabilities();
        else if (this == PaymentInitiation) onPaymentInitiation();
        else if (this == Transactions) onTransactions();
        else if (this == CreditDetails) onCreditDetails();
        else if (this == Income) onIncome();
        else if (this == IncomeVerification) onIncomeVerification();
        else if (this == DepositSwitch) onDepositSwitch();
        else if (this == StandingOrders) onStandingOrders();
        else if (this == Transfer) onTransfer();
        else otherwise(Value);
    }
}
