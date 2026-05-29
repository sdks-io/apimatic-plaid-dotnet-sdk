
# Employer 2

*This model accepts additional fields of type object.*

## Structure

`Employer2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The name of the employer on the paystub. |
| `Address` | [`Address2`](../../doc/models/address-2.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name8",
  "address": {
    "city": "city6",
    "street": "street6",
    "line1": "line18",
    "line2": "line20",
    "postal_code": "postal_code8",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

