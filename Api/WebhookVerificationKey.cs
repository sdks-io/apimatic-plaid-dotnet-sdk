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
using ThePlaidApi.Requests.WebhookVerificationKey;

namespace ThePlaidApi.Api;

public sealed class WebhookVerificationKey
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal WebhookVerificationKey(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// webhookVerificationKeyGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WebhookVerificationKeyGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Plaid signs all outgoing webhooks and provides JSON Web Tokens (JWTs) so that you can verify the authenticity of any incoming webhooks to your application. A message signature is included in the <c>Plaid-Verification</c> header.
    /// <para>
    /// The <c>/webhook_verification_key/get</c> endpoint provides a JSON Web Key (JWK) that can be used to verify a JWT.
    /// </para>
    /// </remarks>
    public Task<WebhookVerificationKeyGetResponse> WebhookVerificationKeyGet(WebhookVerificationKeyGetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/webhook_verification_key/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<WebhookVerificationKeyGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.PlaidClientId, _auth.PlaidSecret, _auth.PlaidVersion],
            requestOptions,
            cancellationToken);
}
