
# Meta

Allows specifying the metadata of the test account

*This model accepts additional fields of type object.*

## Structure

`Meta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The account's name |
| `OfficialName` | `string` | Required | The account's official name |
| `Limit` | `double` | Required | The account's limit |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name8",
  "official_name": "official_name0",
  "limit": 109.44,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

