
# Investments Transactions Override

Specify the list of investments transactions on the account.

*This model accepts additional fields of type object.*

## Structure

`InvestmentsTransactionsOverride`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Date` | `DateTime` | Required | Posting date for the transaction. Must be formatted as an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) date. |
| `Name` | `string` | Required | The institution's description of the transaction. |
| `Quantity` | `double` | Required | The number of units of the security involved in this transaction. Must be positive if the type is a buy and negative if the type is a sell. |
| `Price` | `double` | Required | The price of the security at which this transaction occurred. |
| `Fees` | `double?` | Optional | The combined value of all fees applied to this transaction. |
| `Type` | `string` | Required | The type of the investment transaction. Possible values are:<br>`buy`: Buying an investment<br>`sell`: Selling an investment<br>`cash`: Activity that modifies a cash position<br>`fee`: A fee on the account<br>`transfer`: Activity that modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer |
| `Currency` | `string` | Required | Either a valid `iso_currency_code` or `unofficial_currency_code` |
| `Security` | [`SecurityOverride`](../../doc/models/security-override.md) | Optional | Specify the security associated with the holding or investment transaction. When inputting custom security data to the Sandbox, Plaid will perform post-data-retrieval normalization and enrichment. These processes may cause the data returned by the Sandbox to be slightly different from the data you input. An ISO-4217 currency code and a security identifier (`ticker_symbol`, `cusip`, `isin`, or `sedol`) are required. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "date": "2016-03-13",
  "name": "name0",
  "quantity": 186.96,
  "price": 169.72,
  "fees": 35.9,
  "type": "type0",
  "currency": "currency0",
  "security": {
    "isin": "isin4",
    "cusip": "cusip4",
    "sedol": "sedol0",
    "name": "name6",
    "ticker_symbol": "ticker_symbol8",
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

