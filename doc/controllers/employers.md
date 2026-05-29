# Employers

```csharp
EmployersApi employersApi = client.EmployersApi;
```

## Class Name

`EmployersApi`


# Employers Search

`/employers/search` allows you the ability to search Plaid’s database of known employers, for use with Deposit Switch. You can use this endpoint to look up a user's employer in order to confirm that they are supported. Users with non-supported employers can then be routed out of the Deposit Switch flow.

The data in the employer database is currently limited. As the Deposit Switch and Income products progress through their respective beta periods, more employers are being regularly added. Because the employer database is frequently updated, we recommend that you do not cache or store data from this endpoint for more than a day.

Find out more here: [/api/employers/#employerssearch](/api/employers/#employerssearch)

```csharp
EmployersSearchAsync(
    Models.EmployersSearchRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`EmployersSearchRequest`](../../doc/models/employers-search-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.EmployersSearchResponse](../../doc/models/employers-search-response.md).

## Example Usage

```csharp
EmployersSearchRequest body = new EmployersSearchRequest
{
    Query = "query6",
    Products = new List<string>
    {
        "products4",
    },
};

try
{
    ApiResponse<EmployersSearchResponse> result = await employersApi.EmployersSearchAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "employers": [
    {
      "name": "Plaid Inc.",
      "address": {
        "city": "San Francisco",
        "country": "US",
        "postal_code": "94103",
        "region": "CA",
        "street": "1098 Harrison St"
      },
      "confidence_score": 1,
      "employer_id": "emp_1"
    }
  ],
  "request_id": "ixTBLZGvhD4NnmB"
}
```

