
# Employer

Data about the employer.

*This model accepts additional fields of type object.*

## Structure

`Employer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EmployerId` | `string` | Required | Plaid's unique identifier for the employer. |
| `Name` | `string` | Required | The name of the employer |
| `Address` | [`AddressDataNullable`](../../doc/models/address-data-nullable.md) | Required | - |
| `ConfidenceScore` | `double` | Required | A number from 0 to 1 indicating Plaid's level of confidence in the pairing between the employer and the institution (not yet implemented). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "employer_id": "employer_id0",
  "name": "name6",
  "address": {
    "city": "city6",
    "region": "region2",
    "street": "street6",
    "postal_code": "postal_code8",
    "country": "country0",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "confidence_score": 116.56,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

