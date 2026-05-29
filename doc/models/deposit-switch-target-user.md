
# Deposit Switch Target User

*This model accepts additional fields of type object.*

## Structure

`DepositSwitchTargetUser`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `GivenName` | `string` | Required | The given name (first name) of the user. |
| `FamilyName` | `string` | Required | The family name (last name) of the user. |
| `Phone` | `string` | Required | The phone number of the user. The endpoint can accept a variety of phone number formats, including E.164. |
| `Email` | `string` | Required | The email address of the user. |
| `Address` | [`DepositSwitchAddressData`](../../doc/models/deposit-switch-address-data.md) | Optional | The user's address. |
| `TaxPayerId` | `string` | Optional | The taxpayer ID of the user, generally their SSN, EIN, or TIN. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "given_name": "given_name8",
  "family_name": "family_name0",
  "phone": "phone4",
  "email": "email0",
  "address": {
    "city": "city6",
    "region": "region2",
    "street": "street6",
    "postal_code": "postal_code8",
    "country": "country0",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "tax_payer_id": "tax_payer_id4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

