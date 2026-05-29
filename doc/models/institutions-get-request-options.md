
# Institutions Get Request Options

An optional object to filter `/institutions/get` results.

*This model accepts additional fields of type object.*

## Structure

`InstitutionsGetRequestOptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Products` | [`List<Products>`](../../doc/models/products.md) | Optional | Filter the Institutions based on which products they support. |
| `RoutingNumbers` | `List<string>` | Optional | Specify an array of routing numbers to filter institutions. The response will only return institutions that match all of the routing numbers in the array. |
| `Oauth` | `bool?` | Optional | Limit results to institutions with or without OAuth login flows. This is primarily relevant to institutions with European country codes. |
| `IncludeOptionalMetadata` | `bool?` | Optional | When `true`, return the institution's homepage URL, logo and primary brand color.<br><br>Note that Plaid does not own any of the logos shared by the API, and that by accessing or using these logos, you agree that you are doing so at your own risk and will, if necessary, obtain all required permissions from the appropriate rights holders and adhere to any applicable usage guidelines. Plaid disclaims all express or implied warranties with respect to the logos. |
| `IncludeAuthMetadata` | `bool?` | Optional | When `true`, returns metadata related to the Auth product indicating which auth methods are supported.<br><br>**Default**: `false` |
| `IncludePaymentInitiationMetadata` | `bool?` | Optional | When `true`, returns metadata related to the Payment Initiation product indicating which payment configurations are supported.<br><br>**Default**: `false` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "include_auth_metadata": false,
  "include_payment_initiation_metadata": false,
  "products": [
    "balance"
  ],
  "routing_numbers": [
    "routing_numbers8"
  ],
  "oauth": false,
  "include_optional_metadata": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

