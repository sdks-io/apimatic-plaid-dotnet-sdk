# Income

```csharp
IncomeApi incomeApi = client.IncomeApi;
```

## Class Name

`IncomeApi`

## Methods

* [Income Verification Taxforms Get](../../doc/controllers/income.md#income-verification-taxforms-get)
* [Income Verification Paystub Get](../../doc/controllers/income.md#income-verification-paystub-get)
* [Income Verification Documents Download](../../doc/controllers/income.md#income-verification-documents-download)
* [Income Verification Refresh](../../doc/controllers/income.md#income-verification-refresh)
* [Income Verification Paystubs Get](../../doc/controllers/income.md#income-verification-paystubs-get)
* [Income Verification Precheck](../../doc/controllers/income.md#income-verification-precheck)
* [Income Verification Summary Get](../../doc/controllers/income.md#income-verification-summary-get)
* [Income Verification Create](../../doc/controllers/income.md#income-verification-create)


# Income Verification Taxforms Get

`/income/verification/taxforms/get` returns the information collected from taxforms that were used to verify an end user's. It can be called once the status of the verification has been set to `VERIFICATION_STATUS_PROCESSING_COMPLETE`, as reported by the `INCOME: verification_status` webhook. Attempting to call the endpoint before verification has been completed will result in an error.

Find out more here: [/api/products#incomeverificationtaxformsget](/api/products#incomeverificationtaxformsget)

```csharp
IncomeVerificationTaxformsGetAsync(
    Models.IncomeVerificationTaxformsGetRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`IncomeVerificationTaxformsGetRequest`](../../doc/models/income-verification-taxforms-get-request.md) | Body, Required | - |

## Response Type

**200**: success

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.IncomeVerificationTaxformsGetResponse](../../doc/models/income-verification-taxforms-get-response.md).

## Example Usage

```csharp
IncomeVerificationTaxformsGetRequest body = new IncomeVerificationTaxformsGetRequest
{
};

try
{
    ApiResponse<IncomeVerificationTaxformsGetResponse> result = await incomeApi.IncomeVerificationTaxformsGetAsync(body);
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


# Income Verification Paystub Get

(Deprecated) Retrieve information from a single paystub used for income verification

```csharp
IncomeVerificationPaystubGetAsync(
    Models.IncomeVerificationPaystubGetRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`IncomeVerificationPaystubGetRequest`](../../doc/models/income-verification-paystub-get-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.IncomeVerificationPaystubGetResponse](../../doc/models/income-verification-paystub-get-response.md).

## Example Usage

```csharp
IncomeVerificationPaystubGetRequest body = new IncomeVerificationPaystubGetRequest
{
};

try
{
    ApiResponse<IncomeVerificationPaystubGetResponse> result = await incomeApi.IncomeVerificationPaystubGetAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "request_id": "2pxQ59buGdsHRef",
  "document_metadata": {
    "name": "paystub.pdf",
    "status": "DOCUMENT_STATUS_PROCESSING_COMPLETE",
    "doc_id": "2jkflanbd"
  },
  "paystub": {
    "deductions": {
      "subtotals": [],
      "totals": []
    },
    "doc_id": "2jkflanbd",
    "earnings": {
      "subtotals": [],
      "totals": []
    },
    "employee": {
      "address": {
        "city": "SAN FRANCISCO",
        "country": "US",
        "postal_code": "94133",
        "region": "CA",
        "street": "2140 TAYLOR ST"
      },
      "name": "ANNA CHARLESTON"
    },
    "employer": {
      "name": "PLAID INC",
      "address": {
        "city": "SAN FRANCISCO",
        "country": "US",
        "postal_code": "94111",
        "region": "CA",
        "street": "1098 HARRISON ST"
      }
    },
    "employment_details": {
      "annual_salary": {
        "amount": 60000,
        "currency": "USD"
      },
      "hire_date": "2020-09-15"
    },
    "net_pay": {
      "distribution_details": [],
      "total": {
        "canonical_description": "NET PAY",
        "description": "TOTAL NET PAY",
        "ytd_pay": {
          "amount": 39456,
          "currency": "USD"
        },
        "current_pay": {
          "amount": 1490.21,
          "currency": "USD"
        }
      }
    },
    "income_breakdown": [],
    "pay_period_details": {
      "check_amount": 1490.21,
      "end_date": "2020-12-15",
      "gross_earnings": 4500,
      "pay_day": "2020-12-15",
      "start_date": "2020-12-01"
    },
    "paystub_details": {
      "pay_frequency": "BI-WEEKLY",
      "paystub_provider": "ADP",
      "pay_period_start_date": "2020-12-01",
      "pay_period_end_date": "2020-12-15",
      "pay_date": "2020-12-15"
    },
    "ytd_earnings": {
      "gross_earnings": 59375,
      "net_earnings": 39456
    }
  }
}
```


# Income Verification Documents Download

`/income/verification/documents/download` provides the ability to download the source paystub PDF that the end user uploaded via Paystub Import.

The response to `/income/verification/documents/download` is a ZIP file in binary data. The `request_id`  is returned in the `Plaid-Request-ID` header.

For Payroll Income, the most recent file available for download with the payroll provider will also be available from this endpoint.

Find out more here: [/api/products/#incomeverificationdocumentsdownload](/api/products/#incomeverificationdocumentsdownload)

```csharp
IncomeVerificationDocumentsDownloadAsync(
    Models.IncomeVerificationDocumentsDownloadRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`IncomeVerificationDocumentsDownloadRequest`](../../doc/models/income-verification-documents-download-request.md) | Body, Required | - |

## Response Type

**200**: A ZIP file containing the source paystub(s) used as the basis for income verification.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type dynamic.

## Example Usage

```csharp
IncomeVerificationDocumentsDownloadRequest body = new IncomeVerificationDocumentsDownloadRequest
{
};

try
{
    ApiResponse<dynamic> result = await incomeApi.IncomeVerificationDocumentsDownloadAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```


# Income Verification Refresh

`/income/verification/refresh` refreshes a given income verification.

Find out more here: [/api/products/#incomeverificationrefresh](/api/products/#incomeverificationrefresh)

```csharp
IncomeVerificationRefreshAsync(
    Models.IncomeVerificationRefreshRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`IncomeVerificationRefreshRequest`](../../doc/models/income-verification-refresh-request.md) | Body, Required | - |

## Response Type

**200**: success

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.IncomeVerificationRefreshResponse](../../doc/models/income-verification-refresh-response.md).

## Example Usage

```csharp
IncomeVerificationRefreshRequest body = new IncomeVerificationRefreshRequest
{
};

try
{
    ApiResponse<IncomeVerificationRefreshResponse> result = await incomeApi.IncomeVerificationRefreshAsync(body);
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


# Income Verification Paystubs Get

`/income/verification/paystubs/get` returns the information collected from the paystubs that were used to verify an end user's income. It can be called once the status of the verification has been set to `VERIFICATION_STATUS_PROCESSING_COMPLETE`, as reported by the `INCOME: verification_status` webhook. Attempting to call the endpoint before verification has been completed will result in an error.

Find out more here: [/api/products/#incomeverificationpaystubsget](/api/products/#incomeverificationpaystubsget)

```csharp
IncomeVerificationPaystubsGetAsync(
    Models.IncomeVerificationPaystubsGetRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`IncomeVerificationPaystubsGetRequest`](../../doc/models/income-verification-paystubs-get-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.IncomeVerificationPaystubsGetResponse](../../doc/models/income-verification-paystubs-get-response.md).

## Example Usage

```csharp
IncomeVerificationPaystubsGetRequest body = new IncomeVerificationPaystubsGetRequest
{
};

try
{
    ApiResponse<IncomeVerificationPaystubsGetResponse> result = await incomeApi.IncomeVerificationPaystubsGetAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```


# Income Verification Precheck

`/income/verification/precheck` returns whether a given user is supportable by the income product

```csharp
IncomeVerificationPrecheckAsync(
    Models.IncomeVerificationPrecheckRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`IncomeVerificationPrecheckRequest`](../../doc/models/income-verification-precheck-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.IncomeVerificationPrecheckResponse](../../doc/models/income-verification-precheck-response.md).

## Example Usage

```csharp
IncomeVerificationPrecheckRequest body = new IncomeVerificationPrecheckRequest
{
};

try
{
    ApiResponse<IncomeVerificationPrecheckResponse> result = await incomeApi.IncomeVerificationPrecheckAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```


# Income Verification Summary Get

`/income/verification/summary/get` returns a verification summary for the income that was verified for an end user. It can be called once the status of the verification has been set to `VERIFICATION_STATUS_PROCESSING_COMPLETE`, as reported by the `INCOME: verification_status` webhook. Attempting to call the endpoint before verification has been completed will result in an error.

Find out more here: [/api/products/#incomeverificationsummaryget](/api/products/#incomeverificationsummaryget)

```csharp
IncomeVerificationSummaryGetAsync(
    Models.IncomeVerificationSummaryGetRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`IncomeVerificationSummaryGetRequest`](../../doc/models/income-verification-summary-get-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.IncomeVerificationSummaryGetResponse](../../doc/models/income-verification-summary-get-response.md).

## Example Usage

```csharp
IncomeVerificationSummaryGetRequest body = new IncomeVerificationSummaryGetRequest
{
};

try
{
    ApiResponse<IncomeVerificationSummaryGetResponse> result = await incomeApi.IncomeVerificationSummaryGetAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```


# Income Verification Create

`/income/verification/create` begins the income verification process by returning an `income_verification_id`. You can then provide the `income_verification_id` to `/link/token/create` under the `income_verification` parameter in order to create a Link instance that will prompt the user to go through the income verification flow. Plaid will fire an `INCOME` webhook once the user completes the Payroll Income flow, or when the uploaded documents in the Document Income flow have finished processing.

Find out more here: [/api/products/#incomeverificationcreate](/api/products/#incomeverificationcreate)

```csharp
IncomeVerificationCreateAsync(
    Models.IncomeVerificationCreateRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`IncomeVerificationCreateRequest`](../../doc/models/income-verification-create-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.IncomeVerificationCreateResponse](../../doc/models/income-verification-create-response.md).

## Example Usage

```csharp
IncomeVerificationCreateRequest body = new IncomeVerificationCreateRequest
{
    Webhook = "webhook4",
};

try
{
    ApiResponse<IncomeVerificationCreateResponse> result = await incomeApi.IncomeVerificationCreateAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "income_verification_id": "f2a826d7-25cf-483b-a124-c40beb64b732",
  "request_id": "lMjeOeu9X1VUh1F"
}
```

