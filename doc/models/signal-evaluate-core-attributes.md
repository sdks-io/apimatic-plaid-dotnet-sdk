
# Signal Evaluate Core Attributes

The core attributes object contains additional data that can be used to assess the ACH return risk, such as past ACH return events, balance/transaction history, the Item’s connection history in the Plaid network, and identity change history.

*This model accepts additional fields of type object.*

## Structure

`SignalEvaluateCoreAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UnauthorizedTransactionsCount7D` | `int?` | Optional | We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 7 days from the account that will be debited. |
| `UnauthorizedTransactionsCount30D` | `int?` | Optional | We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 30 days from the account that will be debited. |
| `UnauthorizedTransactionsCount60D` | `int?` | Optional | We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 60 days from the account that will be debited. |
| `UnauthorizedTransactionsCount90D` | `int?` | Optional | We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 90 days from the account that will be debited. |
| `NsfOverdraftTransactionsCount7D` | `int?` | Optional | We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 7 days from the account that will be debited. |
| `NsfOverdraftTransactionsCount30D` | `int?` | Optional | We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 30 days from the account that will be debited. |
| `NsfOverdraftTransactionsCount60D` | `int?` | Optional | We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 60 days from the account that will be debited. |
| `NsfOverdraftTransactionsCount90D` | `int?` | Optional | We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 90 days from the account that will be debited. |
| `DaysSinceFirstPlaidConnection` | `int?` | Optional | The number of days since the first time the Item was connected to an application via Plaid |
| `PlaidConnectionsCount7D` | `int?` | Optional | The number of times the Item has been connected to applications via Plaid over the past 7 days |
| `PlaidConnectionsCount30D` | `int?` | Optional | The number of times the Item has been connected to applications via Plaid over the past 30 days |
| `TotalPlaidConnectionsCount` | `int?` | Optional | The total number of times the Item has been connected to applications via Plaid |
| `IsSavingsOrMoneyMarketAccount` | `bool?` | Optional | Indicates if the ACH transaction funding account is a savings/money market account |
| `TotalCreditTransactionsAmount10D` | `double?` | Optional | The total credit (inflow) transaction amount over the past 10 days from the account that will be debited |
| `TotalDebitTransactionsAmount10D` | `double?` | Optional | The total debit (outflow) transaction amount over the past 10 days from the account that will be debited |
| `P50CreditTransactionsAmount28D` | `double?` | Optional | The 50th percentile of all credit (inflow) transaction amounts over the past 28 days from the account that will be debited |
| `P50DebitTransactionsAmount28D` | `double?` | Optional | The 50th percentile of all debit (outflow) transaction amounts over the past 28 days from the account that will be debited |
| `P95CreditTransactionsAmount28D` | `double?` | Optional | The 95th percentile of all credit (inflow) transaction amounts over the past 28 days from the account that will be debited |
| `P95DebitTransactionsAmount28D` | `double?` | Optional | The 95th percentile of all debit (outflow) transaction amounts over the past 28 days from the account that will be debited |
| `DaysWithNegativeBalanceCount90D` | `int?` | Optional | The number of days within the past 90 days when the account that will be debited had a negative end-of-day available balance |
| `P90EodBalance30D` | `double?` | Optional | The 90th percentile of the end-of-day available balance over the past 30 days of the account that will be debited |
| `P90EodBalance60D` | `double?` | Optional | The 90th percentile of the end-of-day available balance over the past 60 days of the account that will be debited |
| `P90EodBalance90D` | `double?` | Optional | The 90th percentile of the end-of-day available balance over the past 90 days of the account that will be debited |
| `P10EodBalance30D` | `double?` | Optional | The 10th percentile of the end-of-day available balance over the past 30 days of the account that will be debited |
| `P10EodBalance60D` | `double?` | Optional | The 10th percentile of the end-of-day available balance over the past 60 days of the account that will be debited |
| `P10EodBalance90D` | `double?` | Optional | The 10th percentile of the end-of-day available balance over the past 90 days of the account that will be debited |
| `AvailableBalance` | `double?` | Optional | Available balance, as of the `balance_last_updated` time. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account. |
| `CurrentBalance` | `double?` | Optional | Current balance, as of the `balance_last_updated` time. The current balance is the total amount of funds in the account. |
| `BalanceLastUpdated` | `DateTime?` | Optional | Timestamp in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DDTHH:mm:ssZ) indicating the last time that the balance for the given account has been updated. |
| `PhoneChangeCount28D` | `int?` | Optional | The number of times the account's phone numbers on file have changed over the past 28 days |
| `PhoneChangeCount90D` | `int?` | Optional | The number of times the account's phone numbers on file have changed over the past 90 days |
| `EmailChangeCount28D` | `int?` | Optional | The number of times the account's email addresses on file have changed over the past 28 days |
| `EmailChangeCount90D` | `int?` | Optional | The number of times the account's email addresses on file have changed over the past 90 days |
| `AddressChangeCount28D` | `int?` | Optional | The number of times the account's addresses on file have changed over the past 28 days |
| `AddressChangeCount90D` | `int?` | Optional | The number of times the account's addresses on file have changed over the past 90 days |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "unauthorized_transactions_count_7d": 214,
  "unauthorized_transactions_count_30d": 98,
  "unauthorized_transactions_count_60d": 22,
  "unauthorized_transactions_count_90d": 138,
  "nsf_overdraft_transactions_count_7d": 70,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

