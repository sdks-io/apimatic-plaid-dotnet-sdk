
# Income Verification Precheck Response

IncomeVerificationPrecheckResponse defines the response schema for `/income/verification/precheck`.

*This model accepts additional fields of type object.*

## Structure

`IncomeVerificationPrecheckResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PrecheckId` | `string` | Required | ID of the precheck. |
| `RequestId` | `string` | Required | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. |
| `Confidence` | [`Confidence`](../../doc/models/confidence.md) | Required | The confidence that Plaid can support the user in the income verification flow. One of the following:<br><br>`"HIGH"`: This precheck information submitted is definitively tied to a Plaid-supported integration.<br><br>"`LOW`": This precheck information submitted is known not to be supported by Plaid.<br><br>`"UNKNOWN"`: It was not possible to determine if the user is supportable with the information passed. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "precheck_id": "precheck_id6",
  "request_id": "request_id4",
  "confidence": "UNKNOWN",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

