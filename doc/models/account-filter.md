
# Account Filter

Enumerates the account subtypes that the application wishes for the user to be able to select from. For more details refer to Plaid documentation on account filters.

*This model accepts additional fields of type object.*

## Structure

`AccountFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Depository` | `List<string>` | Optional | A list of account subtypes to be filtered. |
| `Credit` | `List<string>` | Optional | A list of account subtypes to be filtered. |
| `Loan` | `List<string>` | Optional | A list of account subtypes to be filtered. |
| `Investment` | `List<string>` | Optional | A list of account subtypes to be filtered. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "depository": [
    "depository9"
  ],
  "credit": [
    "credit0",
    "credit1",
    "credit2"
  ],
  "loan": [
    "loan5",
    "loan4",
    "loan3"
  ],
  "investment": [
    "investment9",
    "investment0"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

