<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApplicationApi — operations

Accessor: `client.ApplicationApi` · Source: `Api/ApplicationApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ApplicationGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `ApplicationGet(ApplicationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ApplicationGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ApplicationGetOperationRequest` | `Requests/ApplicationApi/ApplicationGetOperationRequest.cs` |
| `ApplicationGetRequest` | `Models/ApplicationGetRequest.cs` |
| `ApplicationGetResponse` | `Models/ApplicationGetResponse.cs` |

