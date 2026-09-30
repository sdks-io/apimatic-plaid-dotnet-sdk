using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An investment account. Supported products for <c>investment</c> accounts are: Balance and Investments.
/// </summary>
public record InvestmentAccountSubtype
{
    /// <summary>
    /// Tax-advantaged college savings and prepaid tuition 529 plans (US)
    /// </summary>
    [JsonPropertyName("529a")]
    public required string A529 { get; init; }

    /// <summary>
    /// Employer-sponsored money-purchase 401(a) retirement plan (US)
    /// </summary>
    [JsonPropertyName("401a")]
    public required string A401 { get; init; }

    /// <summary>
    /// Standard 401(k) retirement account (US)
    /// </summary>
    [JsonPropertyName("401k")]
    public required string K401 { get; init; }

    /// <summary>
    /// 403(b) retirement savings account for non-profits and schools (US)
    /// </summary>
    [JsonPropertyName("403b")]
    public required string B403 { get; init; }

    /// <summary>
    /// Tax-advantaged deferred-compensation 457(b) retirement plan for governments and non-profits (US)
    /// </summary>
    [JsonPropertyName("457b")]
    public required string B457 { get; init; }

    /// <summary>
    /// Standard brokerage account
    /// </summary>
    [JsonPropertyName("brokerage")]
    public required string Brokerage { get; init; }

    /// <summary>
    /// Individual Savings Account (ISA) that pays interest tax-free (UK)
    /// </summary>
    [JsonPropertyName("cash isa")]
    public required string CashIsa { get; init; }

    /// <summary>
    /// Tax-advantaged Coverdell Education Savings Account (ESA) (US)
    /// </summary>
    [JsonPropertyName("education savings account")]
    public required string EducationSavingsAccount { get; init; }

    /// <summary>
    /// Fixed annuity
    /// </summary>
    [JsonPropertyName("fixed annuity")]
    public required string FixedAnnuity { get; init; }

    /// <summary>
    /// Guaranteed Investment Certificate (Canada)
    /// </summary>
    [JsonPropertyName("gic")]
    public required string Gic { get; init; }

    /// <summary>
    /// Tax-advantaged Health Reimbursement Arrangement (HRA) benefit plan (US)
    /// </summary>
    [JsonPropertyName("health reimbursement arrangement")]
    public required string HealthReimbursementArrangement { get; init; }

    /// <summary>
    /// Non-cash tax-advantaged medical Health Savings Account (HSA) (US)
    /// </summary>
    [JsonPropertyName("hsa")]
    public required string Hsa { get; init; }

    /// <summary>
    /// Traditional Invididual Retirement Account (IRA) (US)
    /// </summary>
    [JsonPropertyName("ira")]
    public required string Ira { get; init; }

    /// <summary>
    /// Non-cash Individual Savings Account (ISA) (UK)
    /// </summary>
    [JsonPropertyName("isa")]
    public required string Isa { get; init; }

    /// <summary>
    /// Keogh self-employed retirement plan (US)
    /// </summary>
    [JsonPropertyName("keogh")]
    public required string Keogh { get; init; }

    /// <summary>
    /// Life Income Fund (LIF) retirement account (Canada)
    /// </summary>
    [JsonPropertyName("lif")]
    public required string Lif { get; init; }

    /// <summary>
    /// Life insurance account
    /// </summary>
    [JsonPropertyName("life insurance")]
    public required string LifeInsurance { get; init; }

    /// <summary>
    /// Locked-in Retirement Account (LIRA) (Canada)
    /// </summary>
    [JsonPropertyName("lira")]
    public required string Lira { get; init; }

    /// <summary>
    /// Locked-in Retirement Income Fund (LRIF) (Canada)
    /// </summary>
    [JsonPropertyName("lrif")]
    public required string Lrif { get; init; }

    /// <summary>
    /// Locked-in Retirement Savings Plan (Canada)
    /// </summary>
    [JsonPropertyName("lrsp")]
    public required string Lrsp { get; init; }

    /// <summary>
    /// Mutual fund account
    /// </summary>
    [JsonPropertyName("mutual fund")]
    public required string MutualFund { get; init; }

    /// <summary>
    /// A non-taxable brokerage account that is not covered by a more specific subtype
    /// </summary>
    [JsonPropertyName("non-taxable brokerage account")]
    public required string NonTaxableBrokerageAccount { get; init; }

    /// <summary>
    /// An account whose type could not be determined
    /// </summary>
    [JsonPropertyName("other")]
    public required string Other { get; init; }

