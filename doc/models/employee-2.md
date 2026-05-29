
# Employee 2

The employee on the paystub.

*This model accepts additional fields of type object.*

## Structure

`Employee2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | The name of the employee. |
| `Address` | [`Address1`](../../doc/models/address-1.md) | Optional | The address of the employee. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name6",
  "address": {
    "city": "city6",
    "region": "region2",
    "street": "street6",
    "postal_code": "postal_code8",
    "country": "country0",
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

