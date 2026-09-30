<!-- Generated file — do not edit; regenerated with the SDK. -->

# Transactions — operations

Accessor: `client.Transactions` · Source: `Api/Transactions.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### TransactionsGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `TransactionsGet(TransactionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransactionsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsGetOperationRequest` | `Requests/Transactions/TransactionsGetOperationRequest.cs` |
| `TransactionsGetRequest` | `Models/TransactionsGetRequest.cs` |
| `TransactionsGetResponse` | `Models/TransactionsGetResponse.cs` |

### TransactionsRefresh

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `TransactionsRefresh(TransactionsRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransactionsRefreshResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsRefreshOperationRequest` | `Requests/Transactions/TransactionsRefreshOperationRequest.cs` |
| `TransactionsRefreshRequest` | `Models/TransactionsRefreshRequest.cs` |
| `TransactionsRefreshResponse` | `Models/TransactionsRefreshResponse.cs` |

