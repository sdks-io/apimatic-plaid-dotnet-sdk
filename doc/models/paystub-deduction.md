
# Paystub Deduction

*This model accepts additional fields of type object.*

## Structure

`PaystubDeduction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | The description of the deduction, as provided on the paystub. For example: `"401(k)"`, `"FICA MED TAX"`. |
| `IsPretax` | `bool?` | Required | `true` if the deduction is pre-tax; `false` otherwise. |
| `Total` | `double?` | Required | The amount of the deduction. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "type": "type2",
  "is_pretax": false,
  "total": 221.52,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

