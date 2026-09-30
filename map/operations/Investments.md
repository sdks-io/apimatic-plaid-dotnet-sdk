<!-- Generated file — do not edit; regenerated with the SDK. -->

# Investments — operations

Accessor: `client.Investments` · Source: `Api/Investments.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### InvestmentsHoldingsGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `InvestmentsHoldingsGet(InvestmentsHoldingsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InvestmentsHoldingsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InvestmentsHoldingsGetOperationRequest` | `Requests/Investments/InvestmentsHoldingsGetOperationRequest.cs` |
| `InvestmentsHoldingsGetRequest` | `Models/InvestmentsHoldingsGetRequest.cs` |
| `InvestmentsHoldingsGetResponse` | `Models/InvestmentsHoldingsGetResponse.cs` |

### InvestmentsTransactionsGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `InvestmentsTransactionsGet(InvestmentsTransactionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InvestmentsTransactionsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InvestmentsTransactionsGetOperationRequest` | `Requests/Investments/InvestmentsTransactionsGetOperationRequest.cs` |
| `InvestmentsTransactionsGetRequest` | `Models/InvestmentsTransactionsGetRequest.cs` |
| `InvestmentsTransactionsGetResponse` | `Models/InvestmentsTransactionsGetResponse.cs` |

