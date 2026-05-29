
# Income Verification Refresh Response

IncomeVerificationRequestResponse defines the response schema for `/income/verification/refresh`

*This model accepts additional fields of type object.*

## Structure

`IncomeVerificationRefreshResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Required | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. |
| `VerificationRefreshStatus` | `string` | Required | The verification refresh status. One of the following:<br><br>`"VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED"` User presence is required to refresh an income verification. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "request_id": "request_id8",
  "verification_refresh_status": "VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

