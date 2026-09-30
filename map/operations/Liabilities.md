<!-- Generated file — do not edit; regenerated with the SDK. -->

# Liabilities — operations

Accessor: `client.Liabilities` · Source: `Api/Liabilities.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### LiabilitiesGet

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `LiabilitiesGet(LiabilitiesGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `LiabilitiesGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LiabilitiesGetOperationRequest` | `Requests/Liabilities/LiabilitiesGetOperationRequest.cs` |
| `LiabilitiesGetRequest` | `Models/LiabilitiesGetRequest.cs` |
| `LiabilitiesGetResponse` | `Models/LiabilitiesGetResponse.cs` |

