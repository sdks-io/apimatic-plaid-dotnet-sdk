<!-- Generated file — do not edit; regenerated with the SDK. -->

# ItemApi — operations

Accessor: `client.ItemApi` · Source: `Api/ItemApi.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ItemAccessTokenInvalidate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ItemAccessTokenInvalidate(ItemAccessTokenInvalidateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemAccessTokenInvalidateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemAccessTokenInvalidateOperationRequest` | `Requests/ItemApi/ItemAccessTokenInvalidateOperationRequest.cs` |
| `ItemAccessTokenInvalidateRequest` | `Models/ItemAccessTokenInvalidateRequest.cs` |
| `ItemAccessTokenInvalidateResponse` | `Models/ItemAccessTokenInvalidateResponse.cs` |

### ItemApplicationList

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ItemApplicationList(ItemApplicationListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemApplicationListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemApplicationListOperationRequest` | `Requests/ItemApi/ItemApplicationListOperationRequest.cs` |
| `ItemApplicationListRequest` | `Models/ItemApplicationListRequest.cs` |
| `ItemApplicationListResponse` | `Models/ItemApplicationListResponse.cs` |

### ItemApplicationScopesUpdate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ItemApplicationScopesUpdate(ItemApplicationScopesUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemApplicationScopesUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemApplicationScopesUpdateOperationRequest` | `Requests/ItemApi/ItemApplicationScopesUpdateOperationRequest.cs` |
| `ItemApplicationScopesUpdateRequest` | `Models/ItemApplicationScopesUpdateRequest.cs` |
| `ItemApplicationScopesUpdateResponse` | `Models/ItemApplicationScopesUpdateResponse.cs` |

### ItemCreatePublicToken

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ItemCreatePublicToken(ItemCreatePublicTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemPublicTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemCreatePublicTokenRequest` | `Requests/ItemApi/ItemCreatePublicTokenRequest.cs` |
| `ItemPublicTokenCreateRequest` | `Models/ItemPublicTokenCreateRequest.cs` |
| `ItemPublicTokenCreateResponse` | `Models/ItemPublicTokenCreateResponse.cs` |

### ItemGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ItemGet(ItemGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemGetOperationRequest` | `Requests/ItemApi/ItemGetOperationRequest.cs` |
| `ItemGetRequest` | `Models/ItemGetRequest.cs` |
| `ItemGetResponse` | `Models/ItemGetResponse.cs` |

### ItemImport

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ItemImport(ItemImportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemImportResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemImportOperationRequest` | `Requests/ItemApi/ItemImportOperationRequest.cs` |
| `ItemImportRequest` | `Models/ItemImportRequest.cs` |
| `ItemImportResponse` | `Models/ItemImportResponse.cs` |

### ItemPublicTokenExchange

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ItemPublicTokenExchange(ItemPublicTokenExchangeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemPublicTokenExchangeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemPublicTokenExchangeOperationRequest` | `Requests/ItemApi/ItemPublicTokenExchangeOperationRequest.cs` |
| `ItemPublicTokenExchangeRequest` | `Models/ItemPublicTokenExchangeRequest.cs` |
| `ItemPublicTokenExchangeResponse` | `Models/ItemPublicTokenExchangeResponse.cs` |

### ItemRemove

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ItemRemove(ItemRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemRemoveResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemRemoveOperationRequest` | `Requests/ItemApi/ItemRemoveOperationRequest.cs` |
| `ItemRemoveRequest` | `Models/ItemRemoveRequest.cs` |
| `ItemRemoveResponse` | `Models/ItemRemoveResponse.cs` |

### ItemWebhookUpdate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ItemWebhookUpdate(ItemWebhookUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemWebhookUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemWebhookUpdateOperationRequest` | `Requests/ItemApi/ItemWebhookUpdateOperationRequest.cs` |
| `ItemWebhookUpdateRequest` | `Models/ItemWebhookUpdateRequest.cs` |
| `ItemWebhookUpdateResponse` | `Models/ItemWebhookUpdateResponse.cs` |

