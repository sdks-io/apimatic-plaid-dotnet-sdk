
# Item Status Nullable

*This model accepts additional fields of type object.*

## Structure

`ItemStatusNullable`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Investments` | [`ItemStatusInvestments`](../../doc/models/item-status-investments.md) | Optional | Information about the last successful and failed investments update for the Item. |
| `Transactions` | [`ItemStatusTransactions`](../../doc/models/item-status-transactions.md) | Optional | Information about the last successful and failed transactions update for the Item. |
| `LastWebhook` | [`ItemStatusLastWebhook`](../../doc/models/item-status-last-webhook.md) | Optional | Information about the last webhook fired for the Item. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "investments": {
    "last_successful_update": "2016-03-13T12:52:32.123Z",
    "last_failed_update": "2016-03-13T12:52:32.123Z",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "transactions": {
    "last_successful_update": "2016-03-13T12:52:32.123Z",
    "last_failed_update": "2016-03-13T12:52:32.123Z",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "last_webhook": {
    "sent_at": "2016-03-13T12:52:32.123Z",
    "code_sent": "code_sent2",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

