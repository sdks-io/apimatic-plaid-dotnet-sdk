
# Sandbox Item Fire Webhook Request

SandboxItemFireWebhookRequest defines the request schema for `/sandbox/item/fire_webhook`

*This model accepts additional fields of type object.*

## Structure

`SandboxItemFireWebhookRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `AccessToken` | `string` | Required | The access token associated with the Item data is being requested for. |
| `WebhookCode` | `string` | Required | The following values for `webhook_code` are supported:<br><br>* `DEFAULT_UPDATE` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "access_token": "access_token6",
  "webhook_code": "DEFAULT_UPDATE",
  "client_id": "client_id0",
  "secret": "secret6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

