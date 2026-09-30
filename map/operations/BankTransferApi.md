<!-- Generated file — do not edit; regenerated with the SDK. -->

# BankTransferApi — operations

Accessor: `client.BankTransferApi` · Source: `Api/BankTransferApi.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BankTransferBalanceGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `BankTransferBalanceGet(BankTransferBalanceGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferBalanceGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferBalanceGetOperationRequest` | `Requests/BankTransferApi/BankTransferBalanceGetOperationRequest.cs` |
| `BankTransferBalanceGetRequest` | `Models/BankTransferBalanceGetRequest.cs` |
| `BankTransferBalanceGetResponse` | `Models/BankTransferBalanceGetResponse.cs` |

### BankTransferCancel

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `BankTransferCancel(BankTransferCancelOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferCancelResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferCancelOperationRequest` | `Requests/BankTransferApi/BankTransferCancelOperationRequest.cs` |
| `BankTransferCancelRequest` | `Models/BankTransferCancelRequest.cs` |
| `BankTransferCancelResponse` | `Models/BankTransferCancelResponse.cs` |

### BankTransferCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `BankTransferCreate(BankTransferCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferCreateOperationRequest` | `Requests/BankTransferApi/BankTransferCreateOperationRequest.cs` |
| `BankTransferCreateRequest` | `Models/BankTransferCreateRequest.cs` |
| `BankTransferCreateResponse` | `Models/BankTransferCreateResponse.cs` |

### BankTransferEventList

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `BankTransferEventList(BankTransferEventListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferEventListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferEventListOperationRequest` | `Requests/BankTransferApi/BankTransferEventListOperationRequest.cs` |
| `BankTransferEventListRequest` | `Models/BankTransferEventListRequest.cs` |
| `BankTransferEventListResponse` | `Models/BankTransferEventListResponse.cs` |

### BankTransferEventSync

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `BankTransferEventSync(BankTransferEventSyncOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferEventSyncResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferEventSyncOperationRequest` | `Requests/BankTransferApi/BankTransferEventSyncOperationRequest.cs` |
| `BankTransferEventSyncRequest` | `Models/BankTransferEventSyncRequest.cs` |
| `BankTransferEventSyncResponse` | `Models/BankTransferEventSyncResponse.cs` |

### BankTransferGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `BankTransferGet(BankTransferGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferGetOperationRequest` | `Requests/BankTransferApi/BankTransferGetOperationRequest.cs` |
| `BankTransferGetRequest` | `Models/BankTransferGetRequest.cs` |
| `BankTransferGetResponse` | `Models/BankTransferGetResponse.cs` |

### BankTransferList

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `BankTransferList(BankTransferListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferListOperationRequest` | `Requests/BankTransferApi/BankTransferListOperationRequest.cs` |
| `BankTransferListRequest` | `Models/BankTransferListRequest.cs` |
| `BankTransferListResponse` | `Models/BankTransferListResponse.cs` |

### BankTransferMigrateAccount

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `BankTransferMigrateAccount(BankTransferMigrateAccountOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferMigrateAccountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferMigrateAccountOperationRequest` | `Requests/BankTransferApi/BankTransferMigrateAccountOperationRequest.cs` |
| `BankTransferMigrateAccountRequest` | `Models/BankTransferMigrateAccountRequest.cs` |
| `BankTransferMigrateAccountResponse` | `Models/BankTransferMigrateAccountResponse.cs` |

### BankTransferSweepGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `BankTransferSweepGet(BankTransferSweepGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferSweepGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferSweepGetOperationRequest` | `Requests/BankTransferApi/BankTransferSweepGetOperationRequest.cs` |
| `BankTransferSweepGetRequest` | `Models/BankTransferSweepGetRequest.cs` |
| `BankTransferSweepGetResponse` | `Models/BankTransferSweepGetResponse.cs` |

### BankTransferSweepList

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `BankTransferSweepList(BankTransferSweepListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferSweepListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferSweepListOperationRequest` | `Requests/BankTransferApi/BankTransferSweepListOperationRequest.cs` |
| `BankTransferSweepListRequest` | `Models/BankTransferSweepListRequest.cs` |
| `BankTransferSweepListResponse` | `Models/BankTransferSweepListResponse.cs` |

