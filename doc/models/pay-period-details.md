
# Pay Period Details

Details about the pay period.

*This model accepts additional fields of type object.*

## Structure

`PayPeriodDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartDate` | `DateTime?` | Required | The pay period start date, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format: "yyyy-mm-dd". |
| `EndDate` | `DateTime?` | Required | The pay period end date, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format: "yyyy-mm-dd". |
| `PayDay` | `DateTime?` | Required | The date on which the paystub was issued, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ("yyyy-mm-dd"). |
| `GrossEarnings` | `double?` | Required | Total earnings before tax. |
| `CheckAmount` | `double?` | Required | The net amount of the paycheck. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "start_date": "2016-03-13",
  "end_date": "2016-03-13",
  "pay_day": "2016-03-13",
  "gross_earnings": 169.08,
  "check_amount": 244.9,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

