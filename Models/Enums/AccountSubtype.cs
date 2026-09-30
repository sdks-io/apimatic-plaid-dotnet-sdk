using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// See the <see href="https://plaid.com/docs/api/accounts/#account-type-schema">Account type schema</see> for a full listing of account types and corresponding subtypes.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountSubtype>))]
public sealed record AccountSubtype : OpenStringEnum<AccountSubtype>
{
    private AccountSubtype(string value) : base(value)
    {
    }

    public static readonly AccountSubtype _401A = new("401a");

    public static readonly AccountSubtype _401K = new("401k");

    public static readonly AccountSubtype _403B = new("403B");

    public static readonly AccountSubtype _457B = new("457b");

    public static readonly AccountSubtype _529 = new("529");

    public static readonly AccountSubtype Brokerage = new("brokerage");

    public static readonly AccountSubtype CashIsa = new("cash isa");

    public static readonly AccountSubtype EducationSavingsAccount = new("education savings account");

    public static readonly AccountSubtype Ebt = new("ebt");

    public static readonly AccountSubtype FixedAnnuity = new("fixed annuity");

    public static readonly AccountSubtype Gic = new("gic");

    public static readonly AccountSubtype HealthReimbursementArrangement = new("health reimbursement arrangement");

    public static readonly AccountSubtype Hsa = new("hsa");

    public static readonly AccountSubtype Isa = new("isa");

    public static readonly AccountSubtype Ira = new("ira");

    public static readonly AccountSubtype Lif = new("lif");

    public static readonly AccountSubtype LifeInsurance = new("life insurance");

    public static readonly AccountSubtype Lira = new("lira");

    public static readonly AccountSubtype Lrif = new("lrif");

    public static readonly AccountSubtype Lrsp = new("lrsp");

    public static readonly AccountSubtype NonTaxableBrokerageAccount = new("non-taxable brokerage account");

    public static readonly AccountSubtype Other = new("other");

    public static readonly AccountSubtype OtherInsurance = new("other insurance");

    public static readonly AccountSubtype OtherAnnuity = new("other annuity");

    public static readonly AccountSubtype Prif = new("prif");

    public static readonly AccountSubtype Rdsp = new("rdsp");

    public static readonly AccountSubtype Resp = new("resp");

    public static readonly AccountSubtype Rlif = new("rlif");

    public static readonly AccountSubtype Rrif = new("rrif");

    public static readonly AccountSubtype Pension = new("pension");

    public static readonly AccountSubtype ProfitSharingPlan = new("profit sharing plan");

    public static readonly AccountSubtype Retirement = new("retirement");

    public static readonly AccountSubtype Roth = new("roth");

    public static readonly AccountSubtype Roth401K = new("roth 401k");

    public static readonly AccountSubtype Rrsp = new("rrsp");

    public static readonly AccountSubtype SepIra = new("sep ira");

    public static readonly AccountSubtype SimpleIra = new("simple ira");

    public static readonly AccountSubtype Sipp = new("sipp");

    public static readonly AccountSubtype StockPlan = new("stock plan");

    public static readonly AccountSubtype ThriftSavingsPlan = new("thrift savings plan");

    public static readonly AccountSubtype Tfsa = new("tfsa");

    public static readonly AccountSubtype Trust = new("trust");

    public static readonly AccountSubtype Ugma = new("ugma");

    public static readonly AccountSubtype Utma = new("utma");

    public static readonly AccountSubtype VariableAnnuity = new("variable annuity");

    public static readonly AccountSubtype CreditCard = new("credit card");

    public static readonly AccountSubtype Paypal = new("paypal");

    public static readonly AccountSubtype Cd = new("cd");

    public static readonly AccountSubtype Checking = new("checking");

    public static readonly AccountSubtype Savings = new("savings");

    public static readonly AccountSubtype MoneyMarket = new("money market");

    public static readonly AccountSubtype Prepaid = new("prepaid");

    public static readonly AccountSubtype Auto = new("auto");

    public static readonly AccountSubtype Business = new("business");

    public static readonly AccountSubtype Commercial = new("commercial");

    public static readonly AccountSubtype Construction = new("construction");

    public static readonly AccountSubtype Consumer = new("consumer");

    public static readonly AccountSubtype Home = new("home");

