using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Signal;

/// <summary>
/// The inputs of the SignalDecisionReport operation.
/// </summary>
public sealed record SignalDecisionReportOperationRequest
{
    public required SignalDecisionReportRequest Body { get; init; }
}
