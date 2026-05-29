
# Auth Get Request Options

An optional object to filter `/auth/get` results.

*This model accepts additional fields of type object.*

## Structure

`AuthGetRequestOptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountIds` | `List<string>` | Optional | A list of `account_ids` to retrieve for the Item.<br>Note: An error will be returned if a provided `account_id` is not associated with the Item. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "account_ids": [
    "account_ids7",
    "account_ids8"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

