
# Credit Card Liability

An object representing a credit card account.

*This model accepts additional fields of type object.*

## Structure

`CreditCardLiability`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `string` | Required | The ID of the account that this liability belongs to. |
| `Aprs` | [`List<Apr>`](../../doc/models/apr.md) | Required | The various interest rates that apply to the account. |
| `IsOverdue` | `bool?` | Required | true if a payment is currently overdue. Availability for this field is limited. |
| `LastPaymentAmount` | `double` | Required | The amount of the last payment. |
| `LastPaymentDate` | `DateTime` | Required | The date of the last payment. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). Availability for this field is limited. |
| `LastStatementIssueDate` | `DateTime` | Required | The date of the last statement. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). |
| `MinimumPaymentAmount` | `double` | Required | The minimum payment due for the next billing cycle. |
| `NextPaymentDueDate` | `DateTime?` | Required | The due date for the next payment. The due date is `null` if a payment is not expected. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "account_id": "account_id4",
  "aprs": [
    {
      "apr_percentage": 185.0,
      "apr_type": "balance_transfer_apr",
      "balance_subject_to_apr": 23.44,
      "interest_charge_amount": 112.32,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "is_overdue": false,
  "last_payment_amount": 189.28,
  "last_payment_date": "2016-03-13",
  "last_statement_issue_date": "2016-03-13",
  "minimum_payment_amount": 48.26,
  "next_payment_due_date": "2016-03-13",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

