
# Employment Details

An object representing employment details found on a paystub.

*This model accepts additional fields of type object.*

## Structure

`EmploymentDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AnnualSalary` | [`Pay`](../../doc/models/pay.md) | Optional | An object representing a monetary amount. |
| `HireDate` | `DateTime?` | Optional | Date on which the employee was hired, in the YYYY-MM-DD format. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "annual_salary": {
    "amount": 106.22,
    "currency": "currency0",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "hire_date": "2016-03-13",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

