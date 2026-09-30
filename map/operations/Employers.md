<!-- Generated file — do not edit; regenerated with the SDK. -->

# Employers — operations

Accessor: `client.Employers` · Source: `Api/Employers.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### EmployersSearch

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `EmployersSearch(EmployersSearchOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `EmployersSearchResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EmployersSearchOperationRequest` | `Requests/Employers/EmployersSearchOperationRequest.cs` |
| `EmployersSearchRequest` | `Models/EmployersSearchRequest.cs` |
| `EmployersSearchResponse` | `Models/EmployersSearchResponse.cs` |

