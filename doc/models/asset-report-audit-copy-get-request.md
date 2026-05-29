
# Asset Report Audit Copy Get Request

AssetReportAuditCopyGetRequest defines the request schema for `/asset_report/audit_copy/get`

*This model accepts additional fields of type object.*

## Structure

`AssetReportAuditCopyGetRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `AuditCopyToken` | `string` | Required | The `audit_copy_token` granting access to the Audit Copy you would like to get. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "client_id": "client_id8",
  "secret": "secret2",
  "audit_copy_token": "audit_copy_token4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

