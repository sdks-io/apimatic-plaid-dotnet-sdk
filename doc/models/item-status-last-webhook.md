
# Item Status Last Webhook

Information about the last webhook fired for the Item.

*This model accepts additional fields of type object.*

## Structure

`ItemStatusLastWebhook`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SentAt` | `DateTime?` | Optional | [ISO 8601](https://wikipedia.org/wiki/ISO_8601) timestamp of when the webhook was fired. |
| `CodeSent` | `string` | Optional | The last webhook code sent. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "sent_at": "2016-03-13T12:52:32.123Z",
  "code_sent": "code_sent0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

