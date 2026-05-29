
# Asset Report Filter Request

AssetReportFilterRequest defines the request schema for `/asset_report/filter`

*This model accepts additional fields of type object.*

## Structure

`AssetReportFilterRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `AssetReportToken` | `string` | Required | A token that can be provided to endpoints such as `/asset_report/get` or `/asset_report/pdf/get` to fetch or update an Asset Report. |
| `AccountIdsToExclude` | `List<string>` | Required | The accounts to exclude from the Asset Report, identified by `account_id`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "client_id": "client_id0",
  "secret": "secret6",
  "asset_report_token": "asset_report_token4",
  "account_ids_to_exclude": [
    "account_ids_to_exclude9",
    "account_ids_to_exclude0",
    "account_ids_to_exclude1"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

