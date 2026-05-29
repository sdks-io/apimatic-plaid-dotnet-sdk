
# Credit Account

A credit card type account. Supported products for `credit` accounts are: Balance, Transactions, Identity, and Liabilities.

*This model accepts additional fields of type object.*

## Structure

`CreditAccount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CreditCard` | `string` | Required | Bank-issued credit card |
| `Paypal` | `string` | Required | PayPal-issued credit card |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "credit card": "credit card2",
  "paypal": "paypal4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

