
# Item Application Scopes Update Response

ItemApplicationScopesUpdateResponse defines the response schema for `/item/application/scopes/update`

*This model accepts additional fields of type object.*

## Structure

`ItemApplicationScopesUpdateResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Required | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "request_id": "request_id0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

