<!-- Generated file — do not edit; regenerated with the SDK. -->

# Signal — operations

Accessor: `client.Signal` · Source: `Api/Signal.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SignalDecisionReport

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `SignalDecisionReport(SignalDecisionReportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SignalDecisionReportResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SignalDecisionReportOperationRequest` | `Requests/Signal/SignalDecisionReportOperationRequest.cs` |
| `SignalDecisionReportRequest` | `Models/SignalDecisionReportRequest.cs` |
| `SignalDecisionReportResponse` | `Models/SignalDecisionReportResponse.cs` |

### SignalEvaluate

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `SignalEvaluate(SignalEvaluateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SignalEvaluateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SignalEvaluateOperationRequest` | `Requests/Signal/SignalEvaluateOperationRequest.cs` |
| `SignalEvaluateRequest` | `Models/SignalEvaluateRequest.cs` |
| `SignalEvaluateResponse` | `Models/SignalEvaluateResponse.cs` |

### SignalReturnReport

- **Auth**: `options.PlaidClientId` AND `options.PlaidSecret` AND `options.PlaidVersion`
- **Signature**: `SignalReturnReport(SignalReturnReportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SignalReturnReportResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SignalReturnReportOperationRequest` | `Requests/Signal/SignalReturnReportOperationRequest.cs` |
| `SignalReturnReportRequest` | `Models/SignalReturnReportRequest.cs` |
| `SignalReturnReportResponse` | `Models/SignalReturnReportResponse.cs` |

