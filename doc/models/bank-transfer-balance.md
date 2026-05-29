
# Bank Transfer Balance

*This model accepts additional fields of type object.*

## Structure

`BankTransferBalance`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Available` | `string` | Required | The total available balance - the sum of all successful debit transfer amounts minus all credit transfer amounts. |
| `Transactable` | `string` | Required | The transactable balance shows the amount in your account that you are able to use for transfers, and is essentially your available balance minus your minimum balance. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "available": "available2",
  "transactable": "transactable2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

