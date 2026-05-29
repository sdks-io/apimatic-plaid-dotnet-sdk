
# Income Verification Precheck Request

IncomeVerificationPrecheckRequest defines the request schema for `/income/verification/precheck`

*This model accepts additional fields of type object.*

## Structure

`IncomeVerificationPrecheckRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `User` | [`IncomeVerificationPrecheckUser`](../../doc/models/income-verification-precheck-user.md) | Optional | - |
| `Employer` | [`IncomeVerificationPrecheckEmployer`](../../doc/models/income-verification-precheck-employer.md) | Optional | - |
| `TransactionsAccessToken` | `string` | Optional | The access token associated with the Item data is being requested for. |
| `UsMilitaryInfo` | [`IncomeVerificationPrecheckMilitaryInfo`](../../doc/models/income-verification-precheck-military-info.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "client_id": "client_id2",
  "secret": "secret4",
  "user": {
    "first_name": "first_name0",
    "last_name": "last_name8",
    "email_address": "email_address2",
    "home_address": {
      "city": "city0",
      "region": "region6",
      "street": "street0",
      "postal_code": "postal_code2",
      "country": "country4",
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
  "employer": {
    "name": "name2",
    "tax_id": "tax_id2",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "transactions_access_token": "transactions_access_token2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

