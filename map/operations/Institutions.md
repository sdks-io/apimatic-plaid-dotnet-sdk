<!-- Generated file — do not edit; regenerated with the SDK. -->

# Institutions — operations

Accessor: `client.Institutions` · Source: `Api/Institutions.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### InstitutionsGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `InstitutionsGet(InstitutionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InstitutionsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InstitutionsGetOperationRequest` | `Requests/Institutions/InstitutionsGetOperationRequest.cs` |
| `InstitutionsGetRequest` | `Models/InstitutionsGetRequest.cs` |
| `InstitutionsGetResponse` | `Models/InstitutionsGetResponse.cs` |

### InstitutionsGetById

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `InstitutionsGetById(InstitutionsGetByIdOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InstitutionsGetByIdResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InstitutionsGetByIdOperationRequest` | `Requests/Institutions/InstitutionsGetByIdOperationRequest.cs` |
| `InstitutionsGetByIdRequest` | `Models/InstitutionsGetByIdRequest.cs` |
| `InstitutionsGetByIdResponse` | `Models/InstitutionsGetByIdResponse.cs` |

### InstitutionsSearch

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `InstitutionsSearch(InstitutionsSearchOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InstitutionsSearchResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InstitutionsSearchOperationRequest` | `Requests/Institutions/InstitutionsSearchOperationRequest.cs` |
| `InstitutionsSearchRequest` | `Models/InstitutionsSearchRequest.cs` |
| `InstitutionsSearchResponse` | `Models/InstitutionsSearchResponse.cs` |

