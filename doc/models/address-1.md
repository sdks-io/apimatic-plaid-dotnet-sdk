
# Address 1

The address of the employee.

*This model accepts additional fields of type object.*

## Structure

`Address1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `City` | `string` | Optional | The full city name. |
| `Region` | `string` | Optional | The region or state<br>Example: `"NC"` |
| `Street` | `string` | Optional | The full street address<br>Example: `"564 Main Street, APT 15"` |
| `PostalCode` | `string` | Optional | 5 digit postal code. |
| `Country` | `string` | Optional | The country of the address. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "city": "city2",
  "region": "region8",
  "street": "street2",
  "postal_code": "postal_code4",
  "country": "country6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

