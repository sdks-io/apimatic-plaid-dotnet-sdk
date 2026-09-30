using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Signal;

/// <summary>
/// The inputs of the SignalEvaluate operation.
/// </summary>
public sealed record SignalEvaluateOperationRequest
{
    public required SignalEvaluateRequest Body { get; init; }
}
