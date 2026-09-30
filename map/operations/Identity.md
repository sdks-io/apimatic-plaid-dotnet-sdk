<!-- Generated file — do not edit; regenerated with the SDK. -->

# Identity — operations

Accessor: `client.Identity` · Source: `Api/Identity.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### IdentityGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `IdentityGet(IdentityGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IdentityGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityGetOperationRequest` | `Requests/Identity/IdentityGetOperationRequest.cs` |
| `IdentityGetRequest` | `Models/IdentityGetRequest.cs` |
| `IdentityGetResponse` | `Models/IdentityGetResponse.cs` |

