# Item

```csharp
ItemApi itemApi = client.ItemApi;
```

## Class Name

`ItemApi`

## Methods

* [Item Access Token Invalidate](../../doc/controllers/item.md#item-access-token-invalidate)
* [Item Remove](../../doc/controllers/item.md#item-remove)
* [Item Application List](../../doc/controllers/item.md#item-application-list)
* [Item Public Token Exchange](../../doc/controllers/item.md#item-public-token-exchange)
* [Item Get](../../doc/controllers/item.md#item-get)
* [Item Create Public Token](../../doc/controllers/item.md#item-create-public-token)
* [Item Application Scopes Update](../../doc/controllers/item.md#item-application-scopes-update)
* [Item Webhook Update](../../doc/controllers/item.md#item-webhook-update)
* [Item Import](../../doc/controllers/item.md#item-import)


# Item Access Token Invalidate

By default, the `access_token` associated with an Item does not expire and should be stored in a persistent, secure manner.

You can use the `/item/access_token/invalidate` endpoint to rotate the `access_token` associated with an Item. The endpoint returns a new `access_token` and immediately invalidates the previous `access_token`.

Find out more here: [/api/tokens/#itemaccess_tokeninvalidate](/api/tokens/#itemaccess_tokeninvalidate)

```csharp
ItemAccessTokenInvalidateAsync(
    Models.ItemAccessTokenInvalidateRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ItemAccessTokenInvalidateRequest`](../../doc/models/item-access-token-invalidate-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ItemAccessTokenInvalidateResponse](../../doc/models/item-access-token-invalidate-response.md).

## Example Usage

```csharp
ItemAccessTokenInvalidateRequest body = new ItemAccessTokenInvalidateRequest
{
    AccessToken = "access_token4",
};

try
{
    ApiResponse<ItemAccessTokenInvalidateResponse> result = await itemApi.ItemAccessTokenInvalidateAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "new_access_token": "access-sandbox-8ab976e6-64bc-4b38-98f7-731e7a349970",
  "request_id": "m8MDnv9okwxFNBV"
}
```


# Item Remove

The `/item/remove`  endpoint allows you to remove an Item. Once removed, the `access_token`  associated with the Item is no longer valid and cannot be used to access any data that was associated with the Item.

Note that in the Development environment, issuing an `/item/remove`  request will not decrement your live credential count. To increase your credential account in Development, contact Support.

Also note that for certain OAuth-based institutions, an Item removed via `/item/remove` may still show as an active connection in the institution's OAuth permission manager.

Find out more here: [/api/items/#itemremove](/api/items/#itemremove)

```csharp
ItemRemoveAsync(
    Models.ItemRemoveRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ItemRemoveRequest`](../../doc/models/item-remove-request.md) | Body, Required | - |

## Response Type

**200**: success

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ItemRemoveResponse](../../doc/models/item-remove-response.md).

## Example Usage

```csharp
ItemRemoveRequest body = new ItemRemoveRequest
{
    AccessToken = "access_token4",
};

try
{
    ApiResponse<ItemRemoveResponse> result = await itemApi.ItemRemoveAsync(body);
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

## Example Response *(as JSON)*

```json
{
  "request_id": "m8MDnv9okwxFNBV"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`ErrorErrorException`](../../doc/models/error-error-exception.md) |


# Item Application List

List a user’s connected applications

```csharp
ItemApplicationListAsync(
    Models.ItemApplicationListRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ItemApplicationListRequest`](../../doc/models/item-application-list-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ItemApplicationListResponse](../../doc/models/item-application-list-response.md).

## Example Usage

```csharp
ItemApplicationListRequest body = new ItemApplicationListRequest
{
};

try
{
    ApiResponse<ItemApplicationListResponse> result = await itemApi.ItemApplicationListAsync(body);
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


# Item Public Token Exchange

Exchange a Link `public_token` for an API `access_token`. Link hands off the `public_token` client-side via the `onSuccess` callback once a user has successfully created an Item. The `public_token` is ephemeral and expires after 30 minutes.

The response also includes an `item_id` that should be stored with the `access_token`. The `item_id` is used to identify an Item in a webhook. The `item_id` can also be retrieved by making an `/item/get` request.

Find out more here: [/api/tokens/#itempublic_tokenexchange](/api/tokens/#itempublic_tokenexchange)

```csharp
ItemPublicTokenExchangeAsync(
    Models.ItemPublicTokenExchangeRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ItemPublicTokenExchangeRequest`](../../doc/models/item-public-token-exchange-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ItemPublicTokenExchangeResponse](../../doc/models/item-public-token-exchange-response.md).

## Example Usage

```csharp
ItemPublicTokenExchangeRequest body = new ItemPublicTokenExchangeRequest
{
    PublicToken = "public_token8",
};

try
{
    ApiResponse<ItemPublicTokenExchangeResponse> result = await itemApi.ItemPublicTokenExchangeAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "access_token": "access-sandbox-de3ce8ef-33f8-452c-a685-8671031fc0f6",
  "item_id": "M5eVJqLnv3tbzdngLDp9FL5OlDNxlNhlE55op",
  "request_id": "Aim3b"
}
```


# Item Get

Returns information about the status of an Item.

Find out more here: [/api/items/#itemget](/api/items/#itemget)

```csharp
ItemGetAsync(
    Models.ItemGetRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ItemGetRequest`](../../doc/models/item-get-request.md) | Body, Required | - |

## Response Type

**200**: success

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ItemGetResponse](../../doc/models/item-get-response.md).

## Example Usage

```csharp
ItemGetRequest body = new ItemGetRequest
{
    AccessToken = "access_token4",
};

try
{
    ApiResponse<ItemGetResponse> result = await itemApi.ItemGetAsync(body);
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


# Item Create Public Token

Note: As of July 2020, the `/item/public_token/create` endpoint is deprecated. Instead, use `/link/token/create` with an `access_token` to create a Link token for use with [update mode](https://plaid.com/docs/link/update-mode).

If you need your user to take action to restore or resolve an error associated with an Item, generate a public token with the `/item/public_token/create` endpoint and then initialize Link with that `public_token`.

A `public_token` is one-time use and expires after 30 minutes. You use a `public_token` to initialize Link in [update mode](https://plaid.com/docs/link/update-mode) for a particular Item. You can generate a `public_token` for an Item even if you did not use Link to create the Item originally.

The `/item/public_token/create` endpoint is **not** used to create your initial `public_token`. If you have not already received an `access_token` for a specific Item, use Link to obtain your `public_token` instead. See the [Quickstart](https://plaid.com/docs/quickstart) for more information.

Find out more here: [/api/tokens/#itempublic_tokencreate](/api/tokens/#itempublic_tokencreate)

```csharp
ItemCreatePublicTokenAsync(
    Models.ItemPublicTokenCreateRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ItemPublicTokenCreateRequest`](../../doc/models/item-public-token-create-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ItemPublicTokenCreateResponse](../../doc/models/item-public-token-create-response.md).

## Example Usage

```csharp
ItemPublicTokenCreateRequest body = new ItemPublicTokenCreateRequest
{
    AccessToken = "access_token4",
};

try
{
    ApiResponse<ItemPublicTokenCreateResponse> result = await itemApi.ItemCreatePublicTokenAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "public_token": "public-sandbox-b0e2c4ee-a763-4df5-bfe9-46a46bce993d",
  "request_id": "Aim3b"
}
```


# Item Application Scopes Update

Enable consumers to update product access on selected accounts for an application.

```csharp
ItemApplicationScopesUpdateAsync(
    Models.ItemApplicationScopesUpdateRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ItemApplicationScopesUpdateRequest`](../../doc/models/item-application-scopes-update-request.md) | Body, Required | - |

## Response Type

**200**: success

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ItemApplicationScopesUpdateResponse](../../doc/models/item-application-scopes-update-response.md).

## Example Usage

```csharp
ItemApplicationScopesUpdateRequest body = new ItemApplicationScopesUpdateRequest
{
    AccessToken = "access_token4",
    ApplicationId = "application_id8",
    Scopes = new Scopes
    {
        NewAccounts = true,
    },
    Context = ScopesContext.Enrollment,
};

try
{
    ApiResponse<ItemApplicationScopesUpdateResponse> result = await itemApi.ItemApplicationScopesUpdateAsync(body);
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


# Item Webhook Update

The POST `/item/webhook/update` allows you to update the webhook URL associated with an Item. This request triggers a [`WEBHOOK_UPDATE_ACKNOWLEDGED`](https://plaid.com/docs/api/webhooks/#item-webhook-url-updated) webhook to the newly specified webhook URL.

Find out more here: [/api/items/#itemwebhookupdate](/api/items/#itemwebhookupdate)

```csharp
ItemWebhookUpdateAsync(
    Models.ItemWebhookUpdateRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ItemWebhookUpdateRequest`](../../doc/models/item-webhook-update-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ItemWebhookUpdateResponse](../../doc/models/item-webhook-update-response.md).

## Example Usage

```csharp
ItemWebhookUpdateRequest body = new ItemWebhookUpdateRequest
{
    AccessToken = "access_token4",
    Webhook = "webhook4",
};

try
{
    ApiResponse<ItemWebhookUpdateResponse> result = await itemApi.ItemWebhookUpdateAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```


# Item Import

`/item/import` creates an Item via your Plaid Exchange Integration and returns an `access_token`. As part of an `/item/import` request, you will include a User ID (`user_auth.user_id`) and Authentication Token (`user_auth.auth_token`) that enable data aggregation through your Plaid Exchange API endpoints. These authentication principals are to be chosen by you.

Upon creating an Item via `/item/import`, Plaid will automatically begin an extraction of that Item through the Plaid Exchange infrastructure you have already integrated. This will automatically generate the Plaid native account ID for the account the user will switch their direct deposit to (`target_account_id`).

```csharp
ItemImportAsync(
    Models.ItemImportRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ItemImportRequest`](../../doc/models/item-import-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ItemImportResponse](../../doc/models/item-import-response.md).

## Example Usage

```csharp
ItemImportRequest body = new ItemImportRequest
{
    Products = new List<Products>
    {
        Products.Balance,
    },
    UserAuth = new ItemImportRequestUserAuth
    {
        UserId = "user_id2",
        AuthToken = "auth_token0",
    },
};

try
{
    ApiResponse<ItemImportResponse> result = await itemApi.ItemImportAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "access_token": "access-sandbox-99ace160-3cf7-4e51-a083-403633425815",
  "request_id": "ewIBAn6RZirsk4W"
}
```

