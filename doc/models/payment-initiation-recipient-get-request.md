
# Payment Initiation Recipient Get Request

PaymentInitiationRecipientGetRequest defines the request schema for `/payment_initiation/recipient/get`

*This model accepts additional fields of type object.*

## Structure

`PaymentInitiationRecipientGetRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `RecipientId` | `string` | Required | The ID of the recipient<br><br>**Constraints**: *Minimum Length*: `1` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "client_id": "client_id8",
  "secret": "secret8",
  "recipient_id": "recipient_id4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

