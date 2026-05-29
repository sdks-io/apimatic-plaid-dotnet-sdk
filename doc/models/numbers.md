
# Numbers

Account and bank identifier number data used to configure the test account. All values are optional.

*This model accepts additional fields of type object.*

## Structure

`Numbers`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Account` | `string` | Optional | Will be used for the account number. |
| `AchRouting` | `string` | Optional | Must be a valid ACH routing number. |
| `AchWireRouting` | `string` | Optional | Must be a valid wire transfer routing number. |
| `EftInstitution` | `string` | Optional | EFT institution number. Must be specified alongside `eft_branch`. |
| `EftBranch` | `string` | Optional | EFT branch number. Must be specified alongside `eft_institution`. |
| `InternationalBic` | `string` | Optional | Bank identifier code (BIC). Must be specified alongside `international_iban`. |
| `InternationalIban` | `string` | Optional | International bank account number (IBAN). If no account number is specified via `account`, will also be used as the account number by default. Must be specified alongside `international_bic`. |
| `BacsSortCode` | `string` | Optional | BACS sort code |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "account": "account6",
  "ach_routing": "ach_routing6",
  "ach_wire_routing": "ach_wire_routing6",
  "eft_institution": "eft_institution8",
  "eft_branch": "eft_branch0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

