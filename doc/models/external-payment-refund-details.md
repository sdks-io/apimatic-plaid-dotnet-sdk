
# External Payment Refund Details

*This model accepts additional fields of type object.*

## Structure

`ExternalPaymentRefundDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The name of the account holder. |
| `Iban` | `string` | Required | The International Bank Account Number (IBAN) for the account. |
| `Bacs` | [`RecipientBacsNullable`](../../doc/models/recipient-bacs-nullable.md) | Required | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "iban": "iban4",
  "bacs": {
    "account": "account4",
    "sort_code": "sort_code4",
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

