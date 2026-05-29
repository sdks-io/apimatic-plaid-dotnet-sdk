
# Numbers Bacs

Identifying information for transferring money to or from a UK bank account via BACS.

*This model accepts additional fields of type object.*

## Structure

`NumbersBacs`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `string` | Required | The Plaid account ID associated with the account numbers |
| `Account` | `string` | Required | The BACS account number for the account |
| `SortCode` | `string` | Required | The BACS sort code for the account |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "account_id": "account_id6",
  "account": "account4",
  "sort_code": "sort_code4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

