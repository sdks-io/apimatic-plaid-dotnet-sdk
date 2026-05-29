
# Mortgage Property Address

Object containing fields describing property address.

*This model accepts additional fields of type object.*

## Structure

`MortgagePropertyAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `City` | `string` | Required | The city name. |
| `Country` | `string` | Required | The ISO 3166-1 alpha-2 country code. |
| `PostalCode` | `string` | Required | The five or nine digit postal code. |
| `Region` | `string` | Required | The region or state (example "NC"). |
| `Street` | `string` | Required | The full street address (example "564 Main Street, Apt 15"). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "city": "city6",
  "country": "country0",
  "postal_code": "postal_code8",
  "region": "region2",
  "street": "street6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

