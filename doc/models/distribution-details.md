
# Distribution Details

An object representing information about a distribution from the paycheck (for example, the amount distributed to a specific checking account, or to a retirement plan).

*This model accepts additional fields of type object.*

## Structure

`DistributionDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountNumber` | `string` | Optional | The account number of the account being deposited to. |
| `BankAccountType` | `string` | Optional | The type of bank account (e.g. Checking or Savings) |
| `BankName` | `string` | Optional | The name of the bank that the payment is being deposited to. |
| `CurrentPay` | [`Pay`](../../doc/models/pay.md) | Optional | An object representing a monetary amount. |
| `Description` | `string` | Optional | A description of the distribution type. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "account_number": "account_number8",
  "bank_account_type": "bank_account_type0",
  "bank_name": "bank_name2",
  "current_pay": {
    "amount": 45.16,
    "currency": "currency4",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "description": "description2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

