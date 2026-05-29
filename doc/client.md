
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Environment | [`Environment`](../README.md#environments) | The API environment. <br> **Default: `Environment.Production`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](../doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](../doc/log-builder.md) | Represents the logging configuration builder for API calls |
| PlaidClientIdCredentials | [`PlaidClientIdCredentials`](auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |
| PlaidSecretCredentials | [`PlaidSecretCredentials`](auth/custom-header-signature-1.md) | The Credentials Setter for Custom Header Signature |
| PlaidVersionCredentials | [`PlaidVersionCredentials`](auth/custom-header-signature-2.md) | The Credentials Setter for Custom Header Signature |

The API client can be initialized as follows:

## Code-Based Initialization

```csharp
using Microsoft.Extensions.Logging;
using Plaid.Standard;
using Plaid.Standard.Authentication;

namespace ConsoleApp;

PlaidClient client = new PlaidClient.Builder()
    .PlaidClientIdCredentials(
        new PlaidClientIdModel.Builder(
            "PLAID-CLIENT-ID"
        )
        .Build())
    .PlaidSecretCredentials(
        new PlaidSecretModel.Builder(
            "PLAID-SECRET"
        )
        .Build())
    .PlaidVersionCredentials(
        new PlaidVersionModel.Builder(
            "Plaid-Version"
        )
        .Build())
    .HttpClientConfig(httpClientConfig =>
        httpClientConfig.Timeout(TimeSpan.FromSeconds(100)))
    .Environment(Plaid.Standard.Environment.Production)
    .LoggingConfig(config => config
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```

## Configuration-Based Initialization

```csharp
using Plaid.Standard;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp;

// Build the IConfiguration using .NET conventions (JSON, environment, etc.)
var configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables() // [optional] read environment variables
    .Build();

// Instantiate your SDK and configure it from IConfiguration
var client = PlaidClient
    .FromConfiguration(configuration.GetSection("Plaid"));
```

See the [Configuration-Based Initialization](../doc/configuration-based-initialization.md) section for details.

## The Plaid APIClient Class

The gateway for the SDK. This class acts as a factory for the Apis and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| ItemApi | Gets ItemApi. |
| AssetReportApi | Gets AssetReportApi. |
| ProcessorApi | Gets ProcessorApi. |
| PaymentInitiationApi | Gets PaymentInitiationApi. |
| SandboxApi | Gets SandboxApi. |
| InvestmentsApi | Gets InvestmentsApi. |
| InstitutionsApi | Gets InstitutionsApi. |
| ApplicationApi | Gets ApplicationApi. |
| AccountsApi | Gets AccountsApi. |
| IdentityApi | Gets IdentityApi. |
| LiabilitiesApi | Gets LiabilitiesApi. |
| AuthApi | Gets AuthApi. |
| TransactionsApi | Gets TransactionsApi. |
| CategoriesApi | Gets CategoriesApi. |
| WebhookVerificationKeyApi | Gets WebhookVerificationKeyApi. |
| DepositSwitchApi | Gets DepositSwitchApi. |
| LinkApi | Gets LinkApi. |
| TransferApi | Gets TransferApi. |
| BankTransferApi | Gets BankTransferApi. |
| EmployersApi | Gets EmployersApi. |
| IncomeApi | Gets IncomeApi. |
| SignalApi | Gets SignalApi. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](../doc/http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| PlaidClientIdCredentials | Gets the credentials to use with PlaidClientId. | [`IPlaidClientIdCredentials`](auth/custom-header-signature.md) |
| PlaidSecretCredentials | Gets the credentials to use with PlaidSecret. | [`IPlaidSecretCredentials`](auth/custom-header-signature-1.md) |
| PlaidVersionCredentials | Gets the credentials to use with PlaidVersion. | [`IPlaidVersionCredentials`](auth/custom-header-signature-2.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the The Plaid APIClient using the values provided for the builder. | `Builder` |

## The Plaid APIClient Builder Class

Class to build instances of The Plaid APIClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](../doc/http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `PlaidClientIdCredentials(Action<PlaidClientIdModel.Builder> action)` | Sets credentials for PlaidClientId. | `Builder` |
| `PlaidSecretCredentials(Action<PlaidSecretModel.Builder> action)` | Sets credentials for PlaidSecret. | `Builder` |
| `PlaidVersionCredentials(Action<PlaidVersionModel.Builder> action)` | Sets credentials for PlaidVersion. | `Builder` |

