
# Address Nullable

*This model accepts additional fields of type object.*

## Structure

`AddressNullable`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`AddressData`](../../doc/models/address-data.md) | Required | Data about the components comprising an address. |
| `Primary` | `bool?` | Optional | When `true`, identifies the address as the primary address on an account. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "city": "city0",
    "region": "region6",
    "street": "street0",
    "postal_code": "postal_code2",
    "country": "country4",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "primary": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

