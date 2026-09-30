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
using ThePlaidApi.Requests.AssetReportApi;

namespace ThePlaidApi.Api;

public sealed class AssetReportApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AssetReportApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// assetReportAuditCopyCreate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportAuditCopyCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Plaid can provide an Audit Copy of any Asset Report directly to a participating third party on your behalf. For example, Plaid can supply an Audit Copy directly to Fannie Mae on your behalf if you participate in the Day 1 Certainty™ program. An Audit Copy contains the same underlying data as the Asset Report.
    /// <para>
    /// To grant access to an Audit Copy, use the <c>/asset_report/audit_copy/create</c> endpoint to create an <c>audit_copy_token</c> and then pass that token to the third party who needs access. Each third party has its own <c>auditor_id</c>, for example <c>fannie_mae</c>. You’ll need to create a separate Audit Copy for each third party to whom you want to grant access to the Report.
    /// </para>
    /// </remarks>
    public Task<AssetReportAuditCopyCreateResponse> AssetReportAuditCopyCreate(AssetReportAuditCopyCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/asset_report/audit_copy/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AssetReportAuditCopyCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// assetReportAuditCopyGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/asset_report/audit_copy/get</c> allows auditors to get a copy of an Asset Report that was previously shared via the <c>/asset_report/audit_copy/create</c> endpoint.  The caller of <c>/asset_report/audit_copy/create</c> must provide the <c>audit_copy_token</c> to the auditor.  This token can then be used to call <c>/asset_report/audit_copy/create</c>.
    /// </remarks>
    public Task<AssetReportGetResponse> AssetReportAuditCopyGet(AssetReportAuditCopyGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/asset_report/audit_copy/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AssetReportGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// assetReportAuditCopyRemove
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportAuditCopyRemoveResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/asset_report/audit_copy/remove</c> endpoint allows you to remove an Audit Copy. Removing an Audit Copy invalidates the <c>audit_copy_token</c> associated with it, meaning both you and any third parties holding the token will no longer be able to use it to access Report data. Items associated with the Asset Report, the Asset Report itself and other Audit Copies of it are not affected and will remain accessible after removing the given Audit Copy.
    /// </remarks>
    public Task<AssetReportAuditCopyRemoveResponse> AssetReportAuditCopyRemove(AssetReportAuditCopyRemoveOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/asset_report/audit_copy/remove"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AssetReportAuditCopyRemoveResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// assetReportCreate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/asset_report/create</c> endpoint initiates the process of creating an Asset Report, which can then be retrieved by passing the <c>asset_report_token</c> return value to the <c>/asset_report/get</c> or <c>/asset_report/pdf/get</c> endpoints.
    /// <para>
    /// The Asset Report takes some time to be created and is not available immediately after calling <c>/asset_report/create</c>. When the Asset Report is ready to be retrieved using <c>/asset_report/get</c> or <c>/asset_report/pdf/get</c>, Plaid will fire a <c>PRODUCT_READY</c> webhook. For full details of the webhook schema, see <see href="https://plaid.com/docs/api/webhooks/#Assets-webhooks">Asset Report webhooks</see>.
    /// </para>
    /// <para>
    /// The <c>/asset_report/create</c> endpoint creates an Asset Report at a moment in time. Asset Reports are immutable. To get an updated Asset Report, use the <c>/asset_report/refresh</c> endpoint.
    /// </para>
    /// </remarks>
    public Task<AssetReportCreateResponse> AssetReportCreate(AssetReportCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/asset_report/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AssetReportCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// assetReportFilter
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportFilterResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// By default, an Asset Report will contain all of the accounts on a given Item. In some cases, you may not want the Asset Report to contain all accounts. For example, you might have the end user choose which accounts are relevant in Link using the Account Select view, which you can enable in the dashboard. Or, you might always exclude certain account types or subtypes, which you can identify by using the <c>/accounts/get</c> endpoint. To narrow an Asset Report to only a subset of accounts, use the <c>/asset_report/filter</c> endpoint.
    /// <para>
    /// To exclude certain Accounts from an Asset Report, first use the <c>/asset_report/create</c> endpoint to create the report, then send the <c>asset_report_token</c> along with a list of <c>account_ids</c> to exclude to the <c>/asset_report/filter</c> endpoint, to create a new Asset Report which contains only a subset of the original Asset Report's data.
    /// </para>
    /// <para>
    /// Because Asset Reports are immutable, calling <c>/asset_report/filter</c> does not alter the original Asset Report in any way; rather, <c>/asset_report/filter</c> creates a new Asset Report with a new token and id. Asset Reports created via <c>/asset_report/filter</c> do not contain new Asset data, and are not billed.
    /// </para>
    /// <para>
    /// Plaid will fire a <see href="https://plaid.com/docs/api/webhooks"><c>PRODUCT_READY</c></see> webhook once generation of the filtered Asset Report has completed.
    /// </para>
    /// </remarks>
    public Task<AssetReportFilterResponse> AssetReportFilter(AssetReportFilterOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/asset_report/filter"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AssetReportFilterResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// assetReportGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/asset_report/get</c> endpoint retrieves the Asset Report in JSON format. Before calling <c>/asset_report/get</c>, you must first create the Asset Report using <c>/asset_report/create</c> (or filter an Asset Report using <c>/asset_report/filter</c>) and then wait for the <see href="https://plaid.com/docs/api/webhooks"><c>PRODUCT_READY</c></see> webhook to fire, indicating that the Report is ready to be retrieved.
    /// <para>
    /// By default, an Asset Report includes transaction descriptions as returned by the bank, as opposed to parsed and categorized by Plaid. You can also receive cleaned and categorized transactions, as well as additional insights like merchant name or location information. We call this an Asset Report with Insights. An Asset Report with Insights provides transaction category, location, and merchant information in addition to the transaction strings provided in a standard Asset Report.
    /// </para>
    /// <para>
    /// To retrieve an Asset Report with Insights, call the <c>/asset_report/get</c> endpoint with <c>include_insights</c> set to <c>true</c>.
    /// </para>
    /// </remarks>
    public Task<AssetReportGetResponse> AssetReportGet(AssetReportGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/asset_report/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AssetReportGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// assetReportPdfGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/asset_report/pdf/get</c> endpoint retrieves the Asset Report in PDF format. Before calling <c>/asset_report/pdf/get</c>, you must first create the Asset Report using <c>/asset_report/create</c> (or filter an Asset Report using <c>/asset_report/filter</c>) and then wait for the <see href="https://plaid.com/docs/api/webhooks"><c>PRODUCT_READY</c></see> webhook to fire, indicating that the Report is ready to be retrieved.
    /// <para>
    /// The response to <c>/asset_report/pdf/get</c> is the PDF binary data. The <c>request_id</c>  is returned in the <c>Plaid-Request-ID</c> header.
    /// </para>
    /// <para>
    /// <see href="https://plaid.com/documents/sample-asset-report.pdf">View a sample PDF Asset Report</see>.
    /// </para>
    /// </remarks>
    public Task AssetReportPdfGet(AssetReportPdfGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/asset_report/pdf/get"),
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
    /// assetReportRefresh
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportRefreshResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// An Asset Report is an immutable snapshot of a user's assets. In order to "refresh" an Asset Report you created previously, you can use the <c>/asset_report/refresh</c> endpoint to create a new Asset Report based on the old one, but with the most recent data available.
    /// <para>
    /// The new Asset Report will contain the same Items as the original Report, as well as the same filters applied by any call to <c>/asset_report/filter</c>. By default, the new Asset Report will also use the same parameters you submitted with your original <c>/asset_report/create</c> request, but the original <c>days_requested</c> value and the values of any parameters in the <c>options</c> object can be overridden with new values. To change these arguments, simply supply new values for them in your request to <c>/asset_report/refresh</c>. Submit an empty string ("") for any previously-populated fields you would like set as empty.
    /// </para>
    /// </remarks>
    public Task<AssetReportRefreshResponse> AssetReportRefresh(AssetReportRefreshOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/asset_report/refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AssetReportRefreshResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// assetReportRemove
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportRemoveResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/item/remove</c> endpoint allows you to invalidate an <c>access_token</c>, meaning you will not be able to create new Asset Reports with it. Removing an Item does not affect any Asset Reports or Audit Copies you have already created, which will remain accessible until you remove them specifically.
    /// <para>
    /// The <c>/asset_report/remove</c> endpoint allows you to remove an Asset Report. Removing an Asset Report invalidates its <c>asset_report_token</c>, meaning you will no longer be able to use it to access Report data or create new Audit Copies. Removing an Asset Report does not affect the underlying Items, but does invalidate any <c>audit_copy_tokens</c> associated with the Asset Report.
    /// </para>
    /// </remarks>
    public Task<AssetReportRemoveResponse> AssetReportRemove(AssetReportRemoveOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/asset_report/remove"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AssetReportRemoveResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);
}
