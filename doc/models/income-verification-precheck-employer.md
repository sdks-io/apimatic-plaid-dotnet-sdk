
# Income Verification Precheck Employer

*This model accepts additional fields of type object.*

## Structure

`IncomeVerificationPrecheckEmployer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | The employer's name |
| `TaxId` | `string` | Optional | The employer's tax id |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name2",
  "tax_id": "tax_id2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

