<!-- Generated file — do not edit; regenerated with the SDK. -->

# Sandbox — operations

Accessor: `client.Sandbox` · Source: `Api/Sandbox.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SandboxBankTransferFireWebhook

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `SandboxBankTransferFireWebhook(SandboxBankTransferFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxBankTransferFireWebhookResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxBankTransferFireWebhookOperationRequest` | `Requests/Sandbox/SandboxBankTransferFireWebhookOperationRequest.cs` |
| `SandboxBankTransferFireWebhookRequest` | `Models/SandboxBankTransferFireWebhookRequest.cs` |
| `SandboxBankTransferFireWebhookResponse` | `Models/SandboxBankTransferFireWebhookResponse.cs` |

### SandboxBankTransferSimulate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `SandboxBankTransferSimulate(SandboxBankTransferSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxBankTransferSimulateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxBankTransferSimulateOperationRequest` | `Requests/Sandbox/SandboxBankTransferSimulateOperationRequest.cs` |
| `SandboxBankTransferSimulateRequest` | `Models/SandboxBankTransferSimulateRequest.cs` |
| `SandboxBankTransferSimulateResponse` | `Models/SandboxBankTransferSimulateResponse.cs` |

### SandboxIncomeFireWebhook

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `SandboxIncomeFireWebhook(SandboxIncomeFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxIncomeFireWebhookResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxIncomeFireWebhookOperationRequest` | `Requests/Sandbox/SandboxIncomeFireWebhookOperationRequest.cs` |
| `SandboxIncomeFireWebhookRequest` | `Models/SandboxIncomeFireWebhookRequest.cs` |
| `SandboxIncomeFireWebhookResponse` | `Models/SandboxIncomeFireWebhookResponse.cs` |

### SandboxItemFireWebhook

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `SandboxItemFireWebhook(SandboxItemFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxItemFireWebhookResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxItemFireWebhookOperationRequest` | `Requests/Sandbox/SandboxItemFireWebhookOperationRequest.cs` |
| `SandboxItemFireWebhookRequest` | `Models/SandboxItemFireWebhookRequest.cs` |
| `SandboxItemFireWebhookResponse` | `Models/SandboxItemFireWebhookResponse.cs` |

### SandboxItemResetLogin

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `SandboxItemResetLogin(SandboxItemResetLoginOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxItemResetLoginResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxItemResetLoginOperationRequest` | `Requests/Sandbox/SandboxItemResetLoginOperationRequest.cs` |
| `SandboxItemResetLoginRequest` | `Models/SandboxItemResetLoginRequest.cs` |
| `SandboxItemResetLoginResponse` | `Models/SandboxItemResetLoginResponse.cs` |

### SandboxItemSetVerificationStatus

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `SandboxItemSetVerificationStatus(SandboxItemSetVerificationStatusOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxItemSetVerificationStatusResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxItemSetVerificationStatusOperationRequest` | `Requests/Sandbox/SandboxItemSetVerificationStatusOperationRequest.cs` |
| `SandboxItemSetVerificationStatusRequest` | `Models/SandboxItemSetVerificationStatusRequest.cs` |
| `SandboxItemSetVerificationStatusResponse` | `Models/SandboxItemSetVerificationStatusResponse.cs` |

### SandboxOauthSelectAccounts

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `SandboxOauthSelectAccounts(SandboxOauthSelectAccountsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxOauthSelectAccountsOperationRequest` | `Requests/Sandbox/SandboxOauthSelectAccountsOperationRequest.cs` |
| `SandboxOauthSelectAccountsRequest` | `Models/SandboxOauthSelectAccountsRequest.cs` |

### SandboxProcessorTokenCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `SandboxProcessorTokenCreate(SandboxProcessorTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxProcessorTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxProcessorTokenCreateOperationRequest` | `Requests/Sandbox/SandboxProcessorTokenCreateOperationRequest.cs` |
| `SandboxProcessorTokenCreateRequest` | `Models/SandboxProcessorTokenCreateRequest.cs` |
| `SandboxProcessorTokenCreateResponse` | `Models/SandboxProcessorTokenCreateResponse.cs` |

### SandboxPublicTokenCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `SandboxPublicTokenCreate(SandboxPublicTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxPublicTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxPublicTokenCreateOperationRequest` | `Requests/Sandbox/SandboxPublicTokenCreateOperationRequest.cs` |
| `SandboxPublicTokenCreateRequest` | `Models/SandboxPublicTokenCreateRequest.cs` |
| `SandboxPublicTokenCreateResponse` | `Models/SandboxPublicTokenCreateResponse.cs` |

### SandboxTransferSimulate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferSimulate(SandboxTransferSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxTransferSimulateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferSimulateOperationRequest` | `Requests/Sandbox/SandboxTransferSimulateOperationRequest.cs` |
| `SandboxTransferSimulateRequest` | `Models/SandboxTransferSimulateRequest.cs` |
| `SandboxTransferSimulateResponse` | `Models/SandboxTransferSimulateResponse.cs` |

