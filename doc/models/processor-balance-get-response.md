
# Processor Balance Get Response

ProcessorBalanceGetResponse defines the response schema for `/processor/balance/get`

*This model accepts additional fields of type object.*

## Structure

`ProcessorBalanceGetResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Account` | [`Account`](../../doc/models/account.md) | Required | A single account at a financial institution. |
| `RequestId` | `string` | Required | A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "account": {
    "account_id": "account_id2",
    "balances": {
      "available": 142.32,
      "current": 79.74,
      "limit": 30.84,
      "iso_currency_code": "iso_currency_code6",
      "unofficial_currency_code": "unofficial_currency_code2",
      "last_updated_datetime": "2016-03-13T12:52:32.123Z",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "mask": "mask4",
    "name": "name0",
    "official_name": "official_name2",
    "type": "brokerage",
    "subtype": "tfsa",
    "verification_status": "pending_manual_verification",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "request_id": "request_id2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

