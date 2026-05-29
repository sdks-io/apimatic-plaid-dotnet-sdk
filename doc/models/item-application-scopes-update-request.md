
# Item Application Scopes Update Request

ItemApplicationScopesUpdateRequest defines the request schema for `/item/application/scopes/update`

*This model accepts additional fields of type object.*

## Structure

`ItemApplicationScopesUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `AccessToken` | `string` | Required | The access token associated with the Item data is being requested for. |
| `ApplicationId` | `string` | Required | This field will map to the application ID that is returned from /item/applications/list, or provided to the institution in an oauth redirect. |
| `Scopes` | [`Scopes`](../../doc/models/scopes.md) | Required | The scopes object |
| `State` | `string` | Optional | When scopes are updated during enrollment, this field must be populated with the state sent to the partner in the OAuth Login URI. This field is required when the context is `ENROLLMENT`. |
| `Context` | [`ScopesContext`](../../doc/models/scopes-context.md) | Required | An indicator for when scopes are being updated. When scopes are updated via enrollment (i.e. OAuth), the partner must send `ENROLLMENT`. When scopes are updated in a post-enrollment view, the partner must send `PORTAL`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "access_token": "access_token8",
  "application_id": "application_id4",
  "scopes": {
    "new_accounts": true,
    "product_access": {
      "statements": false,
      "identity": false,
      "auth": false,
      "transactions": false,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "accounts": [
      {
        "unique_id": "unique_id6",
        "authorized": false,
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      {
        "unique_id": "unique_id6",
        "authorized": false,
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    ],
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "context": "ENROLLMENT",
  "client_id": "client_id2",
  "secret": "secret4",
  "state": "state4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

