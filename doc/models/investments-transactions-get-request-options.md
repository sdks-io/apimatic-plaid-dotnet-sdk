
# Investments Transactions Get Request Options

An optional object to filter `/investments/transactions/get` results. If provided, must be non-`null`.

*This model accepts additional fields of type object.*

## Structure

`InvestmentsTransactionsGetRequestOptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountIds` | `List<string>` | Optional | An array of `account_ids` to retrieve for the Item. |
| `Count` | `int?` | Optional | The number of transactions to fetch.<br><br>**Default**: `100`<br><br>**Constraints**: `>= 1`, `<= 500` |
| `Offset` | `int?` | Optional | The number of transactions to skip when fetching transaction history<br><br>**Default**: `0`<br><br>**Constraints**: `>= 0` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "count": 100,
  "offset": 0,
  "account_ids": [
    "account_ids7"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

