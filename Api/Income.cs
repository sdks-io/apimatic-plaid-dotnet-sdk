using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ThePlaidApi.Core;
using ThePlaidApi.Core.ErrorResponse;
using ThePlaidApi.Core.Exceptions;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Request;
using ThePlaidApi.Core.Response;
using ThePlaidApi.Models;
using ThePlaidApi.Requests.Income;

namespace ThePlaidApi.Api;

public sealed class Income
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Income(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// incomeVerificationCreate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IncomeVerificationCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/income/verification/create</c> begins the income verification process by returning an <c>income_verification_id</c>. You can then provide the <c>income_verification_id</c> to <c>/link/token/create</c> under the <c>income_verification</c> parameter in order to create a Link instance that will prompt the user to go through the income verification flow. Plaid will fire an <c>INCOME</c> webhook once the user completes the Payroll Income flow, or when the uploaded documents in the Document Income flow have finished processing.
    /// </remarks>
    public Task<IncomeVerificationCreateResponse> IncomeVerificationCreate(IncomeVerificationCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/income/verification/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IncomeVerificationCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// incomeVerificationDocumentsDownload
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/income/verification/documents/download</c> provides the ability to download the source paystub PDF that the end user uploaded via Paystub Import.
    /// <para>
    /// The response to <c>/income/verification/documents/download</c> is a ZIP file in binary data. The <c>request_id</c>  is returned in the <c>Plaid-Request-ID</c> header.
    /// </para>
    /// <para>
    /// For Payroll Income, the most recent file available for download with the payroll provider will also be available from this endpoint.
    /// </para>
    /// </remarks>
    public Task IncomeVerificationDocumentsDownload(IncomeVerificationDocumentsDownloadOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/income/verification/documents/download"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// incomeVerificationPaystubGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IncomeVerificationPaystubGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// (Deprecated) Retrieve information from a single paystub used for income verification
    /// </remarks>
    public Task<IncomeVerificationPaystubGetResponse> IncomeVerificationPaystubGet(IncomeVerificationPaystubGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/income/verification/paystub/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IncomeVerificationPaystubGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// incomeVerificationPaystubsGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IncomeVerificationPaystubsGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/income/verification/paystubs/get</c> returns the information collected from the paystubs that were used to verify an end user's income. It can be called once the status of the verification has been set to <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>, as reported by the <c>INCOME: verification_status</c> webhook. Attempting to call the endpoint before verification has been completed will result in an error.
    /// </remarks>
    public Task<IncomeVerificationPaystubsGetResponse> IncomeVerificationPaystubsGet(IncomeVerificationPaystubsGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/income/verification/paystubs/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IncomeVerificationPaystubsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// incomeVerificationPrecheck
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IncomeVerificationPrecheckResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/income/verification/precheck</c> returns whether a given user is supportable by the income product
    /// </remarks>
    public Task<IncomeVerificationPrecheckResponse> IncomeVerificationPrecheck(IncomeVerificationPrecheckOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/income/verification/precheck"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IncomeVerificationPrecheckResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// incomeVerificationRefresh
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IncomeVerificationRefreshResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/income/verification/refresh</c> refreshes a given income verification.
    /// </remarks>
    public Task<IncomeVerificationRefreshResponse> IncomeVerificationRefresh(IncomeVerificationRefreshOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/income/verification/refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IncomeVerificationRefreshResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// incomeVerificationSummaryGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IncomeVerificationSummaryGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/income/verification/summary/get</c> returns a verification summary for the income that was verified for an end user. It can be called once the status of the verification has been set to <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>, as reported by the <c>INCOME: verification_status</c> webhook. Attempting to call the endpoint before verification has been completed will result in an error.
    /// </remarks>
    public Task<IncomeVerificationSummaryGetResponse> IncomeVerificationSummaryGet(IncomeVerificationSummaryGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/income/verification/summary/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IncomeVerificationSummaryGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// incomeVerificationTaxformsGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IncomeVerificationTaxformsGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/income/verification/taxforms/get</c> returns the information collected from taxforms that were used to verify an end user's. It can be called once the status of the verification has been set to <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>, as reported by the <c>INCOME: verification_status</c> webhook. Attempting to call the endpoint before verification has been completed will result in an error.
    /// </remarks>
    public Task<IncomeVerificationTaxformsGetResponse> IncomeVerificationTaxformsGet(IncomeVerificationTaxformsGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/income/verification/taxforms/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IncomeVerificationTaxformsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);
}
