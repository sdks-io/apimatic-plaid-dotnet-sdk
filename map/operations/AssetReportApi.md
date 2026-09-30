<!-- Generated file — do not edit; regenerated with the SDK. -->

# AssetReportApi — operations

Accessor: `client.AssetReportApi` · Source: `Api/AssetReportApi.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AssetReportAuditCopyCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `AssetReportAuditCopyCreate(AssetReportAuditCopyCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportAuditCopyCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportAuditCopyCreateOperationRequest` | `Requests/AssetReportApi/AssetReportAuditCopyCreateOperationRequest.cs` |
| `AssetReportAuditCopyCreateRequest` | `Models/AssetReportAuditCopyCreateRequest.cs` |
| `AssetReportAuditCopyCreateResponse` | `Models/AssetReportAuditCopyCreateResponse.cs` |

### AssetReportAuditCopyGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `AssetReportAuditCopyGet(AssetReportAuditCopyGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportAuditCopyGetOperationRequest` | `Requests/AssetReportApi/AssetReportAuditCopyGetOperationRequest.cs` |
| `AssetReportAuditCopyGetRequest` | `Models/AssetReportAuditCopyGetRequest.cs` |
| `AssetReportGetResponse` | `Models/AssetReportGetResponse.cs` |

### AssetReportAuditCopyRemove

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `AssetReportAuditCopyRemove(AssetReportAuditCopyRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportAuditCopyRemoveResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportAuditCopyRemoveOperationRequest` | `Requests/AssetReportApi/AssetReportAuditCopyRemoveOperationRequest.cs` |
| `AssetReportAuditCopyRemoveRequest` | `Models/AssetReportAuditCopyRemoveRequest.cs` |
| `AssetReportAuditCopyRemoveResponse` | `Models/AssetReportAuditCopyRemoveResponse.cs` |

### AssetReportCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `AssetReportCreate(AssetReportCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportCreateOperationRequest` | `Requests/AssetReportApi/AssetReportCreateOperationRequest.cs` |
| `AssetReportCreateRequest` | `Models/AssetReportCreateRequest.cs` |
| `AssetReportCreateResponse` | `Models/AssetReportCreateResponse.cs` |

### AssetReportFilter

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `AssetReportFilter(AssetReportFilterOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportFilterResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportFilterOperationRequest` | `Requests/AssetReportApi/AssetReportFilterOperationRequest.cs` |
| `AssetReportFilterRequest` | `Models/AssetReportFilterRequest.cs` |
| `AssetReportFilterResponse` | `Models/AssetReportFilterResponse.cs` |

### AssetReportGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `AssetReportGet(AssetReportGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportGetOperationRequest` | `Requests/AssetReportApi/AssetReportGetOperationRequest.cs` |
| `AssetReportGetRequest` | `Models/AssetReportGetRequest.cs` |
| `AssetReportGetResponse` | `Models/AssetReportGetResponse.cs` |

### AssetReportPdfGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `AssetReportPdfGet(AssetReportPdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportPdfGetOperationRequest` | `Requests/AssetReportApi/AssetReportPdfGetOperationRequest.cs` |
| `AssetReportPdfGetRequest` | `Models/AssetReportPdfGetRequest.cs` |

### AssetReportRefresh

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `AssetReportRefresh(AssetReportRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportRefreshResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportRefreshOperationRequest` | `Requests/AssetReportApi/AssetReportRefreshOperationRequest.cs` |
| `AssetReportRefreshRequest` | `Models/AssetReportRefreshRequest.cs` |
| `AssetReportRefreshResponse` | `Models/AssetReportRefreshResponse.cs` |

### AssetReportRemove

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `AssetReportRemove(AssetReportRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportRemoveResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportRemoveOperationRequest` | `Requests/AssetReportApi/AssetReportRemoveOperationRequest.cs` |
| `AssetReportRemoveRequest` | `Models/AssetReportRemoveRequest.cs` |
| `AssetReportRemoveResponse` | `Models/AssetReportRemoveResponse.cs` |

