
# Pay

An object representing a monetary amount.

*This model accepts additional fields of type object.*

## Structure

`Pay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `double?` | Optional | A numerical amount of a specific currency. |
| `Currency` | `string` | Optional | Currency code, e.g. USD<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "amount": 242.24,
  "currency": "currency2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

