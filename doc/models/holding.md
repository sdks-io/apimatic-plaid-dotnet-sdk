
# Holding

A securities holding at an institution.

*This model accepts additional fields of type object.*

## Structure

`Holding`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `string` | Required | The Plaid `account_id` associated with the holding. |
| `SecurityId` | `string` | Required | The Plaid `security_id` associated with the holding. |
| `InstitutionPrice` | `double` | Required | The last price given by the institution for this security. |
| `InstitutionPriceAsOf` | `DateTime?` | Required | The date at which `institution_price` was current. |
| `InstitutionValue` | `double` | Required | The value of the holding, as reported by the institution. |
| `CostBasis` | `double?` | Required | The cost basis of the holding. |
| `Quantity` | `double` | Required | The total quantity of the asset held, as reported by the financial institution. If the security is an option, `quantity` will reflect the total number of options (typically the number of contracts multiplied by 100), not the number of contracts. |
| `IsoCurrencyCode` | `string` | Required | The ISO-4217 currency code of the holding. Always `null` if `unofficial_currency_code` is non-`null`. |
| `UnofficialCurrencyCode` | `string` | Required | The unofficial currency code associated with the holding. Always `null` if `iso_currency_code` is non-`null`. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.<br><br>See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported `iso_currency_code`s. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "account_id": "account_id0",
  "security_id": "security_id8",
  "institution_price": 253.74,
  "institution_price_as_of": "2016-03-13",
  "institution_value": 92.94,
  "cost_basis": 243.26,
  "quantity": 251.74,
  "iso_currency_code": "iso_currency_code8",
  "unofficial_currency_code": "unofficial_currency_code0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

