# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [ThePlaidApiClient](ThePlaidApiClient.cs)

## Accounts

> Source: [Accounts](Api/Accounts.cs)

<details>
<summary><code>Task&lt;AccountsGetResponse&gt; AccountsBalanceGet(AccountsBalanceGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/accounts/balance/get` endpoint returns the real-time balance for each of an Item's accounts. While other endpoints may return a balance object, only `/accounts/balance/get` forces the available and current balance fields to be refreshed rather than cached. This endpoint can be used for existing Items that were added via any of Plaid’s other products. This endpoint can be used as long as Link has been initialized with any other product, `balance` itself is not a product that can be used to initialize Link.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.AccountsBalanceGet(new AccountsBalanceGetOperationRequest
    {
        Body = new AccountsBalanceGetRequest
        {
            AccessToken = "string",
            Secret = "string",
            ClientId = "string",
            Options = new AccountsBalanceGetRequestOptions { AccountIds = ["string"] },
        },
    });
    // TODO: Handle 'response' of type AccountsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccountsBalanceGetOperationRequest](Requests/Accounts/AccountsBalanceGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountsGetResponse](Models/AccountsGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountsGetResponse&gt; AccountsGet(AccountsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/accounts/get`  endpoint can be used to retrieve information for any linked Item. Note that some information is nullable. Plaid will only return active bank accounts, i.e. accounts that are not closed and are capable of carrying a balance.

This endpoint retrieves cached information, rather than extracting fresh information from the institution. As a result, balances returned may not be up-to-date; for realtime balance information, use `/accounts/balance/get` instead.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.AccountsGet(new AccountsGetOperationRequest
    {
        Body = new AccountsGetRequest
        {
            ClientId = "string",
            Secret = "string",
            AccessToken = "string",
            Options = new AccountsGetRequestOptions { AccountIds = ["string"] },
        },
    });
    // TODO: Handle 'response' of type AccountsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccountsGetOperationRequest](Requests/Accounts/AccountsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountsGetResponse](Models/AccountsGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApplicationApi

> Source: [ApplicationApi](Api/ApplicationApi.cs)

<details>
<summary><code>Task&lt;ApplicationGetResponse&gt; ApplicationGet(ApplicationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows financial institutions to retrieve information about Plaid clients for the purpose of building control-tower experiences

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApplicationApi.ApplicationGet(new ApplicationGetOperationRequest
    {
        Body = new ApplicationGetRequest
        {
            ClientId = "some example string",
            Secret = "some example string",
            ApplicationId = "some example string",
        },
    });
    // TODO: Handle 'response' of type ApplicationGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ApplicationGetOperationRequest](Requests/ApplicationApi/ApplicationGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApplicationGetResponse](Models/ApplicationGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AssetReportApi

> Source: [AssetReportApi](Api/AssetReportApi.cs)

<details>
<summary><code>Task&lt;AssetReportAuditCopyCreateResponse&gt; AssetReportAuditCopyCreate(AssetReportAuditCopyCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Plaid can provide an Audit Copy of any Asset Report directly to a participating third party on your behalf. For example, Plaid can supply an Audit Copy directly to Fannie Mae on your behalf if you participate in the Day 1 Certainty™ program. An Audit Copy contains the same underlying data as the Asset Report.

To grant access to an Audit Copy, use the `/asset_report/audit_copy/create` endpoint to create an `audit_copy_token` and then pass that token to the third party who needs access. Each third party has its own `auditor_id`, for example `fannie_mae`. You’ll need to create a separate Audit Copy for each third party to whom you want to grant access to the Report.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportApi.AssetReportAuditCopyCreate(new AssetReportAuditCopyCreateOperationRequest
    {
        Body = new AssetReportAuditCopyCreateRequest
        {
            AssetReportToken = "some example string",
            AuditorId = "some example string",
        },
    });
    // TODO: Handle 'response' of type AssetReportAuditCopyCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportAuditCopyCreateOperationRequest](Requests/AssetReportApi/AssetReportAuditCopyCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportAuditCopyCreateResponse](Models/AssetReportAuditCopyCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportGetResponse&gt; AssetReportAuditCopyGet(AssetReportAuditCopyGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/asset_report/audit_copy/get` allows auditors to get a copy of an Asset Report that was previously shared via the `/asset_report/audit_copy/create` endpoint.  The caller of `/asset_report/audit_copy/create` must provide the `audit_copy_token` to the auditor.  This token can then be used to call `/asset_report/audit_copy/create`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportApi.AssetReportAuditCopyGet(new AssetReportAuditCopyGetOperationRequest
    {
        Body = new AssetReportAuditCopyGetRequest { AuditCopyToken = "some example string" },
    });
    // TODO: Handle 'response' of type AssetReportGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportAuditCopyGetOperationRequest](Requests/AssetReportApi/AssetReportAuditCopyGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportGetResponse](Models/AssetReportGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportAuditCopyRemoveResponse&gt; AssetReportAuditCopyRemove(AssetReportAuditCopyRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/asset_report/audit_copy/remove` endpoint allows you to remove an Audit Copy. Removing an Audit Copy invalidates the `audit_copy_token` associated with it, meaning both you and any third parties holding the token will no longer be able to use it to access Report data. Items associated with the Asset Report, the Asset Report itself and other Audit Copies of it are not affected and will remain accessible after removing the given Audit Copy.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportApi.AssetReportAuditCopyRemove(new AssetReportAuditCopyRemoveOperationRequest
    {
        Body = new AssetReportAuditCopyRemoveRequest { AuditCopyToken = "some example string" },
    });
    // TODO: Handle 'response' of type AssetReportAuditCopyRemoveResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportAuditCopyRemoveOperationRequest](Requests/AssetReportApi/AssetReportAuditCopyRemoveOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportAuditCopyRemoveResponse](Models/AssetReportAuditCopyRemoveResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportCreateResponse&gt; AssetReportCreate(AssetReportCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/asset_report/create` endpoint initiates the process of creating an Asset Report, which can then be retrieved by passing the `asset_report_token` return value to the `/asset_report/get` or `/asset_report/pdf/get` endpoints.

The Asset Report takes some time to be created and is not available immediately after calling `/asset_report/create`. When the Asset Report is ready to be retrieved using `/asset_report/get` or `/asset_report/pdf/get`, Plaid will fire a `PRODUCT_READY` webhook. For full details of the webhook schema, see [Asset Report webhooks](https://plaid.com/docs/api/webhooks/#Assets-webhooks).

The `/asset_report/create` endpoint creates an Asset Report at a moment in time. Asset Reports are immutable. To get an updated Asset Report, use the `/asset_report/refresh` endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportApi.AssetReportCreate(new AssetReportCreateOperationRequest
    {
        Body = new AssetReportCreateRequest { AccessTokens = ["some example string"], DaysRequested = 1 },
    });
    // TODO: Handle 'response' of type AssetReportCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportCreateOperationRequest](Requests/AssetReportApi/AssetReportCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportCreateResponse](Models/AssetReportCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportFilterResponse&gt; AssetReportFilter(AssetReportFilterOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

By default, an Asset Report will contain all of the accounts on a given Item. In some cases, you may not want the Asset Report to contain all accounts. For example, you might have the end user choose which accounts are relevant in Link using the Account Select view, which you can enable in the dashboard. Or, you might always exclude certain account types or subtypes, which you can identify by using the `/accounts/get` endpoint. To narrow an Asset Report to only a subset of accounts, use the `/asset_report/filter` endpoint.

To exclude certain Accounts from an Asset Report, first use the `/asset_report/create` endpoint to create the report, then send the `asset_report_token` along with a list of `account_ids` to exclude to the `/asset_report/filter` endpoint, to create a new Asset Report which contains only a subset of the original Asset Report's data.

Because Asset Reports are immutable, calling `/asset_report/filter` does not alter the original Asset Report in any way; rather, `/asset_report/filter` creates a new Asset Report with a new token and id. Asset Reports created via `/asset_report/filter` do not contain new Asset data, and are not billed.

Plaid will fire a [`PRODUCT_READY`](https://plaid.com/docs/api/webhooks) webhook once generation of the filtered Asset Report has completed.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportApi.AssetReportFilter(new AssetReportFilterOperationRequest
    {
        Body = new AssetReportFilterRequest
        {
            AssetReportToken = "some example string",
            AccountIdsToExclude = ["some example string"],
        },
    });
    // TODO: Handle 'response' of type AssetReportFilterResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportFilterOperationRequest](Requests/AssetReportApi/AssetReportFilterOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportFilterResponse](Models/AssetReportFilterResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportGetResponse&gt; AssetReportGet(AssetReportGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/asset_report/get` endpoint retrieves the Asset Report in JSON format. Before calling `/asset_report/get`, you must first create the Asset Report using `/asset_report/create` (or filter an Asset Report using `/asset_report/filter`) and then wait for the [`PRODUCT_READY`](https://plaid.com/docs/api/webhooks) webhook to fire, indicating that the Report is ready to be retrieved.

By default, an Asset Report includes transaction descriptions as returned by the bank, as opposed to parsed and categorized by Plaid. You can also receive cleaned and categorized transactions, as well as additional insights like merchant name or location information. We call this an Asset Report with Insights. An Asset Report with Insights provides transaction category, location, and merchant information in addition to the transaction strings provided in a standard Asset Report.

To retrieve an Asset Report with Insights, call the `/asset_report/get` endpoint with `include_insights` set to `true`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportApi.AssetReportGet(new AssetReportGetOperationRequest
    {
        Body = new AssetReportGetRequest { AssetReportToken = "some example string" },
    });
    // TODO: Handle 'response' of type AssetReportGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportGetOperationRequest](Requests/AssetReportApi/AssetReportGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportGetResponse](Models/AssetReportGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task AssetReportPdfGet(AssetReportPdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/asset_report/pdf/get` endpoint retrieves the Asset Report in PDF format. Before calling `/asset_report/pdf/get`, you must first create the Asset Report using `/asset_report/create` (or filter an Asset Report using `/asset_report/filter`) and then wait for the [`PRODUCT_READY`](https://plaid.com/docs/api/webhooks) webhook to fire, indicating that the Report is ready to be retrieved.

The response to `/asset_report/pdf/get` is the PDF binary data. The `request_id`  is returned in the `Plaid-Request-ID` header.

[View a sample PDF Asset Report](https://plaid.com/documents/sample-asset-report.pdf).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AssetReportApi.AssetReportPdfGet(new AssetReportPdfGetOperationRequest
    {
        Body = new AssetReportPdfGetRequest { AssetReportToken = "some example string" },
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportPdfGetOperationRequest](Requests/AssetReportApi/AssetReportPdfGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportRefreshResponse&gt; AssetReportRefresh(AssetReportRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

An Asset Report is an immutable snapshot of a user's assets. In order to "refresh" an Asset Report you created previously, you can use the `/asset_report/refresh` endpoint to create a new Asset Report based on the old one, but with the most recent data available.

The new Asset Report will contain the same Items as the original Report, as well as the same filters applied by any call to `/asset_report/filter`. By default, the new Asset Report will also use the same parameters you submitted with your original `/asset_report/create` request, but the original `days_requested` value and the values of any parameters in the `options` object can be overridden with new values. To change these arguments, simply supply new values for them in your request to `/asset_report/refresh`. Submit an empty string ("") for any previously-populated fields you would like set as empty.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportApi.AssetReportRefresh(new AssetReportRefreshOperationRequest
    {
        Body = new AssetReportRefreshRequest { AssetReportToken = "some example string" },
    });
    // TODO: Handle 'response' of type AssetReportRefreshResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportRefreshOperationRequest](Requests/AssetReportApi/AssetReportRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportRefreshResponse](Models/AssetReportRefreshResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportRemoveResponse&gt; AssetReportRemove(AssetReportRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/item/remove` endpoint allows you to invalidate an `access_token`, meaning you will not be able to create new Asset Reports with it. Removing an Item does not affect any Asset Reports or Audit Copies you have already created, which will remain accessible until you remove them specifically.

The `/asset_report/remove` endpoint allows you to remove an Asset Report. Removing an Asset Report invalidates its `asset_report_token`, meaning you will no longer be able to use it to access Report data or create new Audit Copies. Removing an Asset Report does not affect the underlying Items, but does invalidate any `audit_copy_tokens` associated with the Asset Report.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportApi.AssetReportRemove(new AssetReportRemoveOperationRequest
    {
        Body = new AssetReportRemoveRequest { AssetReportToken = "some example string" },
    });
    // TODO: Handle 'response' of type AssetReportRemoveResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportRemoveOperationRequest](Requests/AssetReportApi/AssetReportRemoveOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportRemoveResponse](Models/AssetReportRemoveResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Auth

> Source: [Auth](Api/Auth.cs)

<details>
<summary><code>Task&lt;AuthGetResponse&gt; AuthGet(AuthGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/auth/get` endpoint returns the bank account and bank identification numbers (such as routing numbers, for US accounts) associated with an Item's checking and savings accounts, along with high-level account data and balances when available.

Note: This request may take some time to complete if `auth` was not specified as an initial product when creating the Item. This is because Plaid must communicate directly with the institution to retrieve the data.

Also note that `/auth/get` will not return data for any new accounts opened after the Item was created. To obtain data for new accounts, create a new Item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Auth.AuthGet(new AuthGetOperationRequest
    {
        Body = new AuthGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type AuthGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AuthGetOperationRequest](Requests/Auth/AuthGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthGetResponse](Models/AuthGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BankTransferApi

> Source: [BankTransferApi](Api/BankTransferApi.cs)

<details>
<summary><code>Task&lt;BankTransferBalanceGetResponse&gt; BankTransferBalanceGet(BankTransferBalanceGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/bank_transfer/balance/get` endpoint to see the available balance in your bank transfer account. Debit transfers increase this balance once their status is posted. Credit transfers decrease this balance when they are created.

The transactable balance shows the amount in your account that you are able to use for transfers, and is essentially your available balance minus your minimum balance.

Note that this endpoint can only be used with FBO accounts, when using Bank Transfers in the Full Service configuration. It cannot be used on your own account when using Bank Transfers in the BTS Platform configuration.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferApi.BankTransferBalanceGet(new BankTransferBalanceGetOperationRequest
    {
        Body = new BankTransferBalanceGetRequest(),
    });
    // TODO: Handle 'response' of type BankTransferBalanceGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferBalanceGetOperationRequest](Requests/BankTransferApi/BankTransferBalanceGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferBalanceGetResponse](Models/BankTransferBalanceGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferCancelResponse&gt; BankTransferCancel(BankTransferCancelOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/bank_transfer/cancel` endpoint to cancel a bank transfer.  A transfer is eligible for cancelation if the `cancellable` property returned by `/bank_transfer/get` is `true`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferApi.BankTransferCancel(new BankTransferCancelOperationRequest
    {
        Body = new BankTransferCancelRequest { BankTransferId = "some example string" },
    });
    // TODO: Handle 'response' of type BankTransferCancelResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferCancelOperationRequest](Requests/BankTransferApi/BankTransferCancelOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferCancelResponse](Models/BankTransferCancelResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferCreateResponse&gt; BankTransferCreate(BankTransferCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/bank_transfer/create` endpoint to initiate a new bank transfer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferApi.BankTransferCreate(new BankTransferCreateOperationRequest
    {
        Body = new BankTransferCreateRequest
        {
            IdempotencyKey = "some example string",
            AccessToken = "some example string",
            AccountId = "some example string",
            Type = BankTransferType.Debit,
            Network = BankTransferNetwork.Ach,
            Amount = "some example string",
            IsoCurrencyCode = "some example string",
            Description = "some example string",
            User = new BankTransferUser { LegalName = "some example string" },
        },
    });
    // TODO: Handle 'response' of type BankTransferCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferCreateOperationRequest](Requests/BankTransferApi/BankTransferCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferCreateResponse](Models/BankTransferCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferEventListResponse&gt; BankTransferEventList(BankTransferEventListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/bank_transfer/event/list` endpoint to get a list of bank transfer events based on specified filter criteria.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferApi.BankTransferEventList(new BankTransferEventListOperationRequest
    {
        Body = new BankTransferEventListRequest(),
    });
    // TODO: Handle 'response' of type BankTransferEventListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferEventListOperationRequest](Requests/BankTransferApi/BankTransferEventListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferEventListResponse](Models/BankTransferEventListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferEventSyncResponse&gt; BankTransferEventSync(BankTransferEventSyncOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/bank_transfer/event/sync` allows you to request up to the next 25 bank transfer events that happened after a specific `event_id`. Use the `/bank_transfer/event/sync` endpoint to guarantee you have seen all bank transfer events.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferApi.BankTransferEventSync(new BankTransferEventSyncOperationRequest
    {
        Body = new BankTransferEventSyncRequest { AfterId = 1 },
    });
    // TODO: Handle 'response' of type BankTransferEventSyncResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferEventSyncOperationRequest](Requests/BankTransferApi/BankTransferEventSyncOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferEventSyncResponse](Models/BankTransferEventSyncResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferGetResponse&gt; BankTransferGet(BankTransferGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/bank_transfer/get` fetches information about the bank transfer corresponding to the given `bank_transfer_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferApi.BankTransferGet(new BankTransferGetOperationRequest
    {
        Body = new BankTransferGetRequest { BankTransferId = "some example string" },
    });
    // TODO: Handle 'response' of type BankTransferGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferGetOperationRequest](Requests/BankTransferApi/BankTransferGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferGetResponse](Models/BankTransferGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferListResponse&gt; BankTransferList(BankTransferListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/bank_transfer/list` endpoint to see a list of all your bank transfers and their statuses. Results are paginated; use the `count` and `offset` query parameters to retrieve the desired bank transfers.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferApi.BankTransferList(new BankTransferListOperationRequest
    {
        Body = new BankTransferListRequest(),
    });
    // TODO: Handle 'response' of type BankTransferListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferListOperationRequest](Requests/BankTransferApi/BankTransferListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferListResponse](Models/BankTransferListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferMigrateAccountResponse&gt; BankTransferMigrateAccount(BankTransferMigrateAccountOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

