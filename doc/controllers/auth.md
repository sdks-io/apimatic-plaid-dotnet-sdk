# Auth

```csharp
AuthApi authApi = client.AuthApi;
```

## Class Name

`AuthApi`


# Auth Get

The `/auth/get` endpoint returns the bank account and bank identification numbers (such as routing numbers, for US accounts) associated with an Item's checking and savings accounts, along with high-level account data and balances when available.

Note: This request may take some time to complete if `auth` was not specified as an initial product when creating the Item. This is because Plaid must communicate directly with the institution to retrieve the data.

Also note that `/auth/get` will not return data for any new accounts opened after the Item was created. To obtain data for new accounts, create a new Item.

Find out more here: [/api/products/#authget](/api/products/#authget)

```csharp
AuthGetAsync(
    Models.AuthGetRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AuthGetRequest`](../../doc/models/auth-get-request.md) | Body, Required | - |

## Response Type

**200**: success

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.AuthGetResponse](../../doc/models/auth-get-response.md).

## Example Usage

```csharp
AuthGetRequest body = new AuthGetRequest
{
    AccessToken = "access_token4",
};

try
{
    ApiResponse<AuthGetResponse> result = await authApi.AuthGetAsync(body);
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
| Default | Default error | [`ErrorErrorException`](../../doc/models/error-error-exception.md) |

