
# Processor Apex Processor Token Create Request

ProcessorApexProcessorTokenCreateRequest defines the request schema for `/processor/apex/processor_token/create`

*This model accepts additional fields of type object.*

## Structure

`ProcessorApexProcessorTokenCreateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | Your Plaid API `client_id`. The `client_id` is required and may be provided either in the `PLAID-CLIENT-ID` header or as part of a request body. |
| `Secret` | `string` | Optional | Your Plaid API `secret`. The `secret` is required and may be provided either in the `PLAID-SECRET` header or as part of a request body. |
| `AccessToken` | `string` | Required | The access token associated with the Item data is being requested for. |
| `AccountId` | `string` | Required | The `account_id` value obtained from the `onSuccess` callback in Link |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "client_id": "client_id0",
  "secret": "secret6",
  "access_token": "access_token6",
  "account_id": "account_id0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

