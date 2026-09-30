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
using ThePlaidApi.Requests.DepositSwitch;

namespace ThePlaidApi.Api;

public sealed class DepositSwitch
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DepositSwitch(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// depositSwitchAltCreate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DepositSwitchAltCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint provides an alternative to <c>/deposit_switch/create</c> for customers who have not yet fully integrated with Plaid Exchange. Like <c>/deposit_switch/create</c>, it creates a deposit switch entity that will be persisted throughout the lifecycle of the switch.
    /// </remarks>
    public Task<DepositSwitchAltCreateResponse> DepositSwitchAltCreate(DepositSwitchAltCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deposit_switch/alt/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DepositSwitchAltCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// depositSwitchCreate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DepositSwitchCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint creates a deposit switch entity that will be persisted throughout the lifecycle of the switch.
    /// </remarks>
    public Task<DepositSwitchCreateResponse> DepositSwitchCreate(DepositSwitchCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deposit_switch/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DepositSwitchCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// depositSwitchGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DepositSwitchGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint returns information related to how the user has configured their payroll allocation and the state of the switch. You can use this information to build logic related to the user's direct deposit allocation preferences.
    /// </remarks>
    public Task<DepositSwitchGetResponse> DepositSwitchGet(DepositSwitchGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deposit_switch/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DepositSwitchGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// depositSwitchTokenCreate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DepositSwitchTokenCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// In order for the end user to take action, you will need to create a public token representing the deposit switch. This token is used to initialize Link. It can be used one time and expires after 30 minutes.
    /// </remarks>
    public Task<DepositSwitchTokenCreateResponse> DepositSwitchTokenCreate(DepositSwitchTokenCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deposit_switch/token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DepositSwitchTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);
}
