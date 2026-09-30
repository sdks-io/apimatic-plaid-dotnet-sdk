<!-- Generated file — do not edit; regenerated with the SDK. -->

# Link — operations

Accessor: `client.Link` · Source: `Api/Link.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### LinkTokenCreate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `LinkTokenCreate(LinkTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `LinkTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LinkTokenCreateOperationRequest` | `Requests/Link/LinkTokenCreateOperationRequest.cs` |
| `LinkTokenCreateRequest` | `Models/LinkTokenCreateRequest.cs` |
| `LinkTokenCreateResponse` | `Models/LinkTokenCreateResponse.cs` |

### LinkTokenGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `LinkTokenGet(LinkTokenGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `LinkTokenGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LinkTokenGetOperationRequest` | `Requests/Link/LinkTokenGetOperationRequest.cs` |
| `LinkTokenGetRequest` | `Models/LinkTokenGetRequest.cs` |
| `LinkTokenGetResponse` | `Models/LinkTokenGetResponse.cs` |

