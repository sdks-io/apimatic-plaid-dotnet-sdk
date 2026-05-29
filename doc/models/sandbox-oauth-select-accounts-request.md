
# Sandbox Oauth Select Accounts Request

Defines the request schema for `sandbox/oauth/select_accounts`

*This model accepts additional fields of type object.*

## Structure

`SandboxOauthSelectAccountsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OauthStateId` | `string` | Required | - |
| `Accounts` | `List<string>` | Required | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "oauth_state_id": "oauth_state_id6",
  "accounts": [
    "accounts2"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

