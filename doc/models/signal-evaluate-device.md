
# Signal Evaluate Device

Details about the end user's device

*This model accepts additional fields of type object.*

## Structure

`SignalEvaluateDevice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IpAddress` | `string` | Optional | The IP address of the device that initiated the transaction |
| `UserAgent` | `string` | Optional | The user agent of the device that initiated the transaction (e.g. "Mozilla/5.0") |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "ip_address": "ip_address8",
  "user_agent": "user_agent0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

