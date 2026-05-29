
# Transfer User in Request

The legal name and other information for the account holder.

*This model accepts additional fields of type object.*

## Structure

`TransferUserInRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LegalName` | `string` | Required | The user's legal name. |
| `PhoneNumber` | `string` | Optional | The user's phone number. |
| `EmailAddress` | `string` | Optional | The user's email address. |
| `Address` | [`TransferUserAddressInRequest`](../../doc/models/transfer-user-address-in-request.md) | Optional | The address associated with the account holder. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "legal_name": "legal_name2",
  "phone_number": "phone_number2",
  "email_address": "email_address2",
  "address": {
    "street": "street6",
    "city": "city6",
    "region": "region2",
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

