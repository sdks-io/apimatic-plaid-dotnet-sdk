
# Transfer User Address in Request

The address associated with the account holder.

*This model accepts additional fields of type object.*

## Structure

`TransferUserAddressInRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Street` | `string` | Optional | The street number and name (i.e., "100 Market St."). |
| `City` | `string` | Optional | Ex. "San Francisco" |
| `Region` | `string` | Optional | The state or province (e.g., "California"). |
| `PostalCode` | `string` | Optional | The postal code (e.g., "94103"). |
| `Country` | `string` | Optional | A two-letter country code (e.g., "US"). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "street": "street0",
  "city": "city0",
  "region": "region6",
  "postal_code": "postal_code2",
  "country": "country4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

