
# Personal Finance Category 2

*This model accepts additional fields of type object.*

## Structure

`PersonalFinanceCategory2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Primary` | `string` | Required | A high level category that communicates the broad category of the transaction. |
| `Detailed` | `string` | Required | Provides additional granularity to the primary categorization. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "primary": "primary6",
  "detailed": "detailed6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

