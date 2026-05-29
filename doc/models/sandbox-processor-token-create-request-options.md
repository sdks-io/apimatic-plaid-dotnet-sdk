
# Sandbox Processor Token Create Request Options

An optional set of options to be used when configuring the Item. If specified, must not be `null`.

*This model accepts additional fields of type object.*

## Structure

`SandboxProcessorTokenCreateRequestOptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OverrideUsername` | `string` | Optional | Test username to use for the creation of the Sandbox Item. Default value is `user_good`.<br><br>**Default**: `"user_good"` |
| `OverridePassword` | `string` | Optional | Test password to use for the creation of the Sandbox Item. Default value is `pass_good`.<br><br>**Default**: `"pass_good"` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "override_username": "user_good",
  "override_password": "pass_good",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

