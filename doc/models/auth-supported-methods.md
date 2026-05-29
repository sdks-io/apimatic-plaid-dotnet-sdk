
# Auth Supported Methods

Metadata specifically related to which auth methods an institution supports.

*This model accepts additional fields of type object.*

## Structure

`AuthSupportedMethods`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InstantAuth` | `bool` | Required | Indicates if instant auth is supported. |
| `InstantMatch` | `bool` | Required | Indicates if instant match is supported. |
| `AutomatedMicroDeposits` | `bool` | Required | Indicates if automated microdeposits are supported. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "instant_auth": false,
  "instant_match": false,
  "automated_micro_deposits": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

