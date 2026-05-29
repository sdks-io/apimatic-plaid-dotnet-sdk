
# Numbers Eft

Identifying information for transferring money to or from a Canadian bank account via EFT.

*This model accepts additional fields of type object.*

## Structure

`NumbersEft`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `string` | Required | The Plaid account ID associated with the account numbers |
| `Account` | `string` | Required | The EFT account number for the account |
| `Institution` | `string` | Required | The EFT institution number for the account |
| `Branch` | `string` | Required | The EFT branch number for the account |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "account_id": "account_id8",
  "account": "account6",
  "institution": "institution6",
  "branch": "branch2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

