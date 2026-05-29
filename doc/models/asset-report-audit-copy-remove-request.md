
# Asset Report Audit Copy Remove Request

AssetReportAuditCopyRemoveRequest defines the request schema for `/asset_report/audit_copy/remove`

*This model accepts additional fields of type object.*

## Structure

`AssetReportAuditCopyRemoveRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `AuditCopyToken` | `string` | Required | The `audit_copy_token` granting access to the Audit Copy you would like to revoke. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "client_id": "client_id2",
  "secret": "secret4",
  "audit_copy_token": "audit_copy_token2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