As an alternative to adding Items via Link, you can also use the `/bank_transfer/migrate_account` endpoint to migrate known account and routing numbers to Plaid Items.  Note that Items created in this way are not compatible with endpoints for other products, such as `/accounts/balance/get`, and can only be used with Bank Transfer endpoints.  If you require access to other endpoints, create the Item through Link instead.  Access to `/bank_transfer/migrate_account` is not enabled by default; to obtain access, contact your Plaid Account Manager.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferApi.BankTransferMigrateAccount(
        new BankTransferMigrateAccountOperationRequest
        {
            Body = new BankTransferMigrateAccountRequest
            {
                AccountNumber = "some example string",
                RoutingNumber = "some example string",
                AccountType = "some example string",
            },
        });
    // TODO: Handle 'response' of type BankTransferMigrateAccountResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferMigrateAccountOperationRequest](Requests/BankTransferApi/BankTransferMigrateAccountOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferMigrateAccountResponse](Models/BankTransferMigrateAccountResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferSweepGetResponse&gt; BankTransferSweepGet(BankTransferSweepGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/bank_transfer/sweep/get` endpoint fetches information about the sweep corresponding to the given `sweep_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferApi.BankTransferSweepGet(new BankTransferSweepGetOperationRequest
    {
        Body = new BankTransferSweepGetRequest { SweepId = 1L },
    });
    // TODO: Handle 'response' of type BankTransferSweepGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferSweepGetOperationRequest](Requests/BankTransferApi/BankTransferSweepGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferSweepGetResponse](Models/BankTransferSweepGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferSweepListResponse&gt; BankTransferSweepList(BankTransferSweepListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/bank_transfer/sweep/list` endpoint fetches information about the sweeps matching the given filters.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferApi.BankTransferSweepList(new BankTransferSweepListOperationRequest
    {
        Body = new BankTransferSweepListRequest(),
    });
    // TODO: Handle 'response' of type BankTransferSweepListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferSweepListOperationRequest](Requests/BankTransferApi/BankTransferSweepListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferSweepListResponse](Models/BankTransferSweepListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Categories

