
# Investment Account Subtype

An investment account. Supported products for `investment` accounts are: Balance and Investments.

*This model accepts additional fields of type object.*

## Structure

`InvestmentAccountSubtype`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `M529A` | `string` | Required | Tax-advantaged college savings and prepaid tuition 529 plans (US) |
| `M401A` | `string` | Required | Employer-sponsored money-purchase 401(a) retirement plan (US) |
| `M401K` | `string` | Required | Standard 401(k) retirement account (US) |
| `M403B` | `string` | Required | 403(b) retirement savings account for non-profits and schools (US) |
| `M457B` | `string` | Required | Tax-advantaged deferred-compensation 457(b) retirement plan for governments and non-profits (US) |
| `Brokerage` | `string` | Required | Standard brokerage account |
| `CashIsa` | `string` | Required | Individual Savings Account (ISA) that pays interest tax-free (UK) |
| `EducationSavingsAccount` | `string` | Required | Tax-advantaged Coverdell Education Savings Account (ESA) (US) |
| `FixedAnnuity` | `string` | Required | Fixed annuity |
| `Gic` | `string` | Required | Guaranteed Investment Certificate (Canada) |
| `HealthReimbursementArrangement` | `string` | Required | Tax-advantaged Health Reimbursement Arrangement (HRA) benefit plan (US) |
| `Hsa` | `string` | Required | Non-cash tax-advantaged medical Health Savings Account (HSA) (US) |
| `Ira` | `string` | Required | Traditional Invididual Retirement Account (IRA) (US) |
| `Isa` | `string` | Required | Non-cash Individual Savings Account (ISA) (UK) |
| `Keogh` | `string` | Required | Keogh self-employed retirement plan (US) |
| `Lif` | `string` | Required | Life Income Fund (LIF) retirement account (Canada) |
| `LifeInsurance` | `string` | Required | Life insurance account |
| `Lira` | `string` | Required | Locked-in Retirement Account (LIRA) (Canada) |
| `Lrif` | `string` | Required | Locked-in Retirement Income Fund (LRIF) (Canada) |
| `Lrsp` | `string` | Required | Locked-in Retirement Savings Plan (Canada) |
| `MutualFund` | `string` | Required | Mutual fund account |
| `NonTaxableBrokerageAccount` | `string` | Required | A non-taxable brokerage account that is not covered by a more specific subtype |
| `Other` | `string` | Required | An account whose type could not be determined |
| `OtherAnnuity` | `string` | Required | An annuity account not covered by other subtypes |
| `OtherInsurance` | `string` | Required | An insurance account not covered by other subtypes |
| `Pension` | `string` | Required | Standard pension account |
| `Prif` | `string` | Required | Prescribed Registered Retirement Income Fund (Canada) |
| `ProfitSharingPlan` | `string` | Required | Plan that gives employees share of company profits |
| `Qshr` | `string` | Required | Qualifying share account |
| `Rdsp` | `string` | Required | Registered Disability Savings Plan (RSDP) (Canada) |
| `Resp` | `string` | Required | Registered Education Savings Plan (Canada) |
| `Retirement` | `string` | Required | Retirement account not covered by other subtypes |
| `Rlif` | `string` | Required | Restricted Life Income Fund (RLIF) (Canada) |
| `Roth` | `string` | Required | Roth IRA (US) |
| `Roth401K` | `string` | Required | Employer-sponsored Roth 401(k) plan (US) |
| `Rrif` | `string` | Required | Registered Retirement Income Fund (RRIF) (Canada) |
| `Rrsp` | `string` | Required | Registered Retirement Savings Plan (Canadian, similar to US 401(k)) |
| `Sarsep` | `string` | Required | Salary Reduction Simplified Employee Pension Plan (SARSEP), discontinued retirement plan (US) |
| `SepIra` | `string` | Required | Simplified Employee Pension IRA (SEP IRA), retirement plan for small businesses and self-employed (US) |
| `SimpleIra` | `string` | Required | Savings Incentive Match Plan for Employees IRA, retirement plan for small businesses (US) |
| `Sipp` | `string` | Required | Self-Invested Personal Pension (SIPP) (UK) |
| `StockPlan` | `string` | Required | Standard stock plan account |
| `Tfsa` | `string` | Required | Tax-Free Savings Account (TFSA), a retirement plan similar to a Roth IRA (Canada) |
| `Trust` | `string` | Required | Account representing funds or assets held by a trustee for the benefit of a beneficiary. Includes both revocable and irrevocable trusts. |
| `Ugma` | `string` | Required | 'Uniform Gift to Minors Act' (brokerage account for minors, US) |
| `Utma` | `string` | Required | 'Uniform Transfers to Minors Act' (brokerage account for minors, US) |
| `VariableAnnuity` | `string` | Optional | Tax-deferred capital accumulation annuity contract |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "529a": "529a8",
  "401a": "401a8",
  "401k": "401k4",
  "403b": "403b6",
  "457b": "457b0",
  "brokerage": "brokerage6",
  "cash isa": "cash isa2",
  "education savings account": "education savings account6",
  "fixed annuity": "fixed annuity2",
  "gic": "gic4",
  "health reimbursement arrangement": "health reimbursement arrangement2",
  "hsa": "hsa6",
  "ira": "ira0",
  "isa": "isa8",
  "keogh": "keogh4",
  "lif": "lif4",
  "life insurance": "life insurance2",
  "lira": "lira8",
  "lrif": "lrif4",
  "lrsp": "lrsp8",
  "mutual fund": "mutual fund0",
  "non-taxable brokerage account": "non-taxable brokerage account2",
  "other": "other6",
  "other annuity": "other annuity6",
  "other insurance": "other insurance8",
  "pension": "pension8",
  "prif": "prif8",
  "profit sharing plan": "profit sharing plan8",
  "qshr": "qshr6",
  "rdsp": "rdsp0",
  "resp": "resp2",
  "retirement": "retirement0",
  "rlif": "rlif4",
  "roth": "roth8",
  "roth 401k": "roth 401k2",
  "rrif": "rrif4",
  "rrsp": "rrsp2",
  "sarsep": "sarsep0",
  "sep ira": "sep ira6",
  "simple ira": "simple ira8",
  "sipp": "sipp2",
  "stock plan": "stock plan8",
  "tfsa": "tfsa8",
  "trust": "trust8",
  "ugma": "ugma4",
  "utma": "utma2",
  "variable annuity": "variable annuity2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

