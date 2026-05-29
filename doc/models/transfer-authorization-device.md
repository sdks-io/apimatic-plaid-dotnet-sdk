
# Transfer Authorization Device

Information about the device being used to initiate the authorization.

*This model accepts additional fields of type object.*

## Structure

`TransferAuthorizationDevice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IpAddress` | `string` | Optional | The IP address of the device being used to initiate the authorization. |
| `UserAgent` | `string` | Optional | The user agent of the device being used to initiate the authorization. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "ip_address": "ip_address6",
  "user_agent": "user_agent8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

