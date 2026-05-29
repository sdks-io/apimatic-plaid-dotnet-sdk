
# Sell Type

Selling an investment

*This model accepts additional fields of type object.*

## Structure

`SellType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Distribution` | `string` | Optional | Outflow of assets from a tax-advantaged account |
| `Exercise` | `string` | Optional | Exercise of an option or warrant contract |
| `Sell` | `string` | Optional | Sell to close or decrease an existing holding |
| `SellShort` | `string` | Optional | Sell to open a short position |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "distribution": "distribution8",
  "exercise": "exercise0",
  "sell": "sell0",
  "sell short": "sell short0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

