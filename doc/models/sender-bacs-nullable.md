
# Sender Bacs Nullable

*This model accepts additional fields of type object.*

## Structure

`SenderBacsNullable`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Account` | `string` | Optional | The account number of the account. Maximum of 10 characters.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `10` |
| `SortCode` | `string` | Optional | The 6-character sort code of the account.<br><br>**Constraints**: *Minimum Length*: `6`, *Maximum Length*: `6` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "account": "account6",
  "sort_code": "sort_code6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

