
# Asset Report Refresh Response

AssetReportRefreshResponse defines the response schema for `/asset_report/refresh`

*This model accepts additional fields of type object.*

## Structure

`AssetReportRefreshResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AssetReportId` | `string` | Required | A unique ID identifying an Asset Report. Like all Plaid identifiers, this ID is case sensitive. |
| `AssetReportToken` | `string` | Required | A token that can be provided to endpoints such as `/asset_report/get` or `/asset_report/pdf/get` to fetch or update an Asset Report. |
| `RequestId` | `string` | Required | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "asset_report_id": "asset_report_id4",
  "asset_report_token": "asset_report_token0",
  "request_id": "request_id6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

