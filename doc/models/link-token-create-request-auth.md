
# Link Token Create Request Auth

Specifies options for initializing Link for use with the Auth product. This field is currently only required if using the Flexible Auth product (currently in closed beta).

*This model accepts additional fields of type object.*

## Structure

`LinkTokenCreateRequestAuth`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FlowType` | `string` | Required | The optional Auth flow to use. Currently only used to enable Flexible Auth. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "flow_type": "FLEXIBLE_AUTH",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

