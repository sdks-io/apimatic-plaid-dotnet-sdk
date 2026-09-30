using System.Net.Http;
using ThePlaidApi.Api;
using ThePlaidApi.Core;
using ThePlaidApi.Core.Logging;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi;

/// <summary>
/// The Plaid REST API. Please see https://plaid.com/docs/api for more details.
/// </summary>
public sealed class ThePlaidApiClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public ThePlaidApiClient(HttpClient httpClient, ThePlaidApiClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory = new HeadersFactory([
            new HeaderParam("User-Agent", "ThePlaidApiClient/2020-09-14_1.33.0 CSharp"),
            new HeaderParam("X-APIMatic-Lang", "CSharp"),
            new HeaderParam("X-APIMatic-Package-Version", "2020-09-14_1.33.0"),
            new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
            new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
            new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime),
        ]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry, options.TimeProvider);
        var httpLogger = new HttpLogger(options.Logging, "ThePlaidApiClient", options.TimeProvider);
        var responseContexts = new ResponseContextFactory(options.TimeProvider, options.StreamReadTimeout);
        _rawClient =
            new RawClient(
                httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks,
                responseContexts);
        _auth = new AuthSchemes(options);
    }

    public Accounts Accounts => field ??= new Accounts(_rawClient, _server, _auth);

    public ApplicationApi ApplicationApi => field ??= new ApplicationApi(_rawClient, _server, _auth);

    public AssetReportApi AssetReportApi => field ??= new AssetReportApi(_rawClient, _server, _auth);

    public Auth Auth => field ??= new Auth(_rawClient, _server, _auth);

    public BankTransferApi BankTransferApi => field ??= new BankTransferApi(_rawClient, _server, _auth);

    public Categories Categories => field ??= new Categories(_rawClient, _server);

    public DepositSwitch DepositSwitch => field ??= new DepositSwitch(_rawClient, _server, _auth);

    public Employers Employers => field ??= new Employers(_rawClient, _server, _auth);

    public Identity Identity => field ??= new Identity(_rawClient, _server, _auth);

    public Income Income => field ??= new Income(_rawClient, _server, _auth);

    public Institutions Institutions => field ??= new Institutions(_rawClient, _server, _auth);

    public Investments Investments => field ??= new Investments(_rawClient, _server, _auth);

    public ItemApi ItemApi => field ??= new ItemApi(_rawClient, _server, _auth);

    public Liabilities Liabilities => field ??= new Liabilities(_rawClient, _server, _auth);

    public Link Link => field ??= new Link(_rawClient, _server, _auth);

    public PaymentInitiation PaymentInitiation => field ??= new PaymentInitiation(_rawClient, _server, _auth);

    public ProcessorApi ProcessorApi => field ??= new ProcessorApi(_rawClient, _server, _auth);

    public Sandbox Sandbox => field ??= new Sandbox(_rawClient, _server, _auth);

    public Signal Signal => field ??= new Signal(_rawClient, _server, _auth);

    public Transactions Transactions => field ??= new Transactions(_rawClient, _server, _auth);

    public TransferApi TransferApi => field ??= new TransferApi(_rawClient, _server, _auth);

    public WebhookVerificationKey WebhookVerificationKey =>
        field ??= new WebhookVerificationKey(_rawClient, _server, _auth);
}
