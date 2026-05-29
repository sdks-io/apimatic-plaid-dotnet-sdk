
# Phone Number

A phone number

*This model accepts additional fields of type object.*

## Structure

`PhoneNumber`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | `string` | Required | The phone number. |
| `Primary` | `bool` | Required | When `true`, identifies the phone number as the primary number on an account. |
| `Type` | [`Type`](../../doc/models/type.md) | Required | The type of phone number. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "data": "data2",
  "primary": false,
  "type": "home",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

