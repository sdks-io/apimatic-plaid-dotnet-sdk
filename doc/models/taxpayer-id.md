
# Taxpayer Id

*This model accepts additional fields of type object.*

## Structure

`TaxpayerId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IdType` | `string` | Optional | Type of ID, e.g. 'SSN' |
| `Last4Digits` | `string` | Optional | Last 4 digits of unique number of ID.<br><br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `4` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "id_type": "id_type4",
  "last_4_digits": "last_4_digits0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

