<!-- Generated file — do not edit; regenerated with the SDK. -->

# WebhookVerificationKey — operations

Accessor: `client.WebhookVerificationKey` · Source: `Api/WebhookVerificationKey.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### WebhookVerificationKeyGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `WebhookVerificationKeyGet(WebhookVerificationKeyGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WebhookVerificationKeyGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WebhookVerificationKeyGetOperationRequest` | `Requests/WebhookVerificationKey/WebhookVerificationKeyGetOperationRequest.cs` |
| `WebhookVerificationKeyGetRequest` | `Models/WebhookVerificationKeyGetRequest.cs` |
| `WebhookVerificationKeyGetResponse` | `Models/WebhookVerificationKeyGetResponse.cs` |

