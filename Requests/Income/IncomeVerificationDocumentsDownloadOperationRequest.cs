using ThePlaidApi.Models;

namespace ThePlaidApi.Requests.Income;

/// <summary>
/// The inputs of the IncomeVerificationDocumentsDownload operation.
/// </summary>
public sealed record IncomeVerificationDocumentsDownloadOperationRequest
{
    public required IncomeVerificationDocumentsDownloadRequest Body { get; init; }
}
