
# Deposit Switch Target Account

*This model accepts additional fields of type object.*

## Structure

`DepositSwitchTargetAccount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountNumber` | `string` | Required | Account number for deposit switch destination |
| `RoutingNumber` | `string` | Required | Routing number for deposit switch destination |
| `AccountName` | `string` | Required | The name of the deposit switch destination account, as it will be displayed to the end user in the Deposit Switch interface. It is not required to match the name used in online banking. |
| `AccountSubtype` | [`AccountSubtype1`](../../doc/models/account-subtype-1.md) | Required | The account subtype of the account, either `checking` or `savings`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "account_number": "account_number6",
  "routing_number": "routing_number0",
  "account_name": "account_name4",
  "account_subtype": "checking",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

