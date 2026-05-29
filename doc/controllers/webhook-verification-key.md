# Webhook Verification Key

```csharp
WebhookVerificationKeyApi webhookVerificationKeyApi = client.WebhookVerificationKeyApi;
```

## Class Name

`WebhookVerificationKeyApi`


# Webhook Verification Key Get

Plaid signs all outgoing webhooks and provides JSON Web Tokens (JWTs) so that you can verify the authenticity of any incoming webhooks to your application. A message signature is included in the `Plaid-Verification` header.

The `/webhook_verification_key/get` endpoint provides a JSON Web Key (JWK) that can be used to verify a JWT.

Find out more here: [/api/webhooks/webhook-verification/#webhook_verification_keyget](/api/webhooks/webhook-verification/#webhook_verification_keyget)

```csharp
WebhookVerificationKeyGetAsync(
    Models.WebhookVerificationKeyGetRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`WebhookVerificationKeyGetRequest`](../../doc/models/webhook-verification-key-get-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.WebhookVerificationKeyGetResponse](../../doc/models/webhook-verification-key-get-response.md).

## Example Usage

```csharp
WebhookVerificationKeyGetRequest body = new WebhookVerificationKeyGetRequest
{
    KeyId = "key_id2",
};

try
{
    ApiResponse<WebhookVerificationKeyGetResponse> result = await webhookVerificationKeyApi.WebhookVerificationKeyGetAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "key": {
    "alg": "ES256",
    "created_at": 1560466150,
    "crv": "P-256",
    "expired_at": null,
    "kid": "bfbd5111-8e33-4643-8ced-b2e642a72f3c",
    "kty": "EC",
    "use": "sig",
    "x": "hKXLGIjWvCBv-cP5euCTxl8g9GLG9zHo_3pO5NN1DwQ",
    "y": "shhexqPB7YffGn6fR6h2UhTSuCtPmfzQJ6ENVIoO4Ys"
  },
  "request_id": "RZ6Omi1bzzwDaLo"
}
```

