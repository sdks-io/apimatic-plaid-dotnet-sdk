
# Fee Type

Fees on the account, e.g. commission, bookkeeping, options-related.

*This model accepts additional fields of type object.*

## Structure

`FeeType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountFee` | `string` | Optional | Fees paid for account maintenance |
| `Adjustment` | `string` | Optional | Increase or decrease in quantity of item |
| `Dividend` | `string` | Optional | Inflow of cash from a dividend |
| `Interest` | `string` | Optional | Inflow of cash from interest |
| `InterestReceivable` | `string` | Optional | Inflow of cash from interest receivable |
| `LongTermCapitalGain` | `string` | Optional | Long-term capital gain received as cash |
| `LegalFee` | `string` | Optional | Fees paid for legal charges or services |
| `ManagementFee` | `string` | Optional | Fees paid for investment management of a mutual fund or other pooled investment vehicle |
| `MarginExpense` | `string` | Optional | Fees paid for maintaining margin debt |
| `NonQualifiedDividend` | `string` | Optional | Inflow of cash from a non-qualified dividend |
| `NonResidentTax` | `string` | Optional | Taxes paid on behalf of the investor for non-residency in investment jurisdiction |
| `QualifiedDividend` | `string` | Optional | Inflow of cash from a qualified dividend |
| `ReturnOfPrincipal` | `string` | Optional | Repayment of loan principal |
| `ShortTermCapitalGain` | `string` | Optional | Short-term capital gain received as cash |
| `StockDistribution` | `string` | Optional | Inflow of stock from a distribution |
| `Tax` | `string` | Optional | Taxes paid on behalf of the investor |
| `TaxWithheld` | `string` | Optional | Taxes withheld on behalf of the customer |
| `TransferFee` | `string` | Optional | Fees incurred for transfer of a holding or account |
| `TrustFee` | `string` | Optional | Fees related to adminstration of a trust account |
| `UnqualifiedGain` | `string` | Optional | Unqualified capital gain received as cash |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "account fee": "account fee4",
  "adjustment": "adjustment4",
  "dividend": "dividend4",
  "interest": "interest0",
  "interest receivable": "interest receivable0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

