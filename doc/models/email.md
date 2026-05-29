
# Email

An object representing an email address

*This model accepts additional fields of type object.*

## Structure

`Email`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | `string` | Required | The email address. |
| `Primary` | `bool` | Required | When `true`, identifies the email address as the primary email on an account. |
| `Type` | [`Type1`](../../doc/models/type-1.md) | Required | The type of email account as described by the financial institution. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "data": "data4",
  "primary": false,
  "type": "other",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

