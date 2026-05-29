
# Bank Transfer Migrate Account Response

Defines the response schema for `/bank_transfer/migrate_account`

*This model accepts additional fields of type object.*

## Structure

`BankTransferMigrateAccountResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessToken` | `string` | Required | The Plaid `access_token` for the newly created Item. |
| `AccountId` | `string` | Required | The Plaid `account_id` for the newly created Item. |
| `RequestId` | `string` | Required | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "access_token": "access_token4",
  "account_id": "account_id8",
  "request_id": "request_id2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

