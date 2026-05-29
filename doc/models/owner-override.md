
# Owner Override

Data about the owner or owners of an account. Any fields not specified will be filled in with default Sandbox information.

*This model accepts additional fields of type object.*

## Structure

`OwnerOverride`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Names` | `List<string>` | Required | A list of names associated with the account by the financial institution. These should always be the names of individuals, even for business accounts. Note that the same name data will be used for all accounts associated with an Item. |
| `PhoneNumbers` | [`List<PhoneNumber>`](../../doc/models/phone-number.md) | Required | A list of phone numbers associated with the account. |
| `Emails` | [`List<Email>`](../../doc/models/email.md) | Required | A list of email addresses associated with the account. |
| `Addresses` | [`List<Address>`](../../doc/models/address.md) | Required | Data about the various addresses associated with the account. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "names": [
    "names6",
    "names5",
    "names4"
  ],
  "phone_numbers": [
    {
      "data": "data0",
      "primary": false,
      "type": "office",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "emails": [
    {
      "data": "data6",
      "primary": false,
      "type": "other",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "addresses": [
    {
      "data": {
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
      "primary": false,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

