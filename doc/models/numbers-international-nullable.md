
# Numbers International Nullable

*This model accepts additional fields of type object.*

## Structure

`NumbersInternationalNullable`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `string` | Required | The Plaid account ID associated with the account numbers |
| `Iban` | `string` | Required | The International Bank Account Number (IBAN) for the account |
| `Bic` | `string` | Required | The Bank Identifier Code (BIC) for the account |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "account_id": "account_id2",
  "iban": "iban4",
  "bic": "bic2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

