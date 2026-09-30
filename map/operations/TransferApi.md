<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransferApi — operations

Accessor: `client.TransferApi` · Source: `Api/TransferApi.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### TransferAuthorizationCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `TransferAuthorizationCreate(TransferAuthorizationCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferAuthorizationCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferAuthorizationCreateOperationRequest` | `Requests/TransferApi/TransferAuthorizationCreateOperationRequest.cs` |
| `TransferAuthorizationCreateRequest` | `Models/TransferAuthorizationCreateRequest.cs` |
| `TransferAuthorizationCreateResponse` | `Models/TransferAuthorizationCreateResponse.cs` |

### TransferCancel

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `TransferCancel(TransferCancelOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferCancelResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferCancelOperationRequest` | `Requests/TransferApi/TransferCancelOperationRequest.cs` |
| `TransferCancelRequest` | `Models/TransferCancelRequest.cs` |
| `TransferCancelResponse` | `Models/TransferCancelResponse.cs` |

### TransferCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `TransferCreate(TransferCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferCreateOperationRequest` | `Requests/TransferApi/TransferCreateOperationRequest.cs` |
| `TransferCreateRequest` | `Models/TransferCreateRequest.cs` |
| `TransferCreateResponse` | `Models/TransferCreateResponse.cs` |

### TransferEventList

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `TransferEventList(TransferEventListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferEventListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferEventListOperationRequest` | `Requests/TransferApi/TransferEventListOperationRequest.cs` |
| `TransferEventListRequest` | `Models/TransferEventListRequest.cs` |
| `TransferEventListResponse` | `Models/TransferEventListResponse.cs` |

### TransferEventSync

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `TransferEventSync(TransferEventSyncOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferEventSyncResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferEventSyncOperationRequest` | `Requests/TransferApi/TransferEventSyncOperationRequest.cs` |
| `TransferEventSyncRequest` | `Models/TransferEventSyncRequest.cs` |
| `TransferEventSyncResponse` | `Models/TransferEventSyncResponse.cs` |

### TransferGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `TransferGet(TransferGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferGetOperationRequest` | `Requests/TransferApi/TransferGetOperationRequest.cs` |
| `TransferGetRequest` | `Models/TransferGetRequest.cs` |
| `TransferGetResponse` | `Models/TransferGetResponse.cs` |

### TransferList

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `TransferList(TransferListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferListOperationRequest` | `Requests/TransferApi/TransferListOperationRequest.cs` |
| `TransferListRequest` | `Models/TransferListRequest.cs` |
| `TransferListResponse` | `Models/TransferListResponse.cs` |

