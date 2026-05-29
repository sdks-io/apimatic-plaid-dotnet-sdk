
# Recaptcha Required Error

The request was flagged by Plaid's fraud system, and requires additional verification to ensure they are not a bot.

*This model accepts additional fields of type object.*

## Structure

`RecaptchaRequiredError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ErrorType` | `string` | Required | RECAPTCHA_ERROR |
| `ErrorCode` | `string` | Required | RECAPTCHA_REQUIRED |
| `DisplayMessage` | `string` | Required | - |
| `HttpCode` | `string` | Required | 400 |
| `LinkUserExperience` | `string` | Required | Your user will be prompted to solve a Google reCAPTCHA challenge in the Link Recaptcha pane. If they solve the challenge successfully, the user's request is resubmitted and they are directed to the next Item creation step. |
| `CommonCauses` | `string` | Required | Plaid's fraud system detects abusive traffic and considers a variety of parameters throughout Item creation requests. When a request is considered risky or possibly fraudulent, Link presents a reCAPTCHA for the user to solve. |
| `TroubleshootingSteps` | `string` | Required | Link will automatically guide your user through reCAPTCHA verification. As a general rule, we recommend instrumenting basic fraud monitoring to detect and protect your website from spam and abuse.<br><br>If your user cannot verify their session, please submit a Support ticket with the following identifiers: `link_session_id` or `request_id` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "error_type": "error_type2",
  "error_code": "error_code6",
  "display_message": "display_message2",
  "http_code": "http_code0",
  "link_user_experience": "link_user_experience2",
  "common_causes": "common_causes8",
  "troubleshooting_steps": "troubleshooting_steps0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

