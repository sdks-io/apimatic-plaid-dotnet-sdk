
# Transaction Location

A representation of where a transaction took place

*This model accepts additional fields of type object.*

## Structure

`TransactionLocation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Address` | `string` | Required | The street address where the transaction occurred. |
| `City` | `string` | Required | The city where the transaction occurred. |
| `Region` | `string` | Required | The region or state where the transaction occurred. |
| `PostalCode` | `string` | Required | The postal code where the transaction occurred. |
| `Country` | `string` | Required | The ISO 3166-1 alpha-2 country code where the transaction occurred. |
| `Lat` | `double?` | Required | The latitude where the transaction occurred. |
| `Lon` | `double?` | Required | The longitude where the transaction occurred. |
| `StoreNumber` | `string` | Required | The merchant defined store number where the transaction occurred. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "address": "address8",
  "city": "city8",
  "region": "region8",
  "postal_code": "postal_code4",
  "country": "country6",
  "lat": 198.3,
  "lon": 224.6,
  "store_number": "store_number8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

