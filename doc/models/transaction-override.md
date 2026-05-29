
# Transaction Override

Data to populate as test transaction data. If not specified, random transactions will be generated instead.

*This model accepts additional fields of type object.*

## Structure

`TransactionOverride`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DateTransacted` | `DateTime` | Required | The date of the transaction, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) (YYYY-MM-DD) format. Transaction dates in the past or present will result in posted transactions; transaction dates in the future will result in pending transactions. Transactions in Sandbox will move from pending to posted once their transaction date has been reached. |
| `DatePosted` | `DateTime` | Required | The date the transaction posted, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) (YYYY-MM-DD) format |
| `Amount` | `double` | Required | The transaction amount. Can be negative. |
| `Description` | `string` | Required | The transaction description. |
| `Currency` | `string` | Optional | The ISO-4217 format currency code for the transaction. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "date_transacted": "2016-03-13",
  "date_posted": "2016-03-13",
  "amount": 77.84,
  "description": "description2",
  "currency": "currency2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

