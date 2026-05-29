
# Verification Expired Webhook

Fired when an Item was not verified via automated micro-deposits after ten days since the automated micro-deposit was made.

*This model accepts additional fields of type object.*

## Structure

`VerificationExpiredWebhook`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WebhookType` | `string` | Required | `AUTH` |
| `WebhookCode` | `string` | Required | `VERIFICATION_EXPIRED` |
| `ItemId` | `string` | Required | The `item_id` of the Item associated with this webhook, warning, or error |
| `AccountId` | `string` | Required | The `account_id` of the account associated with the webhook |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "webhook_type": "webhook_type0",
  "webhook_code": "webhook_code0",
  "item_id": "item_id4",
  "account_id": "account_id8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

