
# Sandbox Processor Token Create Response

*This model accepts additional fields of type object.*

## Structure

`SandboxProcessorTokenCreateResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProcessorToken` | `string` | Required | A processor token that can be used to call the `/processor/` endpoints. |
| `RequestId` | `string` | Required | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "processor_token": "processor_token4",
  "request_id": "request_id2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

