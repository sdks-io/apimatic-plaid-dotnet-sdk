
# Transactions Removed Webhook

Fired when transaction(s) for an Item are deleted. The deleted transaction IDs are included in the webhook payload. Plaid will typically check for deleted transaction data several times a day.

*This model accepts additional fields of type object.*

## Structure

`TransactionsRemovedWebhook`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WebhookType` | `string` | Required | `TRANSACTIONS` |
| `WebhookCode` | `string` | Required | `TRANSACTIONS_REMOVED` |
| `Error` | [`Error`](../../doc/models/error.md) | Optional | We use standard HTTP response codes for success and failure notifications, and our errors are further classified by `error_type`. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues.  Error fields will be `null` if no error has occurred. |
| `RemovedTransactions` | `List<string>` | Required | An array of `transaction_ids` corresponding to the removed transactions |
| `ItemId` | `string` | Required | The `item_id` of the Item associated with this webhook, warning, or error |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "webhook_type": "webhook_type8",
  "webhook_code": "webhook_code2",
  "error": {
    "error_type": "RECAPTCHA_ERROR",
    "error_code": "error_code6",
    "error_message": "error_message6",
    "display_message": "display_message8",
    "request_id": "request_id4",
    "causes": [
      {
        "key1": "val1",
        "key2": "val2"
      },
      {
        "key1": "val1",
        "key2": "val2"
      },
      {
        "key1": "val1",
        "key2": "val2"
      }
    ],
    "status": 217.06,
    "documentation_url": "documentation_url6",
    "suggested_action": "suggested_action0",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "removed_transactions": [
    "removed_transactions3"
  ],
  "item_id": "item_id6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

