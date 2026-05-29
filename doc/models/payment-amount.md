
# Payment Amount

The amount and currency of a payment

*This model accepts additional fields of type object.*

## Structure

`PaymentAmount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | [`Currency`](../../doc/models/currency.md) | Required | The ISO-4217 currency code of the payment. For standing orders, `"GBP"` must be used. |
| `MValue` | `double` | Required | The amount of the payment. Must contain at most two digits of precision e.g. `1.23`. Minimum accepted value is `1`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "currency": "GBP",
  "value": 106.08,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

