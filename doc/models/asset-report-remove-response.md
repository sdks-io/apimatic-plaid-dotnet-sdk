
# Asset Report Remove Response

AssetReportRemoveResponse defines the response schema for `/asset_report/remove`

*This model accepts additional fields of type object.*

## Structure

`AssetReportRemoveResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Removed` | `bool` | Required | `true` if the Asset Report was successfully removed. |
| `RequestId` | `string` | Required | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "removed": false,
  "request_id": "request_id6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

