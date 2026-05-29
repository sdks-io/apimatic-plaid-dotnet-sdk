
# Item Import Request User Auth

Object of user ID and auth token pair, permitting Plaid to aggregate a user’s accounts

*This model accepts additional fields of type object.*

## Structure

`ItemImportRequestUserAuth`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UserId` | `string` | Required | Opaque user identifier |
| `AuthToken` | `string` | Required | Authorization token Plaid will use to aggregate this user’s accounts |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "user_id": "user_id2",
  "auth_token": "auth_token0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

