
# Address Data

Data about the components comprising an address.

*This model accepts additional fields of type object.*

## Structure

`AddressData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `City` | `string` | Required | The full city name |
| `Region` | `string` | Required | The region or state<br>Example: `"NC"` |
| `Street` | `string` | Required | The full street address<br>Example: `"564 Main Street, APT 15"` |
| `PostalCode` | `string` | Required | The postal code |
| `Country` | `string` | Required | The ISO 3166-1 alpha-2 country code |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "city": "city4",
  "region": "region0",
  "street": "street4",
  "postal_code": "postal_code6",
  "country": "country8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

