<!-- Generated file — do not edit; regenerated with the SDK. -->

# Income — operations

Accessor: `client.Income` · Source: `Api/Income.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### IncomeVerificationCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationCreate(IncomeVerificationCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IncomeVerificationCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationCreateOperationRequest` | `Requests/Income/IncomeVerificationCreateOperationRequest.cs` |
| `IncomeVerificationCreateRequest` | `Models/IncomeVerificationCreateRequest.cs` |
| `IncomeVerificationCreateResponse` | `Models/IncomeVerificationCreateResponse.cs` |

### IncomeVerificationDocumentsDownload

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationDocumentsDownload(IncomeVerificationDocumentsDownloadOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationDocumentsDownloadOperationRequest` | `Requests/Income/IncomeVerificationDocumentsDownloadOperationRequest.cs` |
| `IncomeVerificationDocumentsDownloadRequest` | `Models/IncomeVerificationDocumentsDownloadRequest.cs` |

### IncomeVerificationPaystubGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationPaystubGet(IncomeVerificationPaystubGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IncomeVerificationPaystubGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationPaystubGetOperationRequest` | `Requests/Income/IncomeVerificationPaystubGetOperationRequest.cs` |
| `IncomeVerificationPaystubGetRequest` | `Models/IncomeVerificationPaystubGetRequest.cs` |
| `IncomeVerificationPaystubGetResponse` | `Models/IncomeVerificationPaystubGetResponse.cs` |

### IncomeVerificationPaystubsGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationPaystubsGet(IncomeVerificationPaystubsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IncomeVerificationPaystubsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationPaystubsGetOperationRequest` | `Requests/Income/IncomeVerificationPaystubsGetOperationRequest.cs` |
| `IncomeVerificationPaystubsGetRequest` | `Models/IncomeVerificationPaystubsGetRequest.cs` |
| `IncomeVerificationPaystubsGetResponse` | `Models/IncomeVerificationPaystubsGetResponse.cs` |

### IncomeVerificationPrecheck

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationPrecheck(IncomeVerificationPrecheckOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IncomeVerificationPrecheckResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationPrecheckOperationRequest` | `Requests/Income/IncomeVerificationPrecheckOperationRequest.cs` |
| `IncomeVerificationPrecheckRequest` | `Models/IncomeVerificationPrecheckRequest.cs` |
| `IncomeVerificationPrecheckResponse` | `Models/IncomeVerificationPrecheckResponse.cs` |

### IncomeVerificationRefresh

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationRefresh(IncomeVerificationRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IncomeVerificationRefreshResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationRefreshOperationRequest` | `Requests/Income/IncomeVerificationRefreshOperationRequest.cs` |
| `IncomeVerificationRefreshRequest` | `Models/IncomeVerificationRefreshRequest.cs` |
| `IncomeVerificationRefreshResponse` | `Models/IncomeVerificationRefreshResponse.cs` |

### IncomeVerificationSummaryGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationSummaryGet(IncomeVerificationSummaryGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IncomeVerificationSummaryGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationSummaryGetOperationRequest` | `Requests/Income/IncomeVerificationSummaryGetOperationRequest.cs` |
| `IncomeVerificationSummaryGetRequest` | `Models/IncomeVerificationSummaryGetRequest.cs` |
| `IncomeVerificationSummaryGetResponse` | `Models/IncomeVerificationSummaryGetResponse.cs` |

### IncomeVerificationTaxformsGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationTaxformsGet(IncomeVerificationTaxformsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IncomeVerificationTaxformsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationTaxformsGetOperationRequest` | `Requests/Income/IncomeVerificationTaxformsGetOperationRequest.cs` |
| `IncomeVerificationTaxformsGetRequest` | `Models/IncomeVerificationTaxformsGetRequest.cs` |
| `IncomeVerificationTaxformsGetResponse` | `Models/IncomeVerificationTaxformsGetResponse.cs` |

