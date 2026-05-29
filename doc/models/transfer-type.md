
# Transfer Type

Activity that modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer

*This model accepts additional fields of type object.*

## Structure

`TransferType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Assignment` | `string` | Optional | Assignment of short option holding |
| `Adjustment` | `string` | Optional | Increase or decrease in quantity of item |
| `Exercise` | `string` | Optional | Exercise of an option or warrant contract |
| `Expire` | `string` | Optional | Expiration of an option or warrant contract |
| `Merger` | `string` | Optional | Stock exchanged at a pre-defined ratio as part of a merger between companies |
| `SpinOff` | `string` | Optional | Inflow of stock from spin-off transaction of an existing holding |
| `Split` | `string` | Optional | Inflow of stock from a forward split of an existing holding |
| `Transfer` | `string` | Optional | Movement of assets into or out of an account |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "assignment": "assignment8",
  "adjustment": "adjustment6",
  "exercise": "exercise4",
  "expire": "expire4",
  "merger": "merger2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

