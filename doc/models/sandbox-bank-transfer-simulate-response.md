
# Sandbox Bank Transfer Simulate Response

Defines the response schema for `/sandbox/bank_transfer/simulate`

*This model accepts additional fields of type object.*

## Structure

`SandboxBankTransferSimulateResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Required | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "request_id": "request_id2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

