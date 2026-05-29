
# Link Token Create Request Deposit Switch

Specifies options for initializing Link for use with the Deposit Switch (beta) product. This field is required if `deposit_switch` is included in the `products` array.

*This model accepts additional fields of type object.*

## Structure

`LinkTokenCreateRequestDepositSwitch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DepositSwitchId` | `string` | Required | The `deposit_switch_id` provided by the `/deposit_switch/create` endpoint. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "deposit_switch_id": "deposit_switch_id0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

