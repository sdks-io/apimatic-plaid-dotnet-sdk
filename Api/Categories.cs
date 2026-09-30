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
using ThePlaidApi.Requests.Categories;

namespace ThePlaidApi.Api;

public sealed class Categories
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Categories(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// categoriesGet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CategoriesGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Send a request to the <c>/categories/get</c>  endpoint to get detailed information on categories returned by Plaid. This endpoint does not require authentication.
    /// </remarks>
    public Task<CategoriesGetResponse> CategoriesGet(CategoriesGetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/categories/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CategoriesGetResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);
}
