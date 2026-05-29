
# Address 2

*This model accepts additional fields of type object.*

## Structure

`Address2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `City` | `string` | Optional | The full city name. |
| `Street` | `string` | Optional | The listed street address. |
| `Line1` | `string` | Optional | Street address line 1. |
| `Line2` | `string` | Optional | Street address line 2. |
| `PostalCode` | `string` | Optional | 5 digit postal code. |
| `Region` | `string` | Optional | The region or state<br>Example: `"NC"` |
| `StateCode` | `string` | Optional | The region or state<br>Example: `"NC"` |
| `Country` | `string` | Optional | The country of the address. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "city": "city0",
  "street": "street0",
  "line1": "line12",
  "line2": "line24",
  "postal_code": "postal_code2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

