
# Buy Type

Buying an investment

*This model accepts additional fields of type object.*

## Structure

`BuyType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Assignment` | `string` | Optional | Assignment of short option holding |
| `Contribution` | `string` | Optional | Inflow of assets into a tax-advantaged account |
| `Buy` | `string` | Optional | Purchase to open or increase a position |
| `BuyToCover` | `string` | Optional | Purchase to close a short position |
| `DividendReinvestment` | `string` | Optional | Purchase using proceeds from a cash dividend |
| `InterestReinvestment` | `string` | Optional | Purchase using proceeds from a cash interest payment |
| `LongTermCapitalGainReinvestment` | `string` | Optional | Purchase using long-term capital gain cash proceeds |
| `ShortTermCapitalGainReinvestment` | `string` | Optional | Purchase using short-term capital gain cash proceeds |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "assignment": "assignment8",
  "contribution": "contribution2",
  "buy": "buy6",
  "buy to cover": "buy to cover8",
  "dividend reinvestment": "dividend reinvestment2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

