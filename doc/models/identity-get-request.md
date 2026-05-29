
# Identity Get Request

IdentityGetRequest defines the request schema for `/identity/get`

*This model accepts additional fields of type object.*

## Structure

`IdentityGetRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `AccessToken` | `string` | Required | The access token associated with the Item data is being requested for. |
| `Options` | [`IdentityGetRequestOptions`](../../doc/models/identity-get-request-options.md) | Optional | An optional object to filter `/identity/get` results. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "client_id": "client_id8",
  "secret": "secret8",
  "access_token": "access_token4",
  "options": {
    "account_ids": [
      "account_ids3",
      "account_ids4",
      "account_ids5"
    ],
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

