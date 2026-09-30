<!-- Generated file — do not edit; regenerated with the SDK. -->

# Auth — operations

Accessor: `client.Auth` · Source: `Api/Auth.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AuthGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `AuthGet(AuthGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AuthGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AuthGetOperationRequest` | `Requests/Auth/AuthGetOperationRequest.cs` |
| `AuthGetRequest` | `Models/AuthGetRequest.cs` |
| `AuthGetResponse` | `Models/AuthGetResponse.cs` |

