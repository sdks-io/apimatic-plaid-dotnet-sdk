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
using ThePlaidApi.Requests.TransferApi;

namespace ThePlaidApi.Api;

public sealed class TransferApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TransferApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// transferAuthorizationCreate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferAuthorizationCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/authorization/create</c> endpoint to determine transfer failure risk.
    /// <para>
    /// In Plaid's sandbox environment the decisions will be returned as follows:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>To approve a transfer, make an authorization request with an <c>amount</c> less than the available balance in the account.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>To decline a transfer with the rationale code <c>NSF</c>, the available balance on the account must be less than the authorization <c>amount</c>. See <see href="https://plaid.com/docs/sandbox/user-custom/">Create Sandbox test data</see> for details on how to customize data in Sandbox.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>To decline a transfer with the rationale code <c>RISK</c>, the available balance on the account must be exactly $0. See <see href="https://plaid.com/docs/sandbox/user-custom/">Create Sandbox test data</see> for details on how to customize data in Sandbox.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>To permit a transfer with the rationale code <c>MANUALLY_VERIFIED_ITEM</c>, create an Item in Link through the <see href="https://plaid.com/docs/auth/coverage/testing/#testing-same-day-micro-deposits">Same Day Micro-deposits flow</see>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>To permit a transfer with the rationale code <c>LOGIN_REQUIRED</c>, <see href="https://plaid.com/docs/sandbox/#item_login_required">reset the login for an Item</see>.</description></item>
    /// </list>
    /// <para>
    /// All username/password combinations other than the ones listed above will result in a decision of permitted and rationale code <c>ERROR</c>.
    /// </para>
    /// </remarks>
    public Task<TransferAuthorizationCreateResponse> TransferAuthorizationCreate(TransferAuthorizationCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/transfer/authorization/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransferAuthorizationCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// transferCancel
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferCancelResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/cancel</c> endpoint to cancel a transfer.  A transfer is eligible for cancelation if the <c>cancellable</c> property returned by <c>/transfer/get</c> is <c>true</c>.
    /// </remarks>
    public Task<TransferCancelResponse> TransferCancel(TransferCancelOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/transfer/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransferCancelResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// transferCreate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/create</c> endpoint to initiate a new transfer.
    /// </remarks>
    public Task<TransferCreateResponse> TransferCreate(TransferCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/transfer/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransferCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// transferEventList
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferEventListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/event/list</c> endpoint to get a list of transfer events based on specified filter criteria.
    /// </remarks>
    public Task<TransferEventListResponse> TransferEventList(TransferEventListOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/transfer/event/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransferEventListResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// transferEventSync
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferEventSyncResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/transfer/event/sync</c> allows you to request up to the next 25 transfer events that happened after a specific <c>event_id</c>. Use the <c>/transfer/event/sync</c> endpoint to guarantee you have seen all transfer events.
    /// </remarks>
    public Task<TransferEventSyncResponse> TransferEventSync(TransferEventSyncOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/transfer/event/sync"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransferEventSyncResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// transferGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/transfer/get</c> fetches information about the transfer corresponding to the given <c>transfer_id</c>.
    /// </remarks>
    public Task<TransferGetResponse> TransferGet(TransferGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/transfer/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransferGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// transferList
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/list</c> endpoint to see a list of all your transfers and their statuses. Results are paginated; use the <c>count</c> and <c>offset</c> query parameters to retrieve the desired transfers.
    /// </remarks>
    public Task<TransferListResponse> TransferList(TransferListOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/transfer/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransferListResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);
}
