
# Link Token Eu Config

Configuration parameters for EU flows

*This model accepts additional fields of type object.*

## Structure

`LinkTokenEuConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Headless` | `bool?` | Optional | If `true`, open Link without an initial UI. Defaults to `false`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "headless": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

