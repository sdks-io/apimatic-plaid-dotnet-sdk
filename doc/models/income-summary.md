
# Income Summary

The verified fields from a paystub verification. All fields are provided as reported on the paystub.

*This model accepts additional fields of type object.*

## Structure

`IncomeSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EmployerName` | [`EmployerIncomeSummaryFieldString`](../../doc/models/employer-income-summary-field-string.md) | Required | - |
| `EmployeeName` | [`EmployeeIncomeSummaryFieldString`](../../doc/models/employee-income-summary-field-string.md) | Required | - |
| `YtdGrossIncome` | [`YtdGrossIncomeSummaryFieldNumber`](../../doc/models/ytd-gross-income-summary-field-number.md) | Required | - |
| `YtdNetIncome` | [`YtdNetIncomeSummaryFieldNumber`](../../doc/models/ytd-net-income-summary-field-number.md) | Required | - |
| `PayFrequency` | [`PayFrequency`](../../doc/models/pay-frequency.md) | Required | - |
| `ProjectedWage` | [`ProjectedIncomeSummaryFieldNumber`](../../doc/models/projected-income-summary-field-number.md) | Required | - |
| `VerifiedTransaction` | [`TransactionData`](../../doc/models/transaction-data.md) | Required | Information about the matched direct deposit transaction used to verify a user's payroll information. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "employer_name": {
    "value": "value8",
    "verification_status": "UNKNOWN",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "employee_name": {
    "value": "value4",
    "verification_status": "UNABLE_TO_VERIFY",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "ytd_gross_income": {
    "value": 80.36,
    "verification_status": "UNKNOWN",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "ytd_net_income": {
    "value": 101.8,
    "verification_status": "UNABLE_TO_VERIFY",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "pay_frequency": {
    "value": "monthly",
    "verification_status": "UNABLE_TO_VERIFY",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "projected_wage": {
    "value": 108.54,
    "verification_status": "NEEDS_INFO",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "verified_transaction": {
    "description": "description8",
    "amount": 228.3,
    "date": "2016-03-13",
    "account_id": "account_id0",
    "transaction_id": "transaction_id6",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

