<!-- Generated file — do not edit; regenerated with the SDK. -->

# DepositSwitch — operations

Accessor: `client.DepositSwitch` · Source: `Api/DepositSwitch.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DepositSwitchAltCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `DepositSwitchAltCreate(DepositSwitchAltCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DepositSwitchAltCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DepositSwitchAltCreateOperationRequest` | `Requests/DepositSwitch/DepositSwitchAltCreateOperationRequest.cs` |
| `DepositSwitchAltCreateRequest` | `Models/DepositSwitchAltCreateRequest.cs` |
| `DepositSwitchAltCreateResponse` | `Models/DepositSwitchAltCreateResponse.cs` |

### DepositSwitchCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `DepositSwitchCreate(DepositSwitchCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DepositSwitchCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DepositSwitchCreateOperationRequest` | `Requests/DepositSwitch/DepositSwitchCreateOperationRequest.cs` |
| `DepositSwitchCreateRequest` | `Models/DepositSwitchCreateRequest.cs` |
| `DepositSwitchCreateResponse` | `Models/DepositSwitchCreateResponse.cs` |

### DepositSwitchGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `DepositSwitchGet(DepositSwitchGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DepositSwitchGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DepositSwitchGetOperationRequest` | `Requests/DepositSwitch/DepositSwitchGetOperationRequest.cs` |
| `DepositSwitchGetRequest` | `Models/DepositSwitchGetRequest.cs` |
| `DepositSwitchGetResponse` | `Models/DepositSwitchGetResponse.cs` |

### DepositSwitchTokenCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `DepositSwitchTokenCreate(DepositSwitchTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DepositSwitchTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DepositSwitchTokenCreateOperationRequest` | `Requests/DepositSwitch/DepositSwitchTokenCreateOperationRequest.cs` |
| `DepositSwitchTokenCreateRequest` | `Models/DepositSwitchTokenCreateRequest.cs` |
| `DepositSwitchTokenCreateResponse` | `Models/DepositSwitchTokenCreateResponse.cs` |

