
# Income Verification Create Response

IncomeVerificationCreateResponse defines the response schema for `/income/verification/create`.

*This model accepts additional fields of type object.*

## Structure

`IncomeVerificationCreateResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IncomeVerificationId` | `string` | Required | ID of the verification. This ID is persisted throughout the lifetime of the verification. |
| `RequestId` | `string` | Required | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "income_verification_id": "income_verification_id0",
  "request_id": "request_id6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

