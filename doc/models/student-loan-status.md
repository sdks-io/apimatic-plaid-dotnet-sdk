
# Student Loan Status

An object representing the status of the student loan

*This model accepts additional fields of type object.*

## Structure

`StudentLoanStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EndDate` | `DateTime?` | Required | The date until which the loan will be in its current status. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). |
| `Type` | [`Type2`](../../doc/models/type-2.md) | Required | The status type of the student loan |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "end_date": "2016-03-13",
  "type": "paid in full",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