    public static readonly AccountSubtype HomeEquity = new("home equity");

    public static readonly AccountSubtype Loan = new("loan");

    public static readonly AccountSubtype Mortgage = new("mortgage");

    public static readonly AccountSubtype Overdraft = new("overdraft");

    public static readonly AccountSubtype LineOfCredit = new("line of credit");

    public static readonly AccountSubtype Student = new("student");

    public static readonly AccountSubtype CashManagement = new("cash management");

    public static readonly AccountSubtype Keogh = new("keogh");

    public static readonly AccountSubtype MutualFund = new("mutual fund");

    public static readonly AccountSubtype Recurring = new("recurring");

    public static readonly AccountSubtype Rewards = new("rewards");

    public static readonly AccountSubtype SafeDeposit = new("safe deposit");

    public static readonly AccountSubtype Sarsep = new("sarsep");

    public static readonly AccountSubtype Payroll = new("payroll");

    public TResult Match<TResult>(Func<TResult> on_401A,
        Func<TResult> on_401K,
        Func<TResult> on_403B,
        Func<TResult> on_457B,
        Func<TResult> on_529,
        Func<TResult> onBrokerage,
        Func<TResult> onCashIsa,
        Func<TResult> onEducationSavingsAccount,
        Func<TResult> onEbt,
        Func<TResult> onFixedAnnuity,
        Func<TResult> onGic,
        Func<TResult> onHealthReimbursementArrangement,
        Func<TResult> onHsa,
        Func<TResult> onIsa,
        Func<TResult> onIra,
        Func<TResult> onLif,
        Func<TResult> onLifeInsurance,
        Func<TResult> onLira,
        Func<TResult> onLrif,
        Func<TResult> onLrsp,
        Func<TResult> onNonTaxableBrokerageAccount,
        Func<TResult> onOther,
        Func<TResult> onOtherInsurance,
        Func<TResult> onOtherAnnuity,
        Func<TResult> onPrif,
        Func<TResult> onRdsp,
        Func<TResult> onResp,
        Func<TResult> onRlif,
        Func<TResult> onRrif,
        Func<TResult> onPension,
        Func<TResult> onProfitSharingPlan,
        Func<TResult> onRetirement,
        Func<TResult> onRoth,
        Func<TResult> onRoth401K,
        Func<TResult> onRrsp,
        Func<TResult> onSepIra,
        Func<TResult> onSimpleIra,
        Func<TResult> onSipp,
        Func<TResult> onStockPlan,
        Func<TResult> onThriftSavingsPlan,
        Func<TResult> onTfsa,
        Func<TResult> onTrust,
        Func<TResult> onUgma,
        Func<TResult> onUtma,
        Func<TResult> onVariableAnnuity,
        Func<TResult> onCreditCard,
        Func<TResult> onPaypal,
        Func<TResult> onCd,
        Func<TResult> onChecking,
        Func<TResult> onSavings,
        Func<TResult> onMoneyMarket,
        Func<TResult> onPrepaid,
        Func<TResult> onAuto,
        Func<TResult> onBusiness,
        Func<TResult> onCommercial,
        Func<TResult> onConstruction,
        Func<TResult> onConsumer,
        Func<TResult> onHome,
        Func<TResult> onHomeEquity,
        Func<TResult> onLoan,
        Func<TResult> onMortgage,
        Func<TResult> onOverdraft,
        Func<TResult> onLineOfCredit,
        Func<TResult> onStudent,
        Func<TResult> onCashManagement,
        Func<TResult> onKeogh,
        Func<TResult> onMutualFund,
        Func<TResult> onRecurring,
        Func<TResult> onRewards,
        Func<TResult> onSafeDeposit,
        Func<TResult> onSarsep,
        Func<TResult> onPayroll,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _401A => on_401A(),
            _ when this == _401K => on_401K(),
            _ when this == _403B => on_403B(),
            _ when this == _457B => on_457B(),
            _ when this == _529 => on_529(),
            _ when this == Brokerage => onBrokerage(),
            _ when this == CashIsa => onCashIsa(),
            _ when this == EducationSavingsAccount => onEducationSavingsAccount(),
            _ when this == Ebt => onEbt(),
            _ when this == FixedAnnuity => onFixedAnnuity(),
            _ when this == Gic => onGic(),
            _ when this == HealthReimbursementArrangement => onHealthReimbursementArrangement(),
            _ when this == Hsa => onHsa(),
            _ when this == Isa => onIsa(),
            _ when this == Ira => onIra(),
            _ when this == Lif => onLif(),
            _ when this == LifeInsurance => onLifeInsurance(),
            _ when this == Lira => onLira(),
            _ when this == Lrif => onLrif(),
            _ when this == Lrsp => onLrsp(),
            _ when this == NonTaxableBrokerageAccount => onNonTaxableBrokerageAccount(),
            _ when this == Other => onOther(),
            _ when this == OtherInsurance => onOtherInsurance(),
            _ when this == OtherAnnuity => onOtherAnnuity(),
            _ when this == Prif => onPrif(),
            _ when this == Rdsp => onRdsp(),
            _ when this == Resp => onResp(),
            _ when this == Rlif => onRlif(),
            _ when this == Rrif => onRrif(),
            _ when this == Pension => onPension(),
            _ when this == ProfitSharingPlan => onProfitSharingPlan(),
            _ when this == Retirement => onRetirement(),
            _ when this == Roth => onRoth(),
            _ when this == Roth401K => onRoth401K(),
            _ when this == Rrsp => onRrsp(),
            _ when this == SepIra => onSepIra(),
            _ when this == SimpleIra => onSimpleIra(),
            _ when this == Sipp => onSipp(),
            _ when this == StockPlan => onStockPlan(),
            _ when this == ThriftSavingsPlan => onThriftSavingsPlan(),
            _ when this == Tfsa => onTfsa(),
            _ when this == Trust => onTrust(),
            _ when this == Ugma => onUgma(),
            _ when this == Utma => onUtma(),
            _ when this == VariableAnnuity => onVariableAnnuity(),
            _ when this == CreditCard => onCreditCard(),
            _ when this == Paypal => onPaypal(),
            _ when this == Cd => onCd(),
            _ when this == Checking => onChecking(),
            _ when this == Savings => onSavings(),
            _ when this == MoneyMarket => onMoneyMarket(),
            _ when this == Prepaid => onPrepaid(),
            _ when this == Auto => onAuto(),
            _ when this == Business => onBusiness(),
            _ when this == Commercial => onCommercial(),
            _ when this == Construction => onConstruction(),
            _ when this == Consumer => onConsumer(),
            _ when this == Home => onHome(),
            _ when this == HomeEquity => onHomeEquity(),
            _ when this == Loan => onLoan(),
            _ when this == Mortgage => onMortgage(),
            _ when this == Overdraft => onOverdraft(),
            _ when this == LineOfCredit => onLineOfCredit(),
            _ when this == Student => onStudent(),
            _ when this == CashManagement => onCashManagement(),
            _ when this == Keogh => onKeogh(),
            _ when this == MutualFund => onMutualFund(),
            _ when this == Recurring => onRecurring(),
            _ when this == Rewards => onRewards(),
            _ when this == SafeDeposit => onSafeDeposit(),
            _ when this == Sarsep => onSarsep(),
            _ when this == Payroll => onPayroll(),
            _ => otherwise(Value)
        };

