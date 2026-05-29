
# Account Access

Allow or disallow product access by account. Unlisted (e.g. missing) accounts will be considered `new_accounts`.

*This model accepts additional fields of type object.*

## Structure

`AccountAccess`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UniqueId` | `string` | Required | The unique account identifier for this account. This value must match that returned by the data access API for this account. |
| `Authorized` | `bool?` | Optional | Allow the application to see this account (and associated details, including balance) in the list of accounts. If unset, defaults to `true`.<br><br>**Default**: `true` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "unique_id": "unique_id6",
  "authorized": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