> Source: [Categories](Api/Categories.cs)

<details>
<summary><code>Task&lt;CategoriesGetResponse&gt; CategoriesGet(CategoriesGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Send a request to the `/categories/get`  endpoint to get detailed information on categories returned by Plaid. This endpoint does not require authentication.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Categories.CategoriesGet(new CategoriesGetRequest { Body = body });
    // TODO: Handle 'response' of type CategoriesGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CategoriesGetRequest](Requests/Categories/CategoriesGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CategoriesGetResponse](Models/CategoriesGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DepositSwitch

> Source: [DepositSwitch](Api/DepositSwitch.cs)

<details>
<summary><code>Task&lt;DepositSwitchAltCreateResponse&gt; DepositSwitchAltCreate(DepositSwitchAltCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint provides an alternative to `/deposit_switch/create` for customers who have not yet fully integrated with Plaid Exchange. Like `/deposit_switch/create`, it creates a deposit switch entity that will be persisted throughout the lifecycle of the switch.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DepositSwitch.DepositSwitchAltCreate(new DepositSwitchAltCreateOperationRequest
    {
        Body = new DepositSwitchAltCreateRequest
        {
            TargetAccount = new DepositSwitchTargetAccount
            {
                AccountNumber = "some example string",
                RoutingNumber = "some example string",
                AccountName = "some example string",
                AccountSubtype = AccountSubtype1.Checking,
            },
            TargetUser = new DepositSwitchTargetUser
            {
                GivenName = "some example string",
                FamilyName = "some example string",
                Phone = "some example string",
                Email = "some example string",
            },
        },
    });
    // TODO: Handle 'response' of type DepositSwitchAltCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DepositSwitchAltCreateOperationRequest](Requests/DepositSwitch/DepositSwitchAltCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DepositSwitchAltCreateResponse](Models/DepositSwitchAltCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DepositSwitchCreateResponse&gt; DepositSwitchCreate(DepositSwitchCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint creates a deposit switch entity that will be persisted throughout the lifecycle of the switch.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DepositSwitch.DepositSwitchCreate(new DepositSwitchCreateOperationRequest
    {
        Body = new DepositSwitchCreateRequest
        {
            TargetAccessToken = "some example string",
            TargetAccountId = "some example string",
        },
    });
    // TODO: Handle 'response' of type DepositSwitchCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DepositSwitchCreateOperationRequest](Requests/DepositSwitch/DepositSwitchCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DepositSwitchCreateResponse](Models/DepositSwitchCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DepositSwitchGetResponse&gt; DepositSwitchGet(DepositSwitchGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint returns information related to how the user has configured their payroll allocation and the state of the switch. You can use this information to build logic related to the user's direct deposit allocation preferences.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DepositSwitch.DepositSwitchGet(new DepositSwitchGetOperationRequest
    {
        Body = new DepositSwitchGetRequest { DepositSwitchId = "some example string" },
    });
    // TODO: Handle 'response' of type DepositSwitchGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DepositSwitchGetOperationRequest](Requests/DepositSwitch/DepositSwitchGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DepositSwitchGetResponse](Models/DepositSwitchGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DepositSwitchTokenCreateResponse&gt; DepositSwitchTokenCreate(DepositSwitchTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

In order for the end user to take action, you will need to create a public token representing the deposit switch. This token is used to initialize Link. It can be used one time and expires after 30 minutes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DepositSwitch.DepositSwitchTokenCreate(new DepositSwitchTokenCreateOperationRequest
    {
        Body = new DepositSwitchTokenCreateRequest { DepositSwitchId = "some example string" },
    });
    // TODO: Handle 'response' of type DepositSwitchTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DepositSwitchTokenCreateOperationRequest](Requests/DepositSwitch/DepositSwitchTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DepositSwitchTokenCreateResponse](Models/DepositSwitchTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Employers

> Source: [Employers](Api/Employers.cs)

