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
using ThePlaidApi.Requests.ItemApi;

namespace ThePlaidApi.Api;

public sealed class ItemApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ItemApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// itemAccessTokenInvalidate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemAccessTokenInvalidateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// By default, the <c>access_token</c> associated with an Item does not expire and should be stored in a persistent, secure manner.
    /// <para>
    /// You can use the <c>/item/access_token/invalidate</c> endpoint to rotate the <c>access_token</c> associated with an Item. The endpoint returns a new <c>access_token</c> and immediately invalidates the previous <c>access_token</c>.
    /// </para>
    /// </remarks>
    public Task<ItemAccessTokenInvalidateResponse> ItemAccessTokenInvalidate(ItemAccessTokenInvalidateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/item/access_token/invalidate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ItemAccessTokenInvalidateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// itemApplicationList
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemApplicationListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List a user’s connected applications
    /// </remarks>
    public Task<ItemApplicationListResponse> ItemApplicationList(ItemApplicationListOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/item/application/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ItemApplicationListResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// itemApplicationScopesUpdate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemApplicationScopesUpdateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable consumers to update product access on selected accounts for an application.
    /// </remarks>
    public Task<ItemApplicationScopesUpdateResponse> ItemApplicationScopesUpdate(ItemApplicationScopesUpdateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/item/application/scopes/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ItemApplicationScopesUpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// itemCreatePublicToken
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemPublicTokenCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Note: As of July 2020, the <c>/item/public_token/create</c> endpoint is deprecated. Instead, use <c>/link/token/create</c> with an <c>access_token</c> to create a Link token for use with <see href="https://plaid.com/docs/link/update-mode">update mode</see>.
    /// <para>
    /// If you need your user to take action to restore or resolve an error associated with an Item, generate a public token with the <c>/item/public_token/create</c> endpoint and then initialize Link with that <c>public_token</c>.
    /// </para>
    /// <para>
    /// A <c>public_token</c> is one-time use and expires after 30 minutes. You use a <c>public_token</c> to initialize Link in <see href="https://plaid.com/docs/link/update-mode">update mode</see> for a particular Item. You can generate a <c>public_token</c> for an Item even if you did not use Link to create the Item originally.
    /// </para>
    /// <para>
    /// The <c>/item/public_token/create</c> endpoint is <b>not</b> used to create your initial <c>public_token</c>. If you have not already received an <c>access_token</c> for a specific Item, use Link to obtain your <c>public_token</c> instead. See the <see href="https://plaid.com/docs/quickstart">Quickstart</see> for more information.
    /// </para>
    /// </remarks>
    public Task<ItemPublicTokenCreateResponse> ItemCreatePublicToken(ItemCreatePublicTokenRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/item/public_token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ItemPublicTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// itemGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about the status of an Item.
    /// </remarks>
    public Task<ItemGetResponse> ItemGet(ItemGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/item/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ItemGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// itemImport
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemImportResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/item/import</c> creates an Item via your Plaid Exchange Integration and returns an <c>access_token</c>. As part of an <c>/item/import</c> request, you will include a User ID (<c>user_auth.user_id</c>) and Authentication Token (<c>user_auth.auth_token</c>) that enable data aggregation through your Plaid Exchange API endpoints. These authentication principals are to be chosen by you.
    /// <para>
    /// Upon creating an Item via <c>/item/import</c>, Plaid will automatically begin an extraction of that Item through the Plaid Exchange infrastructure you have already integrated. This will automatically generate the Plaid native account ID for the account the user will switch their direct deposit to (<c>target_account_id</c>).
    /// </para>
    /// </remarks>
    public Task<ItemImportResponse> ItemImport(ItemImportOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/item/import"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ItemImportResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// itemPublicTokenExchange
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemPublicTokenExchangeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Exchange a Link <c>public_token</c> for an API <c>access_token</c>. Link hands off the <c>public_token</c> client-side via the <c>onSuccess</c> callback once a user has successfully created an Item. The <c>public_token</c> is ephemeral and expires after 30 minutes.
    /// <para>
    /// The response also includes an <c>item_id</c> that should be stored with the <c>access_token</c>. The <c>item_id</c> is used to identify an Item in a webhook. The <c>item_id</c> can also be retrieved by making an <c>/item/get</c> request.
    /// </para>
    /// </remarks>
    public Task<ItemPublicTokenExchangeResponse> ItemPublicTokenExchange(ItemPublicTokenExchangeOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/item/public_token/exchange"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ItemPublicTokenExchangeResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// itemRemove
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemRemoveResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/item/remove</c>  endpoint allows you to remove an Item. Once removed, the <c>access_token</c>  associated with the Item is no longer valid and cannot be used to access any data that was associated with the Item.
    /// <para>
    /// Note that in the Development environment, issuing an <c>/item/remove</c>  request will not decrement your live credential count. To increase your credential account in Development, contact Support.
    /// </para>
    /// <para>
    /// Also note that for certain OAuth-based institutions, an Item removed via <c>/item/remove</c> may still show as an active connection in the institution's OAuth permission manager.
    /// </para>
    /// </remarks>
    public Task<ItemRemoveResponse> ItemRemove(ItemRemoveOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/item/remove"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ItemRemoveResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// itemWebhookUpdate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemWebhookUpdateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The POST <c>/item/webhook/update</c> allows you to update the webhook URL associated with an Item. This request triggers a <see href="https://plaid.com/docs/api/webhooks/#item-webhook-url-updated"><c>WEBHOOK_UPDATE_ACKNOWLEDGED</c></see> webhook to the newly specified webhook URL.
    /// </remarks>
    public Task<ItemWebhookUpdateResponse> ItemWebhookUpdate(ItemWebhookUpdateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/item/webhook/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ItemWebhookUpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);
}
