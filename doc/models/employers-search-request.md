
# Employers Search Request

EmployersSearchRequest defines the request schema for `/employers/search`.

*This model accepts additional fields of type object.*

## Structure

`EmployersSearchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `Query` | `string` | Required | The employer name to be searched for. |
| `Products` | `List<string>` | Required | The Plaid products the returned employers should support. Currently, this field must be set to `"deposit_switch"`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "client_id": "client_id6",
  "secret": "secret0",
  "query": "query4",
  "products": [
    "products2",
    "products3",
    "products4"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

