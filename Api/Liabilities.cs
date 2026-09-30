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
using ThePlaidApi.Requests.Liabilities;

namespace ThePlaidApi.Api;

public sealed class Liabilities
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Liabilities(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// liabilitiesGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LiabilitiesGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/liabilities/get</c> endpoint returns various details about an Item with loan or credit accounts. Liabilities data is available primarily for US financial institutions, with some limited coverage of Canadian institutions. Currently supported account types are account type <c>credit</c> with account subtype <c>credit card</c> or <c>paypal</c>, and account type <c>loan</c> with account subtype <c>student</c> or <c>mortgage</c>. To limit accounts listed in Link to types and subtypes supported by Liabilities, you can use the <c>account_filters</c> parameter when <see href="https://plaid.com/docs/api/tokens/#linktokencreate">creating a Link token</see>.
    /// <para>
    /// The types of information returned by Liabilities can include balances and due dates, loan terms, and account details such as original loan amount and guarantor. Data is refreshed approximately once per day; the latest data can be retrieved by calling <c>/liabilities/get</c>.
    /// </para>
    /// <para>
    /// Note: This request may take some time to complete if <c>liabilities</c> was not specified as an initial product when creating the Item. This is because Plaid must communicate directly with the institution to retrieve the additional data.
    /// </para>
    /// </remarks>
    public Task<LiabilitiesGetResponse> LiabilitiesGet(LiabilitiesGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/liabilities/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<LiabilitiesGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);
}
