
# Employee

Data about the employee.

*This model accepts additional fields of type object.*

## Structure

`Employee`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The name of the employee. |
| `Address` | [`Address2`](../../doc/models/address-2.md) | Required | - |
| `MaritalStatus` | `string` | Optional | Marital status of the employee. |
| `TaxpayerId` | [`TaxpayerId`](../../doc/models/taxpayer-id.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name6",
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
  "marital_status": "marital_status4",
  "taxpayer_id": {
    "id_type": "id_type8",
    "last_4_digits": "last_4_digits6",
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

