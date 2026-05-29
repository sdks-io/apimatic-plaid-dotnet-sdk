
# Bank Transfers Events Update Webhook

Fired when new bank transfer events are available. Receiving this webhook indicates you should fetch the new events from `/bank_transfer/event/sync`.

*This model accepts additional fields of type object.*

## Structure

`BankTransfersEventsUpdateWebhook`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WebhookType` | `string` | Required | `BANK_TRANSFERS` |
| `WebhookCode` | `string` | Required | `BANK_TRANSFERS_EVENTS_UPDATE` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "webhook_type": "webhook_type0",
  "webhook_code": "webhook_code0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

