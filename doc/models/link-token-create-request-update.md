
# Link Token Create Request Update

Specifies options for initializing Link for [update mode](https://plaid.com/docs/link/update-mode).

*This model accepts additional fields of type object.*

## Structure

`LinkTokenCreateRequestUpdate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountSelectionEnabled` | `bool?` | Optional | If `true`, enables [update mode with Account Select](https://plaid.com/docs/link/update-mode/#using-update-mode-to-request-new-accounts).<br><br>**Default**: `false` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "account_selection_enabled": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

