
# Transactions Refresh Request

TransactionsRefreshRequest defines the request schema for `/transactions/refresh`

*This model accepts additional fields of type object.*

## Structure

`TransactionsRefreshRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `AccessToken` | `string` | Required | The access token associated with the Item data is being requested for. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "client_id": "client_id0",
  "access_token": "access_token6",
  "secret": "secret6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

