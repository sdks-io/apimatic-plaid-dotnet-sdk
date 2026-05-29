
# Transfer User in Response

The legal name and other information for the account holder.

*This model accepts additional fields of type object.*

## Structure

`TransferUserInResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LegalName` | `string` | Required | The user's legal name. |
| `PhoneNumber` | `string` | Required | The user's phone number. |
| `EmailAddress` | `string` | Required | The user's email address. |
| `Address` | [`TransferUserAddressInResponse`](../../doc/models/transfer-user-address-in-response.md) | Required | The address associated with the account holder. |
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

