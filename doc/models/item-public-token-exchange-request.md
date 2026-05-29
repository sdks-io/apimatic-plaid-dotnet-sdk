
# Item Public Token Exchange Request

ItemPublicTokenExchangeRequest defines the request schema for `/item/public_token/exchange`

*This model accepts additional fields of type object.*

## Structure

`ItemPublicTokenExchangeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `PublicToken` | `string` | Required | Your `public_token`, obtained from the Link `onSuccess` callback or `/sandbox/item/public_token/create`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "client_id": "client_id8",
  "secret": "secret8",
  "public_token": "public_token8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

