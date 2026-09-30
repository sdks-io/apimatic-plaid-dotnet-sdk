<!-- Generated file — do not edit; regenerated with the SDK. -->

# PaymentInitiation — operations

Accessor: `client.PaymentInitiation` · Source: `Api/PaymentInitiation.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreatePaymentToken

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `CreatePaymentToken(CreatePaymentTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationPaymentTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreatePaymentTokenRequest` | `Requests/PaymentInitiation/CreatePaymentTokenRequest.cs` |
| `PaymentInitiationPaymentTokenCreateRequest` | `Models/PaymentInitiationPaymentTokenCreateRequest.cs` |
| `PaymentInitiationPaymentTokenCreateResponse` | `Models/PaymentInitiationPaymentTokenCreateResponse.cs` |

### PaymentInitiationPaymentCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationPaymentCreate(PaymentInitiationPaymentCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationPaymentCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationPaymentCreateOperationRequest` | `Requests/PaymentInitiation/PaymentInitiationPaymentCreateOperationRequest.cs` |
| `PaymentInitiationPaymentCreateRequest` | `Models/PaymentInitiationPaymentCreateRequest.cs` |
| `PaymentInitiationPaymentCreateResponse` | `Models/PaymentInitiationPaymentCreateResponse.cs` |

### PaymentInitiationPaymentGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationPaymentGet(PaymentInitiationPaymentGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationPaymentGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationPaymentGetOperationRequest` | `Requests/PaymentInitiation/PaymentInitiationPaymentGetOperationRequest.cs` |
| `PaymentInitiationPaymentGetRequest` | `Models/PaymentInitiationPaymentGetRequest.cs` |
| `PaymentInitiationPaymentGetResponse` | `Models/PaymentInitiationPaymentGetResponse.cs` |

### PaymentInitiationPaymentList

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationPaymentList(PaymentInitiationPaymentListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationPaymentListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationPaymentListOperationRequest` | `Requests/PaymentInitiation/PaymentInitiationPaymentListOperationRequest.cs` |
| `PaymentInitiationPaymentListRequest` | `Models/PaymentInitiationPaymentListRequest.cs` |
| `PaymentInitiationPaymentListResponse` | `Models/PaymentInitiationPaymentListResponse.cs` |

### PaymentInitiationPaymentReverse

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationPaymentReverse(PaymentInitiationPaymentReverseOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationPaymentReverseResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationPaymentReverseOperationRequest` | `Requests/PaymentInitiation/PaymentInitiationPaymentReverseOperationRequest.cs` |
| `PaymentInitiationPaymentReverseRequest` | `Models/PaymentInitiationPaymentReverseRequest.cs` |
| `PaymentInitiationPaymentReverseResponse` | `Models/PaymentInitiationPaymentReverseResponse.cs` |

### PaymentInitiationRecipientCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationRecipientCreate(PaymentInitiationRecipientCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationRecipientCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationRecipientCreateOperationRequest` | `Requests/PaymentInitiation/PaymentInitiationRecipientCreateOperationRequest.cs` |
| `PaymentInitiationRecipientCreateRequest` | `Models/PaymentInitiationRecipientCreateRequest.cs` |
| `PaymentInitiationRecipientCreateResponse` | `Models/PaymentInitiationRecipientCreateResponse.cs` |

### PaymentInitiationRecipientGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationRecipientGet(PaymentInitiationRecipientGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationRecipientGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationRecipientGetOperationRequest` | `Requests/PaymentInitiation/PaymentInitiationRecipientGetOperationRequest.cs` |
| `PaymentInitiationRecipientGetRequest` | `Models/PaymentInitiationRecipientGetRequest.cs` |
| `PaymentInitiationRecipientGetResponse` | `Models/PaymentInitiationRecipientGetResponse.cs` |

### PaymentInitiationRecipientList

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationRecipientList(PaymentInitiationRecipientListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationRecipientListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationRecipientListOperationRequest` | `Requests/PaymentInitiation/PaymentInitiationRecipientListOperationRequest.cs` |
| `PaymentInitiationRecipientListRequest` | `Models/PaymentInitiationRecipientListRequest.cs` |
| `PaymentInitiationRecipientListResponse` | `Models/PaymentInitiationRecipientListResponse.cs` |

