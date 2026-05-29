
# Payment Initiation Payment Reverse Request

PaymentInitiationPaymentReverseRequest defines the request schema for `/payment_initiation/payment/reverse`

*This model accepts additional fields of type object.*

## Structure

`PaymentInitiationPaymentReverseRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `PaymentId` | `string` | Required | The ID of the payment to reverse<br><br>**Constraints**: *Minimum Length*: `1` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "client_id": "client_id4",
  "secret": "secret2",
  "payment_id": "payment_id2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

