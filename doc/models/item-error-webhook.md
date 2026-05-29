
# Item Error Webhook

Fired when an error is encountered with an Item. The error can be resolved by having the user go through Link’s update mode.

*This model accepts additional fields of type object.*

## Structure

`ItemErrorWebhook`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WebhookType` | `string` | Required | `ITEM` |
| `WebhookCode` | `string` | Required | `ERROR` |
| `ItemId` | `string` | Required | The `item_id` of the Item associated with this webhook, warning, or error |
| `Error` | [`Error`](../../doc/models/error.md) | Required | We use standard HTTP response codes for success and failure notifications, and our errors are further classified by `error_type`. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues.  Error fields will be `null` if no error has occurred. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "webhook_type": "webhook_type2",
  "webhook_code": "webhook_code8",
  "item_id": "item_id2",
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
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

