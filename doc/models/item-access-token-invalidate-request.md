
# Item Access Token Invalidate Request

ItemAccessTokenInvalidateRequest defines the request schema for `/item/access_token/invalidate`

*This model accepts additional fields of type object.*

## Structure

`ItemAccessTokenInvalidateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `AccessToken` | `string` | Required | The access token associated with the Item data is being requested for. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "client_id": "client_id4",
  "secret": "secret8",
  "access_token": "access_token0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