    /// <summary>
    /// An annuity account not covered by other subtypes
    /// </summary>
    [JsonPropertyName("other annuity")]
    public required string OtherAnnuity { get; init; }

    /// <summary>
    /// An insurance account not covered by other subtypes
    /// </summary>
    [JsonPropertyName("other insurance")]
    public required string OtherInsurance { get; init; }

    /// <summary>
    /// Standard pension account
    /// </summary>
    [JsonPropertyName("pension")]
    public required string Pension { get; init; }

    /// <summary>
    /// Prescribed Registered Retirement Income Fund (Canada)
    /// </summary>
    [JsonPropertyName("prif")]
    public required string Prif { get; init; }

    /// <summary>
    /// Plan that gives employees share of company profits
    /// </summary>
    [JsonPropertyName("profit sharing plan")]
    public required string ProfitSharingPlan { get; init; }

    /// <summary>
    /// Qualifying share account
    /// </summary>
    [JsonPropertyName("qshr")]
    public required string Qshr { get; init; }

    /// <summary>
    /// Registered Disability Savings Plan (RSDP) (Canada)
    /// </summary>
    [JsonPropertyName("rdsp")]
    public required string Rdsp { get; init; }

    /// <summary>
    /// Registered Education Savings Plan (Canada)
    /// </summary>
    [JsonPropertyName("resp")]
    public required string Resp { get; init; }

    /// <summary>
    /// Retirement account not covered by other subtypes
    /// </summary>
    [JsonPropertyName("retirement")]
    public required string Retirement { get; init; }

    /// <summary>
    /// Restricted Life Income Fund (RLIF) (Canada)
    /// </summary>
    [JsonPropertyName("rlif")]
    public required string Rlif { get; init; }

    /// <summary>
    /// Roth IRA (US)
    /// </summary>
    [JsonPropertyName("roth")]
    public required string Roth { get; init; }

    /// <summary>
    /// Employer-sponsored Roth 401(k) plan (US)
    /// </summary>
    [JsonPropertyName("roth 401k")]
    public required string Roth401K { get; init; }

    /// <summary>
    /// Registered Retirement Income Fund (RRIF) (Canada)
    /// </summary>
    [JsonPropertyName("rrif")]
    public required string Rrif { get; init; }

    /// <summary>
    /// Registered Retirement Savings Plan (Canadian, similar to US 401(k))
    /// </summary>
    [JsonPropertyName("rrsp")]
    public required string Rrsp { get; init; }

    /// <summary>
    /// Salary Reduction Simplified Employee Pension Plan (SARSEP), discontinued retirement plan (US)
    /// </summary>
    [JsonPropertyName("sarsep")]
    public required string Sarsep { get; init; }

    /// <summary>
    /// Simplified Employee Pension IRA (SEP IRA), retirement plan for small businesses and self-employed (US)
    /// </summary>
    [JsonPropertyName("sep ira")]
    public required string SepIra { get; init; }

    /// <summary>
    /// Savings Incentive Match Plan for Employees IRA, retirement plan for small businesses (US)
    /// </summary>
    [JsonPropertyName("simple ira")]
    public required string SimpleIra { get; init; }

    /// <summary>
    /// Self-Invested Personal Pension (SIPP) (UK)
    /// </summary>
    [JsonPropertyName("sipp")]
    public required string Sipp { get; init; }

    /// <summary>
    /// Standard stock plan account
    /// </summary>
    [JsonPropertyName("stock plan")]
    public required string StockPlan { get; init; }

    /// <summary>
    /// Tax-Free Savings Account (TFSA), a retirement plan similar to a Roth IRA (Canada)
    /// </summary>
    [JsonPropertyName("tfsa")]
    public required string Tfsa { get; init; }

    /// <summary>
    /// Account representing funds or assets held by a trustee for the benefit of a beneficiary. Includes both revocable and irrevocable trusts.
    /// </summary>
    [JsonPropertyName("trust")]
    public required string Trust { get; init; }

    /// <summary>
    /// 'Uniform Gift to Minors Act' (brokerage account for minors, US)
    /// </summary>
    [JsonPropertyName("ugma")]
    public required string Ugma { get; init; }

    /// <summary>
    /// 'Uniform Transfers to Minors Act' (brokerage account for minors, US)
    /// </summary>
    [JsonPropertyName("utma")]
    public required string Utma { get; init; }

    /// <summary>
    /// Tax-deferred capital accumulation annuity contract
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("variable annuity")]
    public string? VariableAnnuity { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
