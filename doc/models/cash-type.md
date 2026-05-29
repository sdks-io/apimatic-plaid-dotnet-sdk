
# Cash Type

Activity that modifies a cash position

*This model accepts additional fields of type object.*

## Structure

`CashType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountFee` | `string` | Optional | Fees paid for account maintenance |
| `Contribution` | `string` | Optional | Inflow of assets into a tax-advantaged account |
| `Deposit` | `string` | Optional | Inflow of cash into an account |
| `Dividend` | `string` | Optional | Inflow of cash from a dividend |
| `StockDistribution` | `string` | Optional | Inflow of stock from a distribution |
| `Interest` | `string` | Optional | Inflow of cash from interest |
| `LegalFee` | `string` | Optional | Fees paid for legal charges or services |
| `LongTermCapitalGain` | `string` | Optional | Long-term capital gain received as cash |
| `ManagementFee` | `string` | Optional | Fees paid for investment management of a mutual fund or other pooled investment vehicle |
| `MarginExpense` | `string` | Optional | Fees paid for maintaining margin debt |
| `NonQualifiedDividend` | `string` | Optional | Inflow of cash from a non-qualified dividend |
| `NonResidentTax` | `string` | Optional | Taxes paid on behalf of the investor for non-residency in investment jurisdiction |
| `PendingCredit` | `string` | Optional | Pending inflow of cash |
| `PendingDebit` | `string` | Optional | Pending outflow of cash |
| `QualifiedDividend` | `string` | Optional | Inflow of cash from a qualified dividend |
| `ShortTermCapitalGain` | `string` | Optional | Short-term capital gain received as cash |
| `Tax` | `string` | Optional | Taxes paid on behalf of the investor |
| `TaxWithheld` | `string` | Optional | Taxes withheld on behalf of the customer |
| `TransferFee` | `string` | Optional | Fees incurred for transfer of a holding or account |
| `TrustFee` | `string` | Optional | Fees related to adminstration of a trust account |
| `UnqualifiedGain` | `string` | Optional | Unqualified capital gain received as cash |
| `Withdrawal` | `string` | Optional | Outflow of cash from an account |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "account fee": "account fee6",
  "contribution": "contribution0",
  "deposit": "deposit6",
  "dividend": "dividend6",
  "stock distribution": "stock distribution2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

