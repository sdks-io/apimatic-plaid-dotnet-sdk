
# Sandbox Public Token Create Request Options Transactions

SandboxPublicTokenCreateRequestOptionsTransactions is an optional set of parameters corresponding to transactions options.

*This model accepts additional fields of type object.*

## Structure

`SandboxPublicTokenCreateRequestOptionsTransactions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartDate` | `DateTime?` | Optional | The earliest date for which to fetch transaction history. Dates should be formatted as YYYY-MM-DD. |
| `EndDate` | `DateTime?` | Optional | The most recent date for which to fetch transaction history. Dates should be formatted as YYYY-MM-DD. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "start_date": "2016-03-13",
  "end_date": "2016-03-13",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

