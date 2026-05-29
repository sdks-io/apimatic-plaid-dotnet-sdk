
# Link Token Get Metadata Response

An object specifying the arguments originally provided to the `/link/token/create` call.

*This model accepts additional fields of type object.*

## Structure

`LinkTokenGetMetadataResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InitialProducts` | [`List<Products>`](../../doc/models/products.md) | Required | The `products` specified in the `/link/token/create` call. |
| `Webhook` | `string` | Required | The `webhook` specified in the `/link/token/create` call. |
| `CountryCodes` | [`List<CountryCode>`](../../doc/models/country-code.md) | Required | The `country_codes` specified in the `/link/token/create` call. |
| `Language` | `string` | Required | The `language` specified in the `/link/token/create` call. |
| `AccountFilters` | [`AccountFiltersResponse`](../../doc/models/account-filters-response.md) | Optional | The `account_filters` specified in the original call to `/link/token/create`. |
| `RedirectUri` | `string` | Required | The `redirect_uri` specified in the `/link/token/create` call. |
| `ClientName` | `string` | Required | The `client_name` specified in the `/link/token/create` call. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "initial_products": [
    "liabilities",
    "payment_initiation",
    "transactions"
  ],
  "webhook": "webhook4",
  "country_codes": [
    "US",
    "GB",
    "ES"
  ],
  "language": "language8",
  "account_filters": {
    "depository": {
      "account_subtypes": [
        "non-taxable brokerage account",
        "other"
      ],
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "credit": {
      "account_subtypes": [
        "ugma",
        "utma",
        "variable annuity"
      ],
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "loan": {
      "account_subtypes": [
        "checking",
        "savings",
        "money market"
      ],
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "investment": {
      "account_subtypes": [
        "consumer",
        "home"
      ],
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "redirect_uri": "redirect_uri4",
  "client_name": "client_name0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