    public void Match(Action on_401A,
        Action on_401K,
        Action on_403B,
        Action on_457B,
        Action on_529,
        Action onBrokerage,
        Action onCashIsa,
        Action onEducationSavingsAccount,
        Action onEbt,
        Action onFixedAnnuity,
        Action onGic,
        Action onHealthReimbursementArrangement,
        Action onHsa,
        Action onIsa,
        Action onIra,
        Action onLif,
        Action onLifeInsurance,
        Action onLira,
        Action onLrif,
        Action onLrsp,
        Action onNonTaxableBrokerageAccount,
        Action onOther,
        Action onOtherInsurance,
        Action onOtherAnnuity,
        Action onPrif,
        Action onRdsp,
        Action onResp,
        Action onRlif,
        Action onRrif,
        Action onPension,
        Action onProfitSharingPlan,
        Action onRetirement,
        Action onRoth,
        Action onRoth401K,
        Action onRrsp,
        Action onSepIra,
        Action onSimpleIra,
        Action onSipp,
        Action onStockPlan,
        Action onThriftSavingsPlan,
        Action onTfsa,
        Action onTrust,
        Action onUgma,
        Action onUtma,
        Action onVariableAnnuity,
        Action onCreditCard,
        Action onPaypal,
        Action onCd,
        Action onChecking,
        Action onSavings,
        Action onMoneyMarket,
        Action onPrepaid,
        Action onAuto,
        Action onBusiness,
        Action onCommercial,
        Action onConstruction,
        Action onConsumer,
        Action onHome,
        Action onHomeEquity,
        Action onLoan,
        Action onMortgage,
        Action onOverdraft,
        Action onLineOfCredit,
        Action onStudent,
        Action onCashManagement,
        Action onKeogh,
        Action onMutualFund,
        Action onRecurring,
        Action onRewards,
        Action onSafeDeposit,
        Action onSarsep,
        Action onPayroll,
        Action<string> otherwise)
    {
        if (this == _401A) on_401A();
        else if (this == _401K) on_401K();
        else if (this == _403B) on_403B();
        else if (this == _457B) on_457B();
        else if (this == _529) on_529();
        else if (this == Brokerage) onBrokerage();
        else if (this == CashIsa) onCashIsa();
        else if (this == EducationSavingsAccount) onEducationSavingsAccount();
        else if (this == Ebt) onEbt();
        else if (this == FixedAnnuity) onFixedAnnuity();
        else if (this == Gic) onGic();
        else if (this == HealthReimbursementArrangement) onHealthReimbursementArrangement();
        else if (this == Hsa) onHsa();
        else if (this == Isa) onIsa();
        else if (this == Ira) onIra();
        else if (this == Lif) onLif();
        else if (this == LifeInsurance) onLifeInsurance();
        else if (this == Lira) onLira();
        else if (this == Lrif) onLrif();
        else if (this == Lrsp) onLrsp();
        else if (this == NonTaxableBrokerageAccount) onNonTaxableBrokerageAccount();
        else if (this == Other) onOther();
        else if (this == OtherInsurance) onOtherInsurance();
        else if (this == OtherAnnuity) onOtherAnnuity();
        else if (this == Prif) onPrif();
        else if (this == Rdsp) onRdsp();
        else if (this == Resp) onResp();
        else if (this == Rlif) onRlif();
        else if (this == Rrif) onRrif();
        else if (this == Pension) onPension();
        else if (this == ProfitSharingPlan) onProfitSharingPlan();
        else if (this == Retirement) onRetirement();
        else if (this == Roth) onRoth();
        else if (this == Roth401K) onRoth401K();
        else if (this == Rrsp) onRrsp();
        else if (this == SepIra) onSepIra();
        else if (this == SimpleIra) onSimpleIra();
        else if (this == Sipp) onSipp();
        else if (this == StockPlan) onStockPlan();
        else if (this == ThriftSavingsPlan) onThriftSavingsPlan();
        else if (this == Tfsa) onTfsa();
        else if (this == Trust) onTrust();
        else if (this == Ugma) onUgma();
        else if (this == Utma) onUtma();
        else if (this == VariableAnnuity) onVariableAnnuity();
        else if (this == CreditCard) onCreditCard();
        else if (this == Paypal) onPaypal();
        else if (this == Cd) onCd();
        else if (this == Checking) onChecking();
        else if (this == Savings) onSavings();
        else if (this == MoneyMarket) onMoneyMarket();
        else if (this == Prepaid) onPrepaid();
        else if (this == Auto) onAuto();
        else if (this == Business) onBusiness();
        else if (this == Commercial) onCommercial();
        else if (this == Construction) onConstruction();
        else if (this == Consumer) onConsumer();
        else if (this == Home) onHome();
        else if (this == HomeEquity) onHomeEquity();
        else if (this == Loan) onLoan();
        else if (this == Mortgage) onMortgage();
        else if (this == Overdraft) onOverdraft();
        else if (this == LineOfCredit) onLineOfCredit();
        else if (this == Student) onStudent();
        else if (this == CashManagement) onCashManagement();
        else if (this == Keogh) onKeogh();
        else if (this == MutualFund) onMutualFund();
        else if (this == Recurring) onRecurring();
        else if (this == Rewards) onRewards();
        else if (this == SafeDeposit) onSafeDeposit();
        else if (this == Sarsep) onSarsep();
        else if (this == Payroll) onPayroll();
        else otherwise(Value);
    }
}
