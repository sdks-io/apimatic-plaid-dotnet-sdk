
# Transfer Authorization Proposed Transfer

Details regarding the proposed transfer.

*This model accepts additional fields of type object.*

## Structure

`TransferAuthorizationProposedTransfer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AchClass` | [`AchClass`](../../doc/models/ach-class.md) | Required | Specifies the use case of the transfer.  Required for transfers on an ACH network.<br><br>`"arc"` - Accounts Receivable Entry<br><br>`"cbr`" - Cross Border Entry<br><br>`"ccd"` - Corporate Credit or Debit - fund transfer between two corporate bank accounts<br><br>`"cie"` - Customer Initiated Entry<br><br>`"cor"` - Automated Notification of Change<br><br>`"ctx"` - Corporate Trade Exchange<br><br>`"iat"` - International<br><br>`"mte"` - Machine Transfer Entry<br><br>`"pbr"` - Cross Border Entry<br><br>`"pop"` - Point-of-Purchase Entry<br><br>`"pos"` - Point-of-Sale Entry<br><br>`"ppd"` - Prearranged Payment or Deposit - the transfer is part of a pre-existing relationship with a consumer, eg. bill payment<br><br>`"rck"` - Re-presented Check Entry<br><br>`"tel"` - Telephone-Initiated Entry<br><br>`"web"` - Internet-Initiated Entry - debits from a consumer’s account where their authorization is obtained over the Internet |
| `AccountId` | `string` | Required | The Plaid `account_id` for the account that will be debited or credited. |
| `Type` | [`TransferType1`](../../doc/models/transfer-type-1.md) | Required | The type of transfer. This will be either `debit` or `credit`.  A `debit` indicates a transfer of money into the origination account; a `credit` indicates a transfer of money out of the origination account. |
| `User` | [`TransferUserInResponse`](../../doc/models/transfer-user-in-response.md) | Required | The legal name and other information for the account holder. |
| `Amount` | `string` | Required | The amount of the transfer (decimal string with two digits of precision e.g. “10.00”). |
| `Network` | `string` | Required | The network or rails used for the transfer. |
| `OriginationAccountId` | `string` | Required | Plaid's unique identifier for the origination account that was used for this transfer. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "ach_class": "web",
  "account_id": "account_id0",
  "type": "debit",
  "user": {
    "legal_name": "legal_name8",
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
  },
  "amount": "amount0",
  "network": "network4",
  "origination_account_id": "origination_account_id8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

