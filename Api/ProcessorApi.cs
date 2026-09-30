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
using ThePlaidApi.Requests.ProcessorApi;

namespace ThePlaidApi.Api;

public sealed class ProcessorApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ProcessorApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// processorApexProcessorTokenCreate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorTokenCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Used to create a token suitable for sending to Apex to enable Plaid-Apex integrations.
    /// </remarks>
    public Task<ProcessorTokenCreateResponse> ProcessorApexProcessorTokenCreate(ProcessorApexProcessorTokenCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/processor/apex/processor_token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ProcessorTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// processorAuthGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorAuthGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/processor/auth/get</c> endpoint returns the bank account and bank identification number (such as the routing number, for US accounts), for a checking or savings account that's associated with a given <c>processor_token</c>. The endpoint also returns high-level account data and balances when available.
    /// </remarks>
    public Task<ProcessorAuthGetResponse> ProcessorAuthGet(ProcessorAuthGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/processor/auth/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ProcessorAuthGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// processorBalanceGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorBalanceGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/processor/balance/get</c> endpoint returns the real-time balance for each of an Item's accounts. While other endpoints may return a balance object, only <c>/processor/balance/get</c> forces the available and current balance fields to be refreshed rather than cached.
    /// </remarks>
    public Task<ProcessorBalanceGetResponse> ProcessorBalanceGet(ProcessorBalanceGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/processor/balance/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ProcessorBalanceGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// processorBankTransferCreate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorBankTransferCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/processor/bank_transfer/create</c> endpoint to initiate a new bank transfer as a processor
    /// </remarks>
    public Task<ProcessorBankTransferCreateResponse> ProcessorBankTransferCreate(ProcessorBankTransferCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/processor/bank_transfer/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ProcessorBankTransferCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// processorIdentityGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorIdentityGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/processor/identity/get</c> endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.
    /// </remarks>
    public Task<ProcessorIdentityGetResponse> ProcessorIdentityGet(ProcessorIdentityGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/processor/identity/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ProcessorIdentityGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// processorStripeBankAccountTokenCreate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorStripeBankAccountTokenCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Used to create a token suitable for sending to Stripe to enable Plaid-Stripe integrations. For a detailed guide on integrating Stripe, see <see href="https://plaid.com/docs/auth/partnerships/stripe/">Add Stripe to your app</see>.
    /// </remarks>
    public Task<ProcessorStripeBankAccountTokenCreateResponse> ProcessorStripeBankAccountTokenCreate(ProcessorStripeBankAccountTokenCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/processor/stripe/bank_account_token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ProcessorStripeBankAccountTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// processorTokenCreate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorTokenCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Used to create a token suitable for sending to one of Plaid's partners to enable integrations. Note that Stripe partnerships use bank account tokens instead; see <c>/processor/stripe/bank_account_token/create</c> for creating tokens for use with Stripe integrations.
    /// </remarks>
    public Task<ProcessorTokenCreateResponse> ProcessorTokenCreate(ProcessorTokenCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/processor/token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ProcessorTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);
}
