
# Payment Initiation Standing Order Metadata

Metadata specifically related to valid Payment Initiation standing order configurations for the institution.

*This model accepts additional fields of type object.*

## Structure

`PaymentInitiationStandingOrderMetadata`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SupportsStandingOrderEndDate` | `bool` | Required | Indicates whether the institution supports closed-ended standing orders by providing an end date. |
| `SupportsStandingOrderNegativeExecutionDays` | `bool` | Required | This is only applicable to `MONTHLY` standing orders. Indicates whether the institution supports negative integers (-1 to -5) for setting up a `MONTHLY` standing order relative to the end of the month. |
| `ValidStandingOrderIntervals` | [`List<PaymentScheduleInterval>`](../../doc/models/payment-schedule-interval.md) | Required | A list of the valid standing order intervals supported by the institution. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "supports_standing_order_end_date": false,
  "supports_standing_order_negative_execution_days": false,
  "valid_standing_order_intervals": [
    "WEEKLY"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

