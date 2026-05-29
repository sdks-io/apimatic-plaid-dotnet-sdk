
# Bank Transfer Balance Get Request

Defines the request schema for `/bank_transfer/balance/get`

*This model accepts additional fields of type object.*

## Structure

`BankTransferBalanceGetRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `OriginationAccountId` | `string` | Optional | If multiple origination accounts are available, `origination_account_id` must be used to specify the account for which balance will be returned. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "client_id": "client_id2",
  "secret": "secret4",
  "origination_account_id": "origination_account_id0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

