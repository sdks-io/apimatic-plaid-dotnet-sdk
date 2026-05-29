
# Payment Initiation Recipient List Response

PaymentInitiationRecipientListResponse defines the response schema for `/payment_initiation/recipient/list`

*This model accepts additional fields of type object.*

## Structure

`PaymentInitiationRecipientListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Recipients` | [`List<PaymentInitiationRecipient>`](../../doc/models/payment-initiation-recipient.md) | Required | An array of payment recipients created for Payment Initiation |
| `RequestId` | `string` | Required | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "recipients": [
    {
      "recipient_id": "recipient_id4",
      "name": "name6",
      "address": {
        "street": [
          "street1"
        ],
        "city": "city6",
        "postal_code": "postal_code8",
        "country": "country0",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "iban": "iban0",
      "bacs": {
        "account": "account4",
        "sort_code": "sort_code4",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "emi_recipient_id": "emi_recipient_id6",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "request_id": "request_id2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

