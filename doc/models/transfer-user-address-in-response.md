
# Transfer User Address in Response

The address associated with the account holder.

*This model accepts additional fields of type object.*

## Structure

`TransferUserAddressInResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Street` | `string` | Required | The street number and name (i.e., "100 Market St."). |
| `City` | `string` | Required | Ex. "San Francisco" |
| `Region` | `string` | Required | The state or province (e.g., "California"). |
| `PostalCode` | `string` | Required | The postal code (e.g., "94103"). |
| `Country` | `string` | Required | A two-letter country code (e.g., "US"). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "street": "street8",
  "city": "city2",
  "region": "region4",
  "postal_code": "postal_code0",
  "country": "country2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

