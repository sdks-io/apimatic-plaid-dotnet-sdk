
# Loan Account

A loan type account. Supported products for `loan` accounts are: Balance, Liabilities, and Transactions.

*This model accepts additional fields of type object.*

## Structure

`LoanAccount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Auto` | `string` | Required | Auto loan |
| `Business` | `string` | Required | Business loan |
| `Commercial` | `string` | Required | Commercial loan |
| `Construction` | `string` | Required | Construction loan |
| `Consumer` | `string` | Required | Consumer loan |
| `HomeEquity` | `string` | Required | Home Equity Line of Credit (HELOC) |
| `Loan` | `string` | Required | General loan |
| `Mortgage` | `string` | Required | Mortgage loan |
| `Overdraft` | `string` | Required | Pre-approved overdraft account, usually tied to a checking account |
| `LineOfCredit` | `string` | Required | Pre-approved line of credit |
| `Student` | `string` | Required | Student loan |
| `Other` | `string` | Required | Other loan type or unknown loan type |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "auto": "auto2",
  "business": "business4",
  "commercial": "commercial2",
  "construction": "construction2",
  "consumer": "consumer8",
  "home equity": "home equity4",
  "loan": "loan4",
  "mortgage": "mortgage2",
  "overdraft": "overdraft2",
  "line of credit": "line of credit0",
  "student": "student6",
  "other": "other8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

