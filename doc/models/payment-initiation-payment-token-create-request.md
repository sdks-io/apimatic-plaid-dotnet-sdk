
# Payment Initiation Payment Token Create Request

PaymentInitiationPaymentTokenCreateRequest defines the request schema for `/payment_initiation/payment/token/create`

*This model accepts additional fields of type object.*

## Structure

`PaymentInitiationPaymentTokenCreateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `PaymentId` | `string` | Required | The `payment_id` returned from `/payment_initiation/payment/create`.<br><br>**Constraints**: *Minimum Length*: `1` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "client_id": "client_id8",
  "secret": "secret8",
  "payment_id": "payment_id6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

