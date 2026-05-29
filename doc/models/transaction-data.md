
# Transaction Data

Information about the matched direct deposit transaction used to verify a user's payroll information.

*This model accepts additional fields of type object.*

## Structure

`TransactionData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Required | The description of the transaction. |
| `Amount` | `double` | Required | The amount of the transaction. |
| `Date` | `DateTime` | Required | The date of the transaction, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ("yyyy-mm-dd"). |
| `AccountId` | `string` | Required | A unique identifier for the end user's account. |
| `TransactionId` | `string` | Required | A unique identifier for the transaction. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "description": "description2",
  "amount": 102.84,
  "date": "2016-03-13",
  "account_id": "account_id4",
  "transaction_id": "transaction_id0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

