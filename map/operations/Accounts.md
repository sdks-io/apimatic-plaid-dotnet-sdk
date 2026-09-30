<!-- Generated file — do not edit; regenerated with the SDK. -->

# Accounts — operations

Accessor: `client.Accounts` · Source: `Api/Accounts.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AccountsBalanceGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `AccountsBalanceGet(AccountsBalanceGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AccountsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AccountsBalanceGetOperationRequest` | `Requests/Accounts/AccountsBalanceGetOperationRequest.cs` |
| `AccountsBalanceGetRequest` | `Models/AccountsBalanceGetRequest.cs` |
| `AccountsGetResponse` | `Models/AccountsGetResponse.cs` |

### AccountsGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `AccountsGet(AccountsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AccountsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AccountsGetOperationRequest` | `Requests/Accounts/AccountsGetOperationRequest.cs` |
| `AccountsGetRequest` | `Models/AccountsGetRequest.cs` |
| `AccountsGetResponse` | `Models/AccountsGetResponse.cs` |

