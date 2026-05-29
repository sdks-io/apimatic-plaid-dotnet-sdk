
# Deposit Switch Address Data

The user's address.

*This model accepts additional fields of type object.*

## Structure

`DepositSwitchAddressData`

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
  "city": "city0",
  "region": "region6",
  "street": "street0",
  "postal_code": "postal_code2",
  "country": "country4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

