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
using ThePlaidApi.Requests.Transactions;

namespace ThePlaidApi.Api;

public sealed class Transactions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Transactions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// transactionsGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionsGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/transactions/get</c> endpoint allows developers to receive user-authorized transaction data for credit, depository, and some loan-type accounts (only those with account subtype <c>student</c>; coverage may be limited). For transaction history from investments accounts, use the <see href="https://plaid.com/docs/api/products#investments">Investments endpoint</see> instead. Transaction data is standardized across financial institutions, and in many cases transactions are linked to a clean name, entity type, location, and category. Similarly, account data is standardized and returned with a clean name, number, balance, and other meta information where available.
    /// <para>
    /// Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.  Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in <c>/transactions/get</c>.  For more details, see <see href="https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions">Pending and posted transactions</see>.
    /// </para>
    /// <para>
    /// Due to the potentially large number of transactions associated with an Item, results are paginated. Manipulate the <c>count</c> and <c>offset</c> parameters in conjunction with the <c>total_transactions</c> response body field to fetch all available transactions.
    /// </para>
    /// <para>
    /// Data returned by <c>/transactions/get</c> will be the data available for the Item as of the most recent successful check for new transactions. Plaid typically checks for new data multiple times a day, but these checks may occur less frequently, such as once a day, depending on the institution. An Item's <c>status.transactions.last_successful_update</c> field will show the timestamp of the most recent successful update. To force Plaid to check for new transactions, you can use the <c>/transactions/refresh</c> endpoint.
    /// </para>
    /// <para>
    /// Note that data may not be immediately available to <c>/transactions/get</c>. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with <c>transactions</c>, or upon the first call to <c>/transactions/get</c>, if it wasn't. To be alerted when transaction data is ready to be fetched, listen for the <see href="https://plaid.com/docs/api/webhooks#transactions-initial_update"><c>INITIAL_UPDATE</c></see> and <see href="https://plaid.com/docs/api/webhooks#transactions-historical_update"><c>HISTORICAL_UPDATE</c></see> webhooks. If no transaction history is ready when <c>/transactions/get</c> is called, it will return a <c>PRODUCT_NOT_READY</c> error.
    /// </para>
    /// </remarks>
    public Task<TransactionsGetResponse> TransactionsGet(TransactionsGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/transactions/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransactionsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// transactionsRefresh
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionsRefreshResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/transactions/refresh</c> is an optional endpoint for users of the Transactions product. It initiates an on-demand extraction to fetch the newest transactions for an Item. This on-demand extraction takes place in addition to the periodic extractions that automatically occur multiple times a day for any Transactions-enabled Item. If changes to transactions are discovered after calling <c>/transactions/refresh</c>, Plaid will fire a webhook: <see href="https://plaid.com/docs/api/webhooks#deleted-transactions-detected"><c>TRANSACTIONS_REMOVED</c></see> will be fired if any removed transactions are detected, and <see href="https://plaid.com/docs/api/webhooks#transactions-default_update"><c>DEFAULT_UPDATE</c></see> will be fired if any new transactions are detected. New transactions can be fetched by calling <c>/transactions/get</c>.
    /// <para>
    /// Access to <c>/transactions/refresh</c> in Production is specific to certain pricing plans. If you cannot access <c>/transactions/refresh</c> in Production, <see href="https://www.plaid.com/contact">contact Sales</see> for assistance.
    /// </para>
    /// </remarks>
    public Task<TransactionsRefreshResponse> TransactionsRefresh(TransactionsRefreshOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/transactions/refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransactionsRefreshResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);
}
