# Investments

```csharp
InvestmentsApi investmentsApi = client.InvestmentsApi;
```

## Class Name

`InvestmentsApi`

## Methods

* [Investments Transactions Get](../../doc/controllers/investments.md#investments-transactions-get)
* [Investments Holdings Get](../../doc/controllers/investments.md#investments-holdings-get)


# Investments Transactions Get

The `/investments/transactions/get` endpoint allows developers to retrieve user-authorized transaction data for investment accounts.

Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.

Due to the potentially large number of investment transactions associated with an Item, results are paginated. Manipulate the count and offset parameters in conjunction with the `total_investment_transactions` response body field to fetch all available investment transactions.

Find out more here: [/api/products/#investmentstransactionsget](/api/products/#investmentstransactionsget)

```csharp
InvestmentsTransactionsGetAsync(
    Models.InvestmentsTransactionsGetRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`InvestmentsTransactionsGetRequest`](../../doc/models/investments-transactions-get-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.InvestmentsTransactionsGetResponse](../../doc/models/investments-transactions-get-response.md).

## Example Usage

```csharp
InvestmentsTransactionsGetRequest body = new InvestmentsTransactionsGetRequest
{
    AccessToken = "access_token4",
    StartDate = DateTime.Parse("2016-03-13"),
    EndDate = DateTime.Parse("2016-03-13"),
};

try
{
    ApiResponse<InvestmentsTransactionsGetResponse> result = await investmentsApi.InvestmentsTransactionsGetAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```


# Investments Holdings Get

The `/investments/holdings/get` endpoint allows developers to receive user-authorized stock position data for `investment`-type accounts.

Find out more here: [/api/products/#investmentsholdingsget](/api/products/#investmentsholdingsget)

```csharp
InvestmentsHoldingsGetAsync(
    Models.InvestmentsHoldingsGetRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`InvestmentsHoldingsGetRequest`](../../doc/models/investments-holdings-get-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.InvestmentsHoldingsGetResponse](../../doc/models/investments-holdings-get-response.md).

## Example Usage

```csharp
InvestmentsHoldingsGetRequest body = new InvestmentsHoldingsGetRequest
{
    AccessToken = "access_token4",
};

try
{
    ApiResponse<InvestmentsHoldingsGetResponse> result = await investmentsApi.InvestmentsHoldingsGetAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

