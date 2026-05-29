
# Getting Started with The Plaid API

## Introduction

The Plaid REST API. Please see https://plaid.com/docs/api for more details.

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package ApimaticplaidSDK --version 0.0.1
```

You can also view the package at:
https://www.nuget.org/packages/ApimaticplaidSDK/0.0.1

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Environment | [`Environment`](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/README.md#environments) | The API environment. <br> **Default: `Environment.Production`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/log-builder.md) | Represents the logging configuration builder for API calls |
| PlaidClientIdCredentials | [`PlaidClientIdCredentials`](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |
| PlaidSecretCredentials | [`PlaidSecretCredentials`](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/auth/custom-header-signature-1.md) | The Credentials Setter for Custom Header Signature |
| PlaidVersionCredentials | [`PlaidVersionCredentials`](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/auth/custom-header-signature-2.md) | The Credentials Setter for Custom Header Signature |

The API client can be initialized as follows:

### Code-Based Initialization

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

### Configuration-Based Initialization

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

See the [Configuration-Based Initialization](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/configuration-based-initialization.md) section for details.

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Production | **Default** Production |
| Environment2 | Development |
| Environment3 | Sandbox |

## Authorization

This API uses the following authentication schemes.

* [`PLAID-CLIENT-ID (Custom Header Signature)`](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/auth/custom-header-signature.md)
* [`PLAID-SECRET (Custom Header Signature)`](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/auth/custom-header-signature-1.md)
* [`Plaid-Version (Custom Header Signature)`](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/auth/custom-header-signature-2.md)

## List of APIs

* [Item](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/item.md)
* [Asset Report](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/asset-report.md)
* [Processor](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/processor.md)
* [Payment Initiation](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/payment-initiation.md)
* [Sandbox](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/sandbox.md)
* [Investments](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/investments.md)
* [Institutions](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/institutions.md)
* [Application](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/application.md)
* [Accounts](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/accounts.md)
* [Identity](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/identity.md)
* [Liabilities](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/liabilities.md)
* [Auth](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/auth.md)
* [Transactions](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/transactions.md)
* [Categories](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/categories.md)
* [Webhook Verification Key](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/webhook-verification-key.md)
* [Deposit Switch](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/deposit-switch.md)
* [Link](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/link.md)
* [Transfer](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/transfer.md)
* [Bank Transfer](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/bank-transfer.md)
* [Employers](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/employers.md)
* [Income](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/income.md)
* [Signal](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/controllers/signal.md)

## SDK Infrastructure

### Configuration

* [Configuration-Based Initialization](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/configuration-based-initialization.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/http-client-configuration-builder.md)
* [LogBuilder](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/log-builder.md)
* [LogRequestBuilder](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/log-request-builder.md)
* [LogResponseBuilder](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/log-response-builder.md)
* [ProxyConfigurationBuilder](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/http-callback.md)
* [HttpContext](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/http-context.md)
* [HttpRequest](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/http-string-response.md)

### Utilities

* [ApiException](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/api-exception.md)
* [ApiResponse](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/api-response.md)
* [ApiHelper](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/api-helper.md)
* [CustomDateTimeConverter](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/custom-date-time-converter.md)
* [UnixDateTimeConverter](https://www.github.com/sdks-io/apimatic-plaid-dotnet-sdk/tree/0.0.1/doc/unix-date-time-converter.md)

