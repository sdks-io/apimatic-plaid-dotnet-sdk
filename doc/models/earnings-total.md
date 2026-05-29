
# Earnings Total

An object representing both the current pay period and year to date amount for an earning category.

*This model accepts additional fields of type object.*

## Structure

`EarningsTotal`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CanonicalDescription` | [`CanonicalDescription?`](../../doc/models/canonical-description.md) | Optional | Commonly used term to describe the line item. |
| `Description` | `string` | Optional | Text of the line item as printed on the paystub. |
| `CurrentPay` | [`Pay`](../../doc/models/pay.md) | Optional | An object representing a monetary amount. |
| `YtdPay` | [`Pay`](../../doc/models/pay.md) | Optional | An object representing a monetary amount. |
| `CurrentHours` | `string` | Optional | - |
| `CurrentRate` | `string` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "canonical_description": "EMPLOYEE MEDICARE",
  "description": "description8",
  "current_pay": {
    "amount": 45.16,
    "currency": "currency4",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "ytd_pay": {
    "amount": 28.98,
    "currency": "currency0",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "current_hours": "current_hours0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

