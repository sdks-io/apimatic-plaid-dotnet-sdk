
# Item Application List User Auth

User authentication parameters, for clients making a request without an `access_token`. This is only allowed for select clients and will not be supported in the future. Most clients should call /item/import to obtain an access token before making a request.

*This model accepts additional fields of type object.*

## Structure

`ItemApplicationListUserAuth`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UserId` | `string` | Optional | Account username. |
| `FiUsernameHash` | `string` | Optional | Account username hashed by FI. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "user_id": "user_id4",
  "fi_username_hash": "fi_username_hash2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

