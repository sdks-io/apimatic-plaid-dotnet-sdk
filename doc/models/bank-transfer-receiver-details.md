
# Bank Transfer Receiver Details

The receiver details if the type of this event is `reciever_pending` or `reciever_posted`. Null value otherwise.

*This model accepts additional fields of type object.*

## Structure

`BankTransferReceiverDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AvailableBalance` | [`AvailableBalance`](../../doc/models/available-balance.md) | Required | The sign of the available balance for the receiver bank account associated with the receiver event at the time the matching transaction was found. Can be `positive`, `negative`, or null if the balance was not available at the time. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "available_balance": "positive",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