<details>
<summary><code>Task&lt;EmployersSearchResponse&gt; EmployersSearch(EmployersSearchOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/employers/search` allows you the ability to search Plaid’s database of known employers, for use with Deposit Switch. You can use this endpoint to look up a user's employer in order to confirm that they are supported. Users with non-supported employers can then be routed out of the Deposit Switch flow.

The data in the employer database is currently limited. As the Deposit Switch and Income products progress through their respective beta periods, more employers are being regularly added. Because the employer database is frequently updated, we recommend that you do not cache or store data from this endpoint for more than a day.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Employers.EmployersSearch(new EmployersSearchOperationRequest
    {
        Body = new EmployersSearchRequest { Query = "some example string", Products = ["some example string"] },
    });
    // TODO: Handle 'response' of type EmployersSearchResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EmployersSearchOperationRequest](Requests/Employers/EmployersSearchOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EmployersSearchResponse](Models/EmployersSearchResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Identity

> Source: [Identity](Api/Identity.cs)

<details>
<summary><code>Task&lt;IdentityGetResponse&gt; IdentityGet(IdentityGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/identity/get` endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses. Only name data is guaranteed to be returned; other fields will be empty arrays if not provided by the institution.

Note: This request may take some time to complete if identity was not specified as an initial product when creating the Item. This is because Plaid must communicate directly with the institution to retrieve the data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Identity.IdentityGet(new IdentityGetOperationRequest
    {
        Body = new IdentityGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type IdentityGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IdentityGetOperationRequest](Requests/Identity/IdentityGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IdentityGetResponse](Models/IdentityGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Income

> Source: [Income](Api/Income.cs)

<details>
<summary><code>Task&lt;IncomeVerificationCreateResponse&gt; IncomeVerificationCreate(IncomeVerificationCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/income/verification/create` begins the income verification process by returning an `income_verification_id`. You can then provide the `income_verification_id` to `/link/token/create` under the `income_verification` parameter in order to create a Link instance that will prompt the user to go through the income verification flow. Plaid will fire an `INCOME` webhook once the user completes the Payroll Income flow, or when the uploaded documents in the Document Income flow have finished processing.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Income.IncomeVerificationCreate(new IncomeVerificationCreateOperationRequest
    {
        Body = new IncomeVerificationCreateRequest { Webhook = "some example string" },
    });
    // TODO: Handle 'response' of type IncomeVerificationCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IncomeVerificationCreateOperationRequest](Requests/Income/IncomeVerificationCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IncomeVerificationCreateResponse](Models/IncomeVerificationCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task IncomeVerificationDocumentsDownload(IncomeVerificationDocumentsDownloadOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/income/verification/documents/download` provides the ability to download the source paystub PDF that the end user uploaded via Paystub Import.

The response to `/income/verification/documents/download` is a ZIP file in binary data. The `request_id`  is returned in the `Plaid-Request-ID` header.

For Payroll Income, the most recent file available for download with the payroll provider will also be available from this endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Income.IncomeVerificationDocumentsDownload(new IncomeVerificationDocumentsDownloadOperationRequest
    {
        Body = new IncomeVerificationDocumentsDownloadRequest(),
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IncomeVerificationDocumentsDownloadOperationRequest](Requests/Income/IncomeVerificationDocumentsDownloadOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IncomeVerificationPaystubGetResponse&gt; IncomeVerificationPaystubGet(IncomeVerificationPaystubGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

(Deprecated) Retrieve information from a single paystub used for income verification

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Income.IncomeVerificationPaystubGet(new IncomeVerificationPaystubGetOperationRequest
    {
        Body = new IncomeVerificationPaystubGetRequest(),
    });
    // TODO: Handle 'response' of type IncomeVerificationPaystubGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IncomeVerificationPaystubGetOperationRequest](Requests/Income/IncomeVerificationPaystubGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IncomeVerificationPaystubGetResponse](Models/IncomeVerificationPaystubGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IncomeVerificationPaystubsGetResponse&gt; IncomeVerificationPaystubsGet(IncomeVerificationPaystubsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/income/verification/paystubs/get` returns the information collected from the paystubs that were used to verify an end user's income. It can be called once the status of the verification has been set to `VERIFICATION_STATUS_PROCESSING_COMPLETE`, as reported by the `INCOME: verification_status` webhook. Attempting to call the endpoint before verification has been completed will result in an error.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Income.IncomeVerificationPaystubsGet(new IncomeVerificationPaystubsGetOperationRequest
    {
        Body = new IncomeVerificationPaystubsGetRequest(),
    });
    // TODO: Handle 'response' of type IncomeVerificationPaystubsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IncomeVerificationPaystubsGetOperationRequest](Requests/Income/IncomeVerificationPaystubsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IncomeVerificationPaystubsGetResponse](Models/IncomeVerificationPaystubsGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IncomeVerificationPrecheckResponse&gt; IncomeVerificationPrecheck(IncomeVerificationPrecheckOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/income/verification/precheck` returns whether a given user is supportable by the income product

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Income.IncomeVerificationPrecheck(new IncomeVerificationPrecheckOperationRequest
    {
        Body = new IncomeVerificationPrecheckRequest(),
    });
    // TODO: Handle 'response' of type IncomeVerificationPrecheckResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IncomeVerificationPrecheckOperationRequest](Requests/Income/IncomeVerificationPrecheckOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IncomeVerificationPrecheckResponse](Models/IncomeVerificationPrecheckResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IncomeVerificationRefreshResponse&gt; IncomeVerificationRefresh(IncomeVerificationRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/income/verification/refresh` refreshes a given income verification.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Income.IncomeVerificationRefresh(new IncomeVerificationRefreshOperationRequest
    {
        Body = new IncomeVerificationRefreshRequest(),
    });
    // TODO: Handle 'response' of type IncomeVerificationRefreshResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IncomeVerificationRefreshOperationRequest](Requests/Income/IncomeVerificationRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IncomeVerificationRefreshResponse](Models/IncomeVerificationRefreshResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IncomeVerificationSummaryGetResponse&gt; IncomeVerificationSummaryGet(IncomeVerificationSummaryGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/income/verification/summary/get` returns a verification summary for the income that was verified for an end user. It can be called once the status of the verification has been set to `VERIFICATION_STATUS_PROCESSING_COMPLETE`, as reported by the `INCOME: verification_status` webhook. Attempting to call the endpoint before verification has been completed will result in an error.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Income.IncomeVerificationSummaryGet(new IncomeVerificationSummaryGetOperationRequest
    {
        Body = new IncomeVerificationSummaryGetRequest(),
    });
    // TODO: Handle 'response' of type IncomeVerificationSummaryGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IncomeVerificationSummaryGetOperationRequest](Requests/Income/IncomeVerificationSummaryGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IncomeVerificationSummaryGetResponse](Models/IncomeVerificationSummaryGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IncomeVerificationTaxformsGetResponse&gt; IncomeVerificationTaxformsGet(IncomeVerificationTaxformsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/income/verification/taxforms/get` returns the information collected from taxforms that were used to verify an end user's. It can be called once the status of the verification has been set to `VERIFICATION_STATUS_PROCESSING_COMPLETE`, as reported by the `INCOME: verification_status` webhook. Attempting to call the endpoint before verification has been completed will result in an error.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Income.IncomeVerificationTaxformsGet(new IncomeVerificationTaxformsGetOperationRequest
    {
        Body = new IncomeVerificationTaxformsGetRequest(),
    });
    // TODO: Handle 'response' of type IncomeVerificationTaxformsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IncomeVerificationTaxformsGetOperationRequest](Requests/Income/IncomeVerificationTaxformsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IncomeVerificationTaxformsGetResponse](Models/IncomeVerificationTaxformsGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Institutions

> Source: [Institutions](Api/Institutions.cs)

<details>
<summary><code>Task&lt;InstitutionsGetResponse&gt; InstitutionsGet(InstitutionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a JSON response containing details on all financial institutions currently supported by Plaid. Because Plaid supports thousands of institutions, results are paginated.

If there is no overlap between an institution’s enabled products and a client’s enabled products, then the institution will be filtered out from the response. As a result, the number of institutions returned may not match the count specified in the call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Institutions.InstitutionsGet(new InstitutionsGetOperationRequest
    {
        Body = new InstitutionsGetRequest { Count = 1, Offset = 1, CountryCodes = [CountryCode.Us] },
    });
    // TODO: Handle 'response' of type InstitutionsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InstitutionsGetOperationRequest](Requests/Institutions/InstitutionsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InstitutionsGetResponse](Models/InstitutionsGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InstitutionsGetByIdResponse&gt; InstitutionsGetById(InstitutionsGetByIdOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a JSON response containing details on a specified financial institution currently supported by Plaid.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Institutions.InstitutionsGetById(new InstitutionsGetByIdOperationRequest
    {
        Body = new InstitutionsGetByIdRequest
        {
            InstitutionId = "some example string",
            CountryCodes = [CountryCode.Us],
        },
    });
    // TODO: Handle 'response' of type InstitutionsGetByIdResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InstitutionsGetByIdOperationRequest](Requests/Institutions/InstitutionsGetByIdOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InstitutionsGetByIdResponse](Models/InstitutionsGetByIdResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InstitutionsSearchResponse&gt; InstitutionsSearch(InstitutionsSearchOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a JSON response containing details for institutions that match the query parameters, up to a maximum of ten institutions per query.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Institutions.InstitutionsSearch(new InstitutionsSearchOperationRequest
    {
        Body = new InstitutionsSearchRequest
        {
            Query = "some example string",
            Products = [Products.Assets],
            CountryCodes = [CountryCode.Us],
        },
    });
    // TODO: Handle 'response' of type InstitutionsSearchResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InstitutionsSearchOperationRequest](Requests/Institutions/InstitutionsSearchOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InstitutionsSearchResponse](Models/InstitutionsSearchResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Investments

> Source: [Investments](Api/Investments.cs)

<details>
<summary><code>Task&lt;InvestmentsHoldingsGetResponse&gt; InvestmentsHoldingsGet(InvestmentsHoldingsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/investments/holdings/get` endpoint allows developers to receive user-authorized stock position data for `investment`-type accounts.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Investments.InvestmentsHoldingsGet(new InvestmentsHoldingsGetOperationRequest
    {
        Body = new InvestmentsHoldingsGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type InvestmentsHoldingsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InvestmentsHoldingsGetOperationRequest](Requests/Investments/InvestmentsHoldingsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvestmentsHoldingsGetResponse](Models/InvestmentsHoldingsGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvestmentsTransactionsGetResponse&gt; InvestmentsTransactionsGet(InvestmentsTransactionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/investments/transactions/get` endpoint allows developers to retrieve user-authorized transaction data for investment accounts.

Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.

Due to the potentially large number of investment transactions associated with an Item, results are paginated. Manipulate the count and offset parameters in conjunction with the `total_investment_transactions` response body field to fetch all available investment transactions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Investments.InvestmentsTransactionsGet(new InvestmentsTransactionsGetOperationRequest
    {
        Body = new InvestmentsTransactionsGetRequest
        {
            AccessToken = "some example string",
            StartDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
            EndDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
        },
    });
    // TODO: Handle 'response' of type InvestmentsTransactionsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InvestmentsTransactionsGetOperationRequest](Requests/Investments/InvestmentsTransactionsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvestmentsTransactionsGetResponse](Models/InvestmentsTransactionsGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ItemApi

> Source: [ItemApi](Api/ItemApi.cs)

<details>
<summary><code>Task&lt;ItemAccessTokenInvalidateResponse&gt; ItemAccessTokenInvalidate(ItemAccessTokenInvalidateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

By default, the `access_token` associated with an Item does not expire and should be stored in a persistent, secure manner.

You can use the `/item/access_token/invalidate` endpoint to rotate the `access_token` associated with an Item. The endpoint returns a new `access_token` and immediately invalidates the previous `access_token`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemApi.ItemAccessTokenInvalidate(new ItemAccessTokenInvalidateOperationRequest
    {
        Body = new ItemAccessTokenInvalidateRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type ItemAccessTokenInvalidateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemAccessTokenInvalidateOperationRequest](Requests/ItemApi/ItemAccessTokenInvalidateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemAccessTokenInvalidateResponse](Models/ItemAccessTokenInvalidateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemApplicationListResponse&gt; ItemApplicationList(ItemApplicationListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List a user’s connected applications

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemApi.ItemApplicationList(new ItemApplicationListOperationRequest
    {
        Body = new ItemApplicationListRequest(),
    });
    // TODO: Handle 'response' of type ItemApplicationListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemApplicationListOperationRequest](Requests/ItemApi/ItemApplicationListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemApplicationListResponse](Models/ItemApplicationListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemApplicationScopesUpdateResponse&gt; ItemApplicationScopesUpdate(ItemApplicationScopesUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable consumers to update product access on selected accounts for an application.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemApi.ItemApplicationScopesUpdate(new ItemApplicationScopesUpdateOperationRequest
    {
        Body = new ItemApplicationScopesUpdateRequest
        {
            AccessToken = "some example string",
            ApplicationId = "some example string",
            Scopes = new Scopes(),
            Context = ScopesContext.Enrollment,
        },
    });
    // TODO: Handle 'response' of type ItemApplicationScopesUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemApplicationScopesUpdateOperationRequest](Requests/ItemApi/ItemApplicationScopesUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemApplicationScopesUpdateResponse](Models/ItemApplicationScopesUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemPublicTokenCreateResponse&gt; ItemCreatePublicToken(ItemCreatePublicTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Note: As of July 2020, the `/item/public_token/create` endpoint is deprecated. Instead, use `/link/token/create` with an `access_token` to create a Link token for use with [update mode](https://plaid.com/docs/link/update-mode).

If you need your user to take action to restore or resolve an error associated with an Item, generate a public token with the `/item/public_token/create` endpoint and then initialize Link with that `public_token`.

A `public_token` is one-time use and expires after 30 minutes. You use a `public_token` to initialize Link in [update mode](https://plaid.com/docs/link/update-mode) for a particular Item. You can generate a `public_token` for an Item even if you did not use Link to create the Item originally.

The `/item/public_token/create` endpoint is **not** used to create your initial `public_token`. If you have not already received an `access_token` for a specific Item, use Link to obtain your `public_token` instead. See the [Quickstart](https://plaid.com/docs/quickstart) for more information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemApi.ItemCreatePublicToken(new ItemCreatePublicTokenRequest
    {
        Body = new ItemPublicTokenCreateRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type ItemPublicTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemCreatePublicTokenRequest](Requests/ItemApi/ItemCreatePublicTokenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemPublicTokenCreateResponse](Models/ItemPublicTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemGetResponse&gt; ItemGet(ItemGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns information about the status of an Item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemApi.ItemGet(new ItemGetOperationRequest
    {
        Body = new ItemGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type ItemGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemGetOperationRequest](Requests/ItemApi/ItemGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemGetResponse](Models/ItemGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemImportResponse&gt; ItemImport(ItemImportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/item/import` creates an Item via your Plaid Exchange Integration and returns an `access_token`. As part of an `/item/import` request, you will include a User ID (`user_auth.user_id`) and Authentication Token (`user_auth.auth_token`) that enable data aggregation through your Plaid Exchange API endpoints. These authentication principals are to be chosen by you.

Upon creating an Item via `/item/import`, Plaid will automatically begin an extraction of that Item through the Plaid Exchange infrastructure you have already integrated. This will automatically generate the Plaid native account ID for the account the user will switch their direct deposit to (`target_account_id`).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemApi.ItemImport(new ItemImportOperationRequest
    {
        Body = new ItemImportRequest
        {
            Products = [Products.Assets],
            UserAuth = new ItemImportRequestUserAuth
            {
                UserId = "some example string",
                AuthToken = "some example string",
            },
        },
    });
    // TODO: Handle 'response' of type ItemImportResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemImportOperationRequest](Requests/ItemApi/ItemImportOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemImportResponse](Models/ItemImportResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemPublicTokenExchangeResponse&gt; ItemPublicTokenExchange(ItemPublicTokenExchangeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Exchange a Link `public_token` for an API `access_token`. Link hands off the `public_token` client-side via the `onSuccess` callback once a user has successfully created an Item. The `public_token` is ephemeral and expires after 30 minutes.

The response also includes an `item_id` that should be stored with the `access_token`. The `item_id` is used to identify an Item in a webhook. The `item_id` can also be retrieved by making an `/item/get` request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemApi.ItemPublicTokenExchange(new ItemPublicTokenExchangeOperationRequest
    {
        Body = new ItemPublicTokenExchangeRequest { PublicToken = "some example string" },
    });
    // TODO: Handle 'response' of type ItemPublicTokenExchangeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemPublicTokenExchangeOperationRequest](Requests/ItemApi/ItemPublicTokenExchangeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemPublicTokenExchangeResponse](Models/ItemPublicTokenExchangeResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemRemoveResponse&gt; ItemRemove(ItemRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/item/remove`  endpoint allows you to remove an Item. Once removed, the `access_token`  associated with the Item is no longer valid and cannot be used to access any data that was associated with the Item.

Note that in the Development environment, issuing an `/item/remove`  request will not decrement your live credential count. To increase your credential account in Development, contact Support.

Also note that for certain OAuth-based institutions, an Item removed via `/item/remove` may still show as an active connection in the institution's OAuth permission manager.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemApi.ItemRemove(new ItemRemoveOperationRequest
    {
        Body = new ItemRemoveRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type ItemRemoveResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemRemoveOperationRequest](Requests/ItemApi/ItemRemoveOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemRemoveResponse](Models/ItemRemoveResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemWebhookUpdateResponse&gt; ItemWebhookUpdate(ItemWebhookUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The POST `/item/webhook/update` allows you to update the webhook URL associated with an Item. This request triggers a [`WEBHOOK_UPDATE_ACKNOWLEDGED`](https://plaid.com/docs/api/webhooks/#item-webhook-url-updated) webhook to the newly specified webhook URL.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemApi.ItemWebhookUpdate(new ItemWebhookUpdateOperationRequest
    {
        Body = new ItemWebhookUpdateRequest { AccessToken = "some example string", Webhook = "some example string" },
    });
    // TODO: Handle 'response' of type ItemWebhookUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemWebhookUpdateOperationRequest](Requests/ItemApi/ItemWebhookUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemWebhookUpdateResponse](Models/ItemWebhookUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Liabilities

> Source: [Liabilities](Api/Liabilities.cs)

<details>
<summary><code>Task&lt;LiabilitiesGetResponse&gt; LiabilitiesGet(LiabilitiesGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/liabilities/get` endpoint returns various details about an Item with loan or credit accounts. Liabilities data is available primarily for US financial institutions, with some limited coverage of Canadian institutions. Currently supported account types are account type `credit` with account subtype `credit card` or `paypal`, and account type `loan` with account subtype `student` or `mortgage`. To limit accounts listed in Link to types and subtypes supported by Liabilities, you can use the `account_filters` parameter when [creating a Link token](https://plaid.com/docs/api/tokens/#linktokencreate).

The types of information returned by Liabilities can include balances and due dates, loan terms, and account details such as original loan amount and guarantor. Data is refreshed approximately once per day; the latest data can be retrieved by calling `/liabilities/get`.

Note: This request may take some time to complete if `liabilities` was not specified as an initial product when creating the Item. This is because Plaid must communicate directly with the institution to retrieve the additional data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Liabilities.LiabilitiesGet(new LiabilitiesGetOperationRequest
    {
        Body = new LiabilitiesGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type LiabilitiesGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LiabilitiesGetOperationRequest](Requests/Liabilities/LiabilitiesGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LiabilitiesGetResponse](Models/LiabilitiesGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Link

> Source: [Link](Api/Link.cs)

<details>
<summary><code>Task&lt;LinkTokenCreateResponse&gt; LinkTokenCreate(LinkTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/link/token/create` endpoint creates a `link_token`, which is required as a parameter when initializing Link. Once Link has been initialized, it returns a `public_token`, which can then be exchanged for an `access_token` via `/item/public_token/exchange` as part of the main Link flow.

A `link_token` generated by `/link/token/create` is also used to initialize other Link flows, such as the update mode flow for tokens with expired credentials, or the Payment Initiation (Europe) flow.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Link.LinkTokenCreate(new LinkTokenCreateOperationRequest
    {
        Body = new LinkTokenCreateRequest
        {
            ClientName = "some example string",
            Language = "some example string",
            CountryCodes = [CountryCode.Us],
            User = new LinkTokenCreateRequestUser { ClientUserId = "some example string" },
        },
    });
    // TODO: Handle 'response' of type LinkTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LinkTokenCreateOperationRequest](Requests/Link/LinkTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LinkTokenCreateResponse](Models/LinkTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LinkTokenGetResponse&gt; LinkTokenGet(LinkTokenGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/link/token/get` endpoint gets information about a previously-created `link_token` using the
`/link/token/create` endpoint. It can be useful for debugging purposes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Link.LinkTokenGet(new LinkTokenGetOperationRequest
    {
        Body = new LinkTokenGetRequest { LinkToken = "some example string" },
    });
    // TODO: Handle 'response' of type LinkTokenGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LinkTokenGetOperationRequest](Requests/Link/LinkTokenGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LinkTokenGetResponse](Models/LinkTokenGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentInitiation

> Source: [PaymentInitiation](Api/PaymentInitiation.cs)

<details>
<summary><code>Task&lt;PaymentInitiationPaymentTokenCreateResponse&gt; CreatePaymentToken(CreatePaymentTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/payment_initiation/payment/token/create` endpoint has been deprecated. New Plaid customers will be unable to use this endpoint, and existing customers are encouraged to migrate to the newer, `link_token`-based flow. The recommended flow is to provide the `payment_id` to `/link/token/create`, which returns a `link_token` used to initialize Link.

The `/payment_initiation/payment/token/create` is used to create a `payment_token`, which can then be used in Link initialization to enter a payment initiation flow. You can only use a `payment_token` once. If this attempt fails, the end user aborts the flow, or the token expires, you will need to create a new payment token. Creating a new payment token does not require end user input.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiation.CreatePaymentToken(new CreatePaymentTokenRequest
    {
        Body = new PaymentInitiationPaymentTokenCreateRequest { PaymentId = "some example string" },
    });
    // TODO: Handle 'response' of type PaymentInitiationPaymentTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreatePaymentTokenRequest](Requests/PaymentInitiation/CreatePaymentTokenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationPaymentTokenCreateResponse](Models/PaymentInitiationPaymentTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationPaymentCreateResponse&gt; PaymentInitiationPaymentCreate(PaymentInitiationPaymentCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

After creating a payment recipient, you can use the `/payment_initiation/payment/create` endpoint to create a payment to that recipient.  Payments can be one-time or standing order (recurring) and can be denominated in either EUR or GBP.  If making domestic GBP-denominated payments, your recipient must have been created with BACS numbers. In general, EUR-denominated payments will be sent via SEPA Credit Transfer and GBP-denominated payments will be sent via the Faster Payments network, but the payment network used will be determined by the institution. Payments sent via Faster Payments will typically arrive immediately, while payments sent via SEPA Credit Transfer will typically arrive in one business day.

Standing orders (recurring payments) must be denominated in GBP and can only be sent to recipients in the UK. Once created, standing order payments cannot be modified or canceled via the API. An end user can cancel or modify a standing order directly on their banking application or website, or by contacting the bank. Standing orders will follow the payment rules of the underlying rails (Faster Payments in UK). Payments can be sent Monday to Friday, excluding bank holidays. If the pre-arranged date falls on a weekend or bank holiday, the payment is made on the next working day. It is not possible to guarantee the exact time the payment will reach the recipient’s account, although at least 90% of standing order payments are sent by 6am.

In the Development environment, payments must be below 5 GBP / EUR. For details on any payment limits in Production, contact your Plaid Account Manager.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiation.PaymentInitiationPaymentCreate(
        new PaymentInitiationPaymentCreateOperationRequest
        {
            Body = new PaymentInitiationPaymentCreateRequest
            {
                RecipientId = "some example string",
                Reference = "some example string",
                Amount = new PaymentAmount { Currency = Currency.Gbp, Value = 1.5d },
            },
        });
    // TODO: Handle 'response' of type PaymentInitiationPaymentCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationPaymentCreateOperationRequest](Requests/PaymentInitiation/PaymentInitiationPaymentCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationPaymentCreateResponse](Models/PaymentInitiationPaymentCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationPaymentGetResponse&gt; PaymentInitiationPaymentGet(PaymentInitiationPaymentGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/payment_initiation/payment/get` endpoint can be used to check the status of a payment, as well as to receive basic information such as recipient and payment amount. In the case of standing orders, the `/payment_initiation/payment/get` endpoint will provide information about the status of the overall standing order itself; the API cannot be used to retrieve payment status for individual payments within a standing order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiation.PaymentInitiationPaymentGet(
        new PaymentInitiationPaymentGetOperationRequest
        {
            Body = new PaymentInitiationPaymentGetRequest { PaymentId = "some example string" },
        });
    // TODO: Handle 'response' of type PaymentInitiationPaymentGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationPaymentGetOperationRequest](Requests/PaymentInitiation/PaymentInitiationPaymentGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationPaymentGetResponse](Models/PaymentInitiationPaymentGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationPaymentListResponse&gt; PaymentInitiationPaymentList(PaymentInitiationPaymentListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/payment_initiation/payment/list` endpoint can be used to retrieve all created payments. By default, the 10 most recent payments are returned. You can request more payments and paginate through the results using the optional `count` and `cursor` parameters.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiation.PaymentInitiationPaymentList(
        new PaymentInitiationPaymentListOperationRequest { Body = new PaymentInitiationPaymentListRequest() });
    // TODO: Handle 'response' of type PaymentInitiationPaymentListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationPaymentListOperationRequest](Requests/PaymentInitiation/PaymentInitiationPaymentListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationPaymentListResponse](Models/PaymentInitiationPaymentListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationPaymentReverseResponse&gt; PaymentInitiationPaymentReverse(PaymentInitiationPaymentReverseOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Reverse a previously initiated payment.

A payment can only be reversed once and will be refunded to the original sender's account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiation.PaymentInitiationPaymentReverse(
        new PaymentInitiationPaymentReverseOperationRequest
        {
            Body = new PaymentInitiationPaymentReverseRequest { PaymentId = "some example string" },
        });
    // TODO: Handle 'response' of type PaymentInitiationPaymentReverseResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationPaymentReverseOperationRequest](Requests/PaymentInitiation/PaymentInitiationPaymentReverseOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationPaymentReverseResponse](Models/PaymentInitiationPaymentReverseResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationRecipientCreateResponse&gt; PaymentInitiationRecipientCreate(PaymentInitiationRecipientCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a payment recipient for payment initiation.  The recipient must be in Europe, within a country that is a member of the Single Euro Payment Area (SEPA).  For a standing order (recurring) payment, the recipient must be in the UK.

The endpoint is idempotent: if a developer has already made a request with the same payment details, Plaid will return the same `recipient_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiation.PaymentInitiationRecipientCreate(
        new PaymentInitiationRecipientCreateOperationRequest
        {
            Body = new PaymentInitiationRecipientCreateRequest { Name = "some example string" },
        });
    // TODO: Handle 'response' of type PaymentInitiationRecipientCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationRecipientCreateOperationRequest](Requests/PaymentInitiation/PaymentInitiationRecipientCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationRecipientCreateResponse](Models/PaymentInitiationRecipientCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationRecipientGetResponse&gt; PaymentInitiationRecipientGet(PaymentInitiationRecipientGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get details about a payment recipient you have previously created.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiation.PaymentInitiationRecipientGet(
        new PaymentInitiationRecipientGetOperationRequest
        {
            Body = new PaymentInitiationRecipientGetRequest { RecipientId = "some example string" },
        });
    // TODO: Handle 'response' of type PaymentInitiationRecipientGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationRecipientGetOperationRequest](Requests/PaymentInitiation/PaymentInitiationRecipientGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationRecipientGetResponse](Models/PaymentInitiationRecipientGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationRecipientListResponse&gt; PaymentInitiationRecipientList(PaymentInitiationRecipientListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/payment_initiation/recipient/list` endpoint list the payment recipients that you have previously created.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiation.PaymentInitiationRecipientList(
        new PaymentInitiationRecipientListOperationRequest { Body = new PaymentInitiationRecipientListRequest() });
    // TODO: Handle 'response' of type PaymentInitiationRecipientListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationRecipientListOperationRequest](Requests/PaymentInitiation/PaymentInitiationRecipientListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationRecipientListResponse](Models/PaymentInitiationRecipientListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ProcessorApi

> Source: [ProcessorApi](Api/ProcessorApi.cs)

<details>
<summary><code>Task&lt;ProcessorTokenCreateResponse&gt; ProcessorApexProcessorTokenCreate(ProcessorApexProcessorTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Used to create a token suitable for sending to Apex to enable Plaid-Apex integrations.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorApi.ProcessorApexProcessorTokenCreate(
        new ProcessorApexProcessorTokenCreateOperationRequest
        {
            Body = new ProcessorApexProcessorTokenCreateRequest
            {
                AccessToken = "some example string",
                AccountId = "some example string",
            },
        });
    // TODO: Handle 'response' of type ProcessorTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorApexProcessorTokenCreateOperationRequest](Requests/ProcessorApi/ProcessorApexProcessorTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorTokenCreateResponse](Models/ProcessorTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorAuthGetResponse&gt; ProcessorAuthGet(ProcessorAuthGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/processor/auth/get` endpoint returns the bank account and bank identification number (such as the routing number, for US accounts), for a checking or savings account that's associated with a given `processor_token`. The endpoint also returns high-level account data and balances when available.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorApi.ProcessorAuthGet(new ProcessorAuthGetOperationRequest
    {
        Body = new ProcessorAuthGetRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorAuthGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorAuthGetOperationRequest](Requests/ProcessorApi/ProcessorAuthGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorAuthGetResponse](Models/ProcessorAuthGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorBalanceGetResponse&gt; ProcessorBalanceGet(ProcessorBalanceGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/processor/balance/get` endpoint returns the real-time balance for each of an Item's accounts. While other endpoints may return a balance object, only `/processor/balance/get` forces the available and current balance fields to be refreshed rather than cached.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorApi.ProcessorBalanceGet(new ProcessorBalanceGetOperationRequest
    {
        Body = new ProcessorBalanceGetRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorBalanceGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorBalanceGetOperationRequest](Requests/ProcessorApi/ProcessorBalanceGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorBalanceGetResponse](Models/ProcessorBalanceGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorBankTransferCreateResponse&gt; ProcessorBankTransferCreate(ProcessorBankTransferCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/processor/bank_transfer/create` endpoint to initiate a new bank transfer as a processor

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorApi.ProcessorBankTransferCreate(new ProcessorBankTransferCreateOperationRequest
    {
        Body = new ProcessorBankTransferCreateRequest
        {
            IdempotencyKey = "some example string",
            ProcessorToken = "some example string",
            Type = BankTransferType.Debit,
            Network = BankTransferNetwork.Ach,
            Amount = "some example string",
            IsoCurrencyCode = "some example string",
            Description = "some example string",
            User = new BankTransferUser { LegalName = "some example string" },
        },
    });
    // TODO: Handle 'response' of type ProcessorBankTransferCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorBankTransferCreateOperationRequest](Requests/ProcessorApi/ProcessorBankTransferCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorBankTransferCreateResponse](Models/ProcessorBankTransferCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorIdentityGetResponse&gt; ProcessorIdentityGet(ProcessorIdentityGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/processor/identity/get` endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorApi.ProcessorIdentityGet(new ProcessorIdentityGetOperationRequest
    {
        Body = new ProcessorIdentityGetRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorIdentityGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorIdentityGetOperationRequest](Requests/ProcessorApi/ProcessorIdentityGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorIdentityGetResponse](Models/ProcessorIdentityGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorStripeBankAccountTokenCreateResponse&gt; ProcessorStripeBankAccountTokenCreate(ProcessorStripeBankAccountTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Used to create a token suitable for sending to Stripe to enable Plaid-Stripe integrations. For a detailed guide on integrating Stripe, see [Add Stripe to your app](https://plaid.com/docs/auth/partnerships/stripe/).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorApi.ProcessorStripeBankAccountTokenCreate(
        new ProcessorStripeBankAccountTokenCreateOperationRequest
        {
            Body = new ProcessorStripeBankAccountTokenCreateRequest
            {
                AccessToken = "some example string",
                AccountId = "some example string",
            },
        });
    // TODO: Handle 'response' of type ProcessorStripeBankAccountTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorStripeBankAccountTokenCreateOperationRequest](Requests/ProcessorApi/ProcessorStripeBankAccountTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorStripeBankAccountTokenCreateResponse](Models/ProcessorStripeBankAccountTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorTokenCreateResponse&gt; ProcessorTokenCreate(ProcessorTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Used to create a token suitable for sending to one of Plaid's partners to enable integrations. Note that Stripe partnerships use bank account tokens instead; see `/processor/stripe/bank_account_token/create` for creating tokens for use with Stripe integrations.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorApi.ProcessorTokenCreate(new ProcessorTokenCreateOperationRequest
    {
        Body = new ProcessorTokenCreateRequest
        {
            AccessToken = "some example string",
            AccountId = "some example string",
            Processor = Processor.Achq,
        },
    });
    // TODO: Handle 'response' of type ProcessorTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorTokenCreateOperationRequest](Requests/ProcessorApi/ProcessorTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorTokenCreateResponse](Models/ProcessorTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Sandbox

> Source: [Sandbox](Api/Sandbox.cs)

<details>
<summary><code>Task&lt;SandboxBankTransferFireWebhookResponse&gt; SandboxBankTransferFireWebhook(SandboxBankTransferFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/bank_transfer/fire_webhook` endpoint to manually trigger a Bank Transfers webhook in the Sandbox environment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sandbox.SandboxBankTransferFireWebhook(
        new SandboxBankTransferFireWebhookOperationRequest
        {
            Body = new SandboxBankTransferFireWebhookRequest { Webhook = "some example string" },
        });
    // TODO: Handle 'response' of type SandboxBankTransferFireWebhookResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxBankTransferFireWebhookOperationRequest](Requests/Sandbox/SandboxBankTransferFireWebhookOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxBankTransferFireWebhookResponse](Models/SandboxBankTransferFireWebhookResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxBankTransferSimulateResponse&gt; SandboxBankTransferSimulate(SandboxBankTransferSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/bank_transfer/simulate` endpoint to simulate a bank transfer event in the Sandbox environment.  Note that while an event will be simulated and will appear when using endpoints such as `/bank_transfer/event/sync` or `/bank_transfer/event/list`, no transactions will actually take place and funds will not move between accounts, even within the Sandbox.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sandbox.SandboxBankTransferSimulate(new SandboxBankTransferSimulateOperationRequest
    {
        Body = new SandboxBankTransferSimulateRequest
        {
            BankTransferId = "some example string",
            EventType = "some example string",
        },
    });
    // TODO: Handle 'response' of type SandboxBankTransferSimulateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxBankTransferSimulateOperationRequest](Requests/Sandbox/SandboxBankTransferSimulateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxBankTransferSimulateResponse](Models/SandboxBankTransferSimulateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxIncomeFireWebhookResponse&gt; SandboxIncomeFireWebhook(SandboxIncomeFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/income/fire_webhook` endpoint to manually trigger an Income webhook in the Sandbox environment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sandbox.SandboxIncomeFireWebhook(new SandboxIncomeFireWebhookOperationRequest
    {
        Body = new SandboxIncomeFireWebhookRequest
        {
            IncomeVerificationId = "some example string",
            Webhook = "some example string",
            VerificationStatus = VerificationStatus3.VerificationStatusProcessingComplete,
        },
    });
    // TODO: Handle 'response' of type SandboxIncomeFireWebhookResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxIncomeFireWebhookOperationRequest](Requests/Sandbox/SandboxIncomeFireWebhookOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxIncomeFireWebhookResponse](Models/SandboxIncomeFireWebhookResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxItemFireWebhookResponse&gt; SandboxItemFireWebhook(SandboxItemFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/sandbox/item/fire_webhook` endpoint is used to test that code correctly handles webhooks. Calling this endpoint triggers a Transactions `DEFAULT_UPDATE` webhook to be fired for a given Sandbox Item. If the Item does not support Transactions, a `SANDBOX_PRODUCT_NOT_ENABLED` error will result.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sandbox.SandboxItemFireWebhook(new SandboxItemFireWebhookOperationRequest
    {
        Body = new SandboxItemFireWebhookRequest
        {
            AccessToken = "some example string",
            WebhookCode = "some example string",
        },
    });
    // TODO: Handle 'response' of type SandboxItemFireWebhookResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxItemFireWebhookOperationRequest](Requests/Sandbox/SandboxItemFireWebhookOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxItemFireWebhookResponse](Models/SandboxItemFireWebhookResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxItemResetLoginResponse&gt; SandboxItemResetLogin(SandboxItemResetLoginOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/sandbox/item/reset_login/` forces an Item into an `ITEM_LOGIN_REQUIRED` state in order to simulate an Item whose login is no longer valid. This makes it easy to test Link's [update mode](https://plaid.com/docs/link/update-mode) flow in the Sandbox environment.  After calling `/sandbox/item/reset_login`, You can then use Plaid Link update mode to restore the Item to a good state. An `ITEM_LOGIN_REQUIRED` webhook will also be fired after a call to this endpoint, if one is associated with the Item.


In the Sandbox, Items will transition to an `ITEM_LOGIN_REQUIRED` error state automatically after 30 days, even if this endpoint is not called.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sandbox.SandboxItemResetLogin(new SandboxItemResetLoginOperationRequest
    {
        Body = new SandboxItemResetLoginRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type SandboxItemResetLoginResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxItemResetLoginOperationRequest](Requests/Sandbox/SandboxItemResetLoginOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxItemResetLoginResponse](Models/SandboxItemResetLoginResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxItemSetVerificationStatusResponse&gt; SandboxItemSetVerificationStatus(SandboxItemSetVerificationStatusOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/sandbox/item/set_verification_status` endpoint can be used to change the verification status of an Item in in the Sandbox in order to simulate the Automated Micro-deposit flow.

Note that not all Plaid developer accounts are enabled for micro-deposit based verification by default. Your account must be enabled for this feature in order to test it in Sandbox. To enable this features or check your status, contact your account manager or [submit a product access Support ticket](https://dashboard.plaid.com/support/new/product-and-development/product-troubleshooting/request-product-access).

For more information on testing Automated Micro-deposits in Sandbox, see [Auth full coverage testing](https://plaid.com/docs/auth/coverage/testing#).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sandbox.SandboxItemSetVerificationStatus(
        new SandboxItemSetVerificationStatusOperationRequest
        {
            Body = new SandboxItemSetVerificationStatusRequest
            {
                AccessToken = "some example string",
                AccountId = "some example string",
                VerificationStatus = VerificationStatus1.AutomaticallyVerified,
            },
        });
    // TODO: Handle 'response' of type SandboxItemSetVerificationStatusResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxItemSetVerificationStatusOperationRequest](Requests/Sandbox/SandboxItemSetVerificationStatusOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxItemSetVerificationStatusResponse](Models/SandboxItemSetVerificationStatusResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; SandboxOauthSelectAccounts(SandboxOauthSelectAccountsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Save the selected accounts when connecting to the Platypus Oauth institution

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sandbox.SandboxOauthSelectAccounts(new SandboxOauthSelectAccountsOperationRequest
    {
        Body = new SandboxOauthSelectAccountsRequest
        {
            OauthStateId = "some example string",
            Accounts = ["some example string"],
        },
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxOauthSelectAccountsOperationRequest](Requests/Sandbox/SandboxOauthSelectAccountsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxProcessorTokenCreateResponse&gt; SandboxProcessorTokenCreate(SandboxProcessorTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/processor_token/create` endpoint to create a valid `processor_token` for an arbitrary institution ID and test credentials. The created `processor_token` corresponds to a new Sandbox Item. You can then use this `processor_token` with the `/processor/` API endpoints in Sandbox. You can also use `/sandbox/processor_token/create` with the [`user_custom` test username](https://plaid.com/docs/sandbox/user-custom) to generate a test account with custom data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sandbox.SandboxProcessorTokenCreate(new SandboxProcessorTokenCreateOperationRequest
    {
        Body = new SandboxProcessorTokenCreateRequest { InstitutionId = "some example string" },
    });
    // TODO: Handle 'response' of type SandboxProcessorTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxProcessorTokenCreateOperationRequest](Requests/Sandbox/SandboxProcessorTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxProcessorTokenCreateResponse](Models/SandboxProcessorTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxPublicTokenCreateResponse&gt; SandboxPublicTokenCreate(SandboxPublicTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/public_token/create`  endpoint to create a valid `public_token`  for an arbitrary institution ID, initial products, and test credentials. The created `public_token` maps to a new Sandbox Item. You can then call `/item/public_token/exchange` to exchange the `public_token` for an `access_token` and perform all API actions. `/sandbox/public_token/create` can also be used with the [`user_custom` test username](https://plaid.com/docs/sandbox/user-custom) to generate a test account with custom data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sandbox.SandboxPublicTokenCreate(new SandboxPublicTokenCreateOperationRequest
    {
        Body = new SandboxPublicTokenCreateRequest
        {
            InstitutionId = "some example string",
            InitialProducts = [Products.Assets],
        },
    });
    // TODO: Handle 'response' of type SandboxPublicTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxPublicTokenCreateOperationRequest](Requests/Sandbox/SandboxPublicTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxPublicTokenCreateResponse](Models/SandboxPublicTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxTransferSimulateResponse&gt; SandboxTransferSimulate(SandboxTransferSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/transfer/simulate` endpoint to simulate a transfer event in the Sandbox environment.  Note that while an event will be simulated and will appear when using endpoints such as `/transfer/event/sync` or `/transfer/event/list`, no transactions will actually take place and funds will not move between accounts, even within the Sandbox.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sandbox.SandboxTransferSimulate(new SandboxTransferSimulateOperationRequest
    {
        Body = new SandboxTransferSimulateRequest
        {
            TransferId = "some example string",
            EventType = "some example string",
        },
    });
    // TODO: Handle 'response' of type SandboxTransferSimulateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxTransferSimulateOperationRequest](Requests/Sandbox/SandboxTransferSimulateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxTransferSimulateResponse](Models/SandboxTransferSimulateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Signal

> Source: [Signal](Api/Signal.cs)

<details>
<summary><code>Task&lt;SignalDecisionReportResponse&gt; SignalDecisionReport(SignalDecisionReportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

After calling `/signal/evaluate`, call `/signal/decision/report` to report whether the transaction was initiated. This endpoint will return an `INVALID_REQUEST` error if called a second time with a different value for `initiated`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Signal.SignalDecisionReport(new SignalDecisionReportOperationRequest
    {
        Body = new SignalDecisionReportRequest { ClientTransactionId = "some example string", Initiated = true },
    });
    // TODO: Handle 'response' of type SignalDecisionReportResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignalDecisionReportOperationRequest](Requests/Signal/SignalDecisionReportOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignalDecisionReportResponse](Models/SignalDecisionReportResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignalEvaluateResponse&gt; SignalEvaluate(SignalEvaluateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use `/signal/evaluate` to evaluate a planned ACH transaction to get a return risk assessment (such as a risk score and risk tier) and additional risk signals.

In order to obtain a valid score for an ACH transaction, Plaid must have an access token for the account, and the Item must be healthy (receiving product updates) or have recently been in a healthy state. If the transaction does not meet eligibility requirements, an error will be returned corresponding to the underlying cause.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Signal.SignalEvaluate(new SignalEvaluateOperationRequest
    {
        Body = new SignalEvaluateRequest
        {
            AccessToken = "some example string",
            AccountId = "some example string",
            ClientTransactionId = "some example string",
            Amount = 1.5d,
        },
    });
    // TODO: Handle 'response' of type SignalEvaluateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignalEvaluateOperationRequest](Requests/Signal/SignalEvaluateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignalEvaluateResponse](Models/SignalEvaluateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignalReturnReportResponse&gt; SignalReturnReport(SignalReturnReportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Call the `/signal/return/report` endpoint to report a returned transaction that was previously sent to the `/signal/evaluate` endpoint. Your feedback will be used by the model to incorporate the latest risk trend in your portfolio.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Signal.SignalReturnReport(new SignalReturnReportOperationRequest
    {
        Body = new SignalReturnReportRequest
        {
            ClientTransactionId = "some example string",
            ReturnCode = "some example string",
        },
    });
    // TODO: Handle 'response' of type SignalReturnReportResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignalReturnReportOperationRequest](Requests/Signal/SignalReturnReportOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignalReturnReportResponse](Models/SignalReturnReportResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Transactions

> Source: [Transactions](Api/Transactions.cs)

<details>
<summary><code>Task&lt;TransactionsGetResponse&gt; TransactionsGet(TransactionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/transactions/get` endpoint allows developers to receive user-authorized transaction data for credit, depository, and some loan-type accounts (only those with account subtype `student`; coverage may be limited). For transaction history from investments accounts, use the [Investments endpoint](https://plaid.com/docs/api/products#investments) instead. Transaction data is standardized across financial institutions, and in many cases transactions are linked to a clean name, entity type, location, and category. Similarly, account data is standardized and returned with a clean name, number, balance, and other meta information where available.

Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.  Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in `/transactions/get`.  For more details, see [Pending and posted transactions](https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions).

Due to the potentially large number of transactions associated with an Item, results are paginated. Manipulate the `count` and `offset` parameters in conjunction with the `total_transactions` response body field to fetch all available transactions.

Data returned by `/transactions/get` will be the data available for the Item as of the most recent successful check for new transactions. Plaid typically checks for new data multiple times a day, but these checks may occur less frequently, such as once a day, depending on the institution. An Item's `status.transactions.last_successful_update` field will show the timestamp of the most recent successful update. To force Plaid to check for new transactions, you can use the `/transactions/refresh` endpoint.

Note that data may not be immediately available to `/transactions/get`. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with `transactions`, or upon the first call to `/transactions/get`, if it wasn't. To be alerted when transaction data is ready to be fetched, listen for the [`INITIAL_UPDATE`](https://plaid.com/docs/api/webhooks#transactions-initial_update) and [`HISTORICAL_UPDATE`](https://plaid.com/docs/api/webhooks#transactions-historical_update) webhooks. If no transaction history is ready when `/transactions/get` is called, it will return a `PRODUCT_NOT_READY` error.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.TransactionsGet(new TransactionsGetOperationRequest
    {
        Body = new TransactionsGetRequest
        {
            AccessToken = "some example string",
            StartDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
            EndDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
        },
    });
    // TODO: Handle 'response' of type TransactionsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransactionsGetOperationRequest](Requests/Transactions/TransactionsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionsGetResponse](Models/TransactionsGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionsRefreshResponse&gt; TransactionsRefresh(TransactionsRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/transactions/refresh` is an optional endpoint for users of the Transactions product. It initiates an on-demand extraction to fetch the newest transactions for an Item. This on-demand extraction takes place in addition to the periodic extractions that automatically occur multiple times a day for any Transactions-enabled Item. If changes to transactions are discovered after calling `/transactions/refresh`, Plaid will fire a webhook: [`TRANSACTIONS_REMOVED`](https://plaid.com/docs/api/webhooks#deleted-transactions-detected) will be fired if any removed transactions are detected, and [`DEFAULT_UPDATE`](https://plaid.com/docs/api/webhooks#transactions-default_update) will be fired if any new transactions are detected. New transactions can be fetched by calling `/transactions/get`.

Access to `/transactions/refresh` in Production is specific to certain pricing plans. If you cannot access `/transactions/refresh` in Production, [contact Sales](https://www.plaid.com/contact) for assistance.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.TransactionsRefresh(new TransactionsRefreshOperationRequest
    {
        Body = new TransactionsRefreshRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type TransactionsRefreshResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransactionsRefreshOperationRequest](Requests/Transactions/TransactionsRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionsRefreshResponse](Models/TransactionsRefreshResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransferApi

> Source: [TransferApi](Api/TransferApi.cs)

<details>
<summary><code>Task&lt;TransferAuthorizationCreateResponse&gt; TransferAuthorizationCreate(TransferAuthorizationCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/authorization/create` endpoint to determine transfer failure risk.

In Plaid's sandbox environment the decisions will be returned as follows:

  - To approve a transfer, make an authorization request with an `amount` less than the available balance in the account.

  - To decline a transfer with the rationale code `NSF`, the available balance on the account must be less than the authorization `amount`. See [Create Sandbox test data](https://plaid.com/docs/sandbox/user-custom/) for details on how to customize data in Sandbox.

  - To decline a transfer with the rationale code `RISK`, the available balance on the account must be exactly $0. See [Create Sandbox test data](https://plaid.com/docs/sandbox/user-custom/) for details on how to customize data in Sandbox.

  - To permit a transfer with the rationale code `MANUALLY_VERIFIED_ITEM`, create an Item in Link through the [Same Day Micro-deposits flow](https://plaid.com/docs/auth/coverage/testing/#testing-same-day-micro-deposits).

  - To permit a transfer with the rationale code `LOGIN_REQUIRED`, [reset the login for an Item](https://plaid.com/docs/sandbox/#item_login_required).

All username/password combinations other than the ones listed above will result in a decision of permitted and rationale code `ERROR`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferApi.TransferAuthorizationCreate(new TransferAuthorizationCreateOperationRequest
    {
        Body = new TransferAuthorizationCreateRequest
        {
            AccessToken = "some example string",
            AccountId = "some example string",
            Type = TransferType1.Debit,
            Network = TransferNetwork.Ach,
            Amount = "some example string",
            AchClass = AchClass.Arc,
            User = new TransferUserInRequest { LegalName = "some example string" },
        },
    });
    // TODO: Handle 'response' of type TransferAuthorizationCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferAuthorizationCreateOperationRequest](Requests/TransferApi/TransferAuthorizationCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferAuthorizationCreateResponse](Models/TransferAuthorizationCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferCancelResponse&gt; TransferCancel(TransferCancelOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/cancel` endpoint to cancel a transfer.  A transfer is eligible for cancelation if the `cancellable` property returned by `/transfer/get` is `true`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferApi.TransferCancel(new TransferCancelOperationRequest
    {
        Body = new TransferCancelRequest { TransferId = "some example string" },
    });
    // TODO: Handle 'response' of type TransferCancelResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferCancelOperationRequest](Requests/TransferApi/TransferCancelOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferCancelResponse](Models/TransferCancelResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferCreateResponse&gt; TransferCreate(TransferCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/create` endpoint to initiate a new transfer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferApi.TransferCreate(new TransferCreateOperationRequest
    {
        Body = new TransferCreateRequest
        {
            IdempotencyKey = "some example string",
            AccessToken = "some example string",
            AccountId = "some example string",
            AuthorizationId = "some example string",
            Type = TransferType1.Debit,
            Network = TransferNetwork.Ach,
            Amount = "some example string",
            Description = "some example string",
            AchClass = AchClass.Arc,
            User = new TransferUserInRequest { LegalName = "some example string" },
        },
    });
    // TODO: Handle 'response' of type TransferCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferCreateOperationRequest](Requests/TransferApi/TransferCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferCreateResponse](Models/TransferCreateResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferEventListResponse&gt; TransferEventList(TransferEventListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/event/list` endpoint to get a list of transfer events based on specified filter criteria.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferApi.TransferEventList(new TransferEventListOperationRequest
    {
        Body = new TransferEventListRequest(),
    });
    // TODO: Handle 'response' of type TransferEventListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferEventListOperationRequest](Requests/TransferApi/TransferEventListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferEventListResponse](Models/TransferEventListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferEventSyncResponse&gt; TransferEventSync(TransferEventSyncOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/transfer/event/sync` allows you to request up to the next 25 transfer events that happened after a specific `event_id`. Use the `/transfer/event/sync` endpoint to guarantee you have seen all transfer events.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferApi.TransferEventSync(new TransferEventSyncOperationRequest
    {
        Body = new TransferEventSyncRequest { AfterId = 1 },
    });
    // TODO: Handle 'response' of type TransferEventSyncResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferEventSyncOperationRequest](Requests/TransferApi/TransferEventSyncOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferEventSyncResponse](Models/TransferEventSyncResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferGetResponse&gt; TransferGet(TransferGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/transfer/get` fetches information about the transfer corresponding to the given `transfer_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferApi.TransferGet(new TransferGetOperationRequest
    {
        Body = new TransferGetRequest { TransferId = "some example string" },
    });
    // TODO: Handle 'response' of type TransferGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferGetOperationRequest](Requests/TransferApi/TransferGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferGetResponse](Models/TransferGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferListResponse&gt; TransferList(TransferListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/list` endpoint to see a list of all your transfers and their statuses. Results are paginated; use the `count` and `offset` query parameters to retrieve the desired transfers.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferApi.TransferList(new TransferListOperationRequest
    {
        Body = new TransferListRequest(),
    });
    // TODO: Handle 'response' of type TransferListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferListOperationRequest](Requests/TransferApi/TransferListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferListResponse](Models/TransferListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## WebhookVerificationKey

> Source: [WebhookVerificationKey](Api/WebhookVerificationKey.cs)

<details>
<summary><code>Task&lt;WebhookVerificationKeyGetResponse&gt; WebhookVerificationKeyGet(WebhookVerificationKeyGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Plaid signs all outgoing webhooks and provides JSON Web Tokens (JWTs) so that you can verify the authenticity of any incoming webhooks to your application. A message signature is included in the `Plaid-Verification` header.

The `/webhook_verification_key/get` endpoint provides a JSON Web Key (JWK) that can be used to verify a JWT.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhookVerificationKey.WebhookVerificationKeyGet(
        new WebhookVerificationKeyGetOperationRequest
        {
            Body = new WebhookVerificationKeyGetRequest { KeyId = "some example string" },
        });
    // TODO: Handle 'response' of type WebhookVerificationKeyGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WebhookVerificationKeyGetOperationRequest](Requests/WebhookVerificationKey/WebhookVerificationKeyGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WebhookVerificationKeyGetResponse](Models/WebhookVerificationKeyGetResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

