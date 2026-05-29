
# Servicer Address Data

The address of the student loan servicer. This is generally the remittance address to which payments should be sent.

*This model accepts additional fields of type object.*

## Structure

`ServicerAddressData`

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

