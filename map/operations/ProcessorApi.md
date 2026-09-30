<!-- Generated file — do not edit; regenerated with the SDK. -->

# ProcessorApi — operations

Accessor: `client.ProcessorApi` · Source: `Api/ProcessorApi.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ProcessorApexProcessorTokenCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ProcessorApexProcessorTokenCreate(ProcessorApexProcessorTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorApexProcessorTokenCreateOperationRequest` | `Requests/ProcessorApi/ProcessorApexProcessorTokenCreateOperationRequest.cs` |
| `ProcessorApexProcessorTokenCreateRequest` | `Models/ProcessorApexProcessorTokenCreateRequest.cs` |
| `ProcessorTokenCreateResponse` | `Models/ProcessorTokenCreateResponse.cs` |

### ProcessorAuthGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ProcessorAuthGet(ProcessorAuthGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorAuthGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorAuthGetOperationRequest` | `Requests/ProcessorApi/ProcessorAuthGetOperationRequest.cs` |
| `ProcessorAuthGetRequest` | `Models/ProcessorAuthGetRequest.cs` |
| `ProcessorAuthGetResponse` | `Models/ProcessorAuthGetResponse.cs` |

### ProcessorBalanceGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ProcessorBalanceGet(ProcessorBalanceGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorBalanceGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorBalanceGetOperationRequest` | `Requests/ProcessorApi/ProcessorBalanceGetOperationRequest.cs` |
| `ProcessorBalanceGetRequest` | `Models/ProcessorBalanceGetRequest.cs` |
| `ProcessorBalanceGetResponse` | `Models/ProcessorBalanceGetResponse.cs` |

### ProcessorBankTransferCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ProcessorBankTransferCreate(ProcessorBankTransferCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorBankTransferCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorBankTransferCreateOperationRequest` | `Requests/ProcessorApi/ProcessorBankTransferCreateOperationRequest.cs` |
| `ProcessorBankTransferCreateRequest` | `Models/ProcessorBankTransferCreateRequest.cs` |
| `ProcessorBankTransferCreateResponse` | `Models/ProcessorBankTransferCreateResponse.cs` |

### ProcessorIdentityGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ProcessorIdentityGet(ProcessorIdentityGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorIdentityGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorIdentityGetOperationRequest` | `Requests/ProcessorApi/ProcessorIdentityGetOperationRequest.cs` |
| `ProcessorIdentityGetRequest` | `Models/ProcessorIdentityGetRequest.cs` |
| `ProcessorIdentityGetResponse` | `Models/ProcessorIdentityGetResponse.cs` |

### ProcessorStripeBankAccountTokenCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ProcessorStripeBankAccountTokenCreate(ProcessorStripeBankAccountTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorStripeBankAccountTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorStripeBankAccountTokenCreateOperationRequest` | `Requests/ProcessorApi/ProcessorStripeBankAccountTokenCreateOperationRequest.cs` |
| `ProcessorStripeBankAccountTokenCreateRequest` | `Models/ProcessorStripeBankAccountTokenCreateRequest.cs` |
| `ProcessorStripeBankAccountTokenCreateResponse` | `Models/ProcessorStripeBankAccountTokenCreateResponse.cs` |

### ProcessorTokenCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTokenCreate(ProcessorTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTokenCreateOperationRequest` | `Requests/ProcessorApi/ProcessorTokenCreateOperationRequest.cs` |
| `ProcessorTokenCreateRequest` | `Models/ProcessorTokenCreateRequest.cs` |
| `ProcessorTokenCreateResponse` | `Models/ProcessorTokenCreateResponse.cs` |

