
# Address Data 1

Data about the components comprising an address.

*This model accepts additional fields of type object.*

## Structure

`AddressData1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `City` | `string` | Optional | The full city name |
| `Region` | `string` | Optional | The region or state<br>Example: `"NC"` |
| `Street` | `string` | Optional | The full street address<br>Example: `"564 Main Street, APT 15"` |
| `PostalCode` | `string` | Optional | The postal code |
| `Country` | `string` | Optional | The ISO 3166-1 alpha-2 country code |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "city": "city4",
  "region": "region2",
  "street": "street6",
  "postal_code": "postal_code8",
  "country": "country0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

