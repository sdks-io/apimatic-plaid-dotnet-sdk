# Application

```csharp
ApplicationApi applicationApi = client.ApplicationApi;
```

## Class Name

`ApplicationApi`


# Application Get

Allows financial institutions to retrieve information about Plaid clients for the purpose of building control-tower experiences

```csharp
ApplicationGetAsync(
    Models.ApplicationGetRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ApplicationGetRequest`](../../doc/models/application-get-request.md) | Body, Required | - |

## Response Type

**200**: success

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ApplicationGetResponse](../../doc/models/application-get-response.md).

## Example Usage

```csharp
ApplicationGetRequest body = new ApplicationGetRequest
{
    ClientId = "client_id8",
    Secret = "secret8",
    ApplicationId = "application_id8",
};

try
{
    ApiResponse<ApplicationGetResponse> result = await applicationApi.ApplicationGetAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorErrorException)
    {
       // TODO: Handle ErrorErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`ErrorErrorException`](../../doc/models/error-error-exception.md) |

