
# Paystub Details

An object representing details that can be found on the paystub.

*This model accepts additional fields of type object.*

## Structure

`PaystubDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PayPeriodStartDate` | `DateTime?` | Optional | Beginning date of the pay period on the paystub in the 'YYYY-MM-DD' format. |
| `PayPeriodEndDate` | `DateTime?` | Optional | Ending date of the pay period on the paystub in the 'YYYY-MM-DD' format. |
| `PayDate` | `DateTime?` | Optional | Pay date on the paystub in the 'YYYY-MM-DD' format. |
| `PaystubProvider` | `string` | Optional | The name of the payroll provider that generated the paystub, e.g. ADP |
| `PayFrequency` | [`PayFrequency1?`](../../doc/models/pay-frequency-1.md) | Optional | The frequency at which the employee is paid. Possible values: `MONTHLY`, `BI-WEEKLY`, `WEEKLY`, `SEMI-MONTHLY`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "pay_period_start_date": "2016-03-13",
  "pay_period_end_date": "2016-03-13",
  "pay_date": "2016-03-13",
  "paystub_provider": "paystub_provider8",
  "pay_frequency": "WEEKLY",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

