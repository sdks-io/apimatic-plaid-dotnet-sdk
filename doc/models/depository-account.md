
# Depository Account

An account type holding cash, in which funds are deposited. Supported products for `depository` accounts are: Auth, Balance, Transactions, Identity, Payment Initiation, and Assets.

*This model accepts additional fields of type object.*

## Structure

`DepositoryAccount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Checking` | `string` | Required | Checking account |
| `Savings` | `string` | Required | Savings account |
| `Hsa` | `string` | Required | Health Savings Account (US only) that can only hold cash |
| `Cd` | `string` | Required | Certificate of deposit account |
| `MoneyMarket` | `string` | Required | Money market account |
| `Paypal` | `string` | Required | PayPal depository account |
| `Prepaid` | `string` | Required | Prepaid debit card |
| `CashManagement` | `string` | Required | A cash management account, typically a cash account at a brokerage |
| `Ebt` | `string` | Required | An Electronic Benefit Transfer (EBT) account, used by certain public assistance programs to distribute funds (US only) |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "checking": "checking2",
  "savings": "savings4",
  "hsa": "hsa2",
  "cd": "cd0",
  "money market": "money market8",
  "paypal": "paypal2",
  "prepaid": "prepaid8",
  "cash management": "cash management8",
  "ebt": "ebt0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

