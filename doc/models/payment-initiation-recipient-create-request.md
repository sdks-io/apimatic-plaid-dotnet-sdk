
# Payment Initiation Recipient Create Request

PaymentInitiationRecipientCreateRequest defines the request schema for `/payment_initiation/recipient/create`

*This model accepts additional fields of type object.*

## Structure

`PaymentInitiationRecipientCreateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `Name` | `string` | Required | The name of the recipient<br><br>**Constraints**: *Minimum Length*: `1` |
| `Iban` | `string` | Optional | The International Bank Account Number (IBAN) for the recipient. If BACS data is not provided, an IBAN is required.<br><br>**Constraints**: *Minimum Length*: `15`, *Maximum Length*: `34` |
| `Bacs` | [`RecipientBacsNullable`](../../doc/models/recipient-bacs-nullable.md) | Optional | - |
| `Address` | [`PaymentInitiationAddress`](../../doc/models/payment-initiation-address.md) | Optional | The optional address of the payment recipient. This object is not currently required to make payments from UK institutions and should not be populated, though may be necessary for future European expansion. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "client_id": "client_id6",
  "secret": "secret0",
  "name": "name4",
  "iban": "iban8",
  "bacs": {
    "account": "account4",
    "sort_code": "sort_code4",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
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
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

