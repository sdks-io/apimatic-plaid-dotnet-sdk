
# Institutions Search Account Filter

*This model accepts additional fields of type object.*

## Structure

`InstitutionsSearchAccountFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Loan` | [`List<AccountSubtype>`](../../doc/models/account-subtype.md) | Optional | - |
| `Depository` | [`List<AccountSubtype>`](../../doc/models/account-subtype.md) | Optional | - |
| `Credit` | [`List<AccountSubtype>`](../../doc/models/account-subtype.md) | Optional | - |
| `Investment` | [`List<AccountSubtype>`](../../doc/models/account-subtype.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "loan": [
    "cd",
    "paypal"
  ],
  "depository": [
    "retirement",
    "roth",
    "roth 401k"
  ],
  "credit": [
    "rrsp",
    "sep ira"
  ],
  "investment": [
    "construction"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

