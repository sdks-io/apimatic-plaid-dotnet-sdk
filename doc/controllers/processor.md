# Processor

```csharp
ProcessorApi processorApi = client.ProcessorApi;
```

## Class Name

`ProcessorApi`

## Methods

* [Processor Bank Transfer Create](../../doc/controllers/processor.md#processor-bank-transfer-create)
* [Processor Balance Get](../../doc/controllers/processor.md#processor-balance-get)
* [Processor Auth Get](../../doc/controllers/processor.md#processor-auth-get)
* [Processor Identity Get](../../doc/controllers/processor.md#processor-identity-get)
* [Processor Apex Processor Token Create](../../doc/controllers/processor.md#processor-apex-processor-token-create)
* [Processor Token Create](../../doc/controllers/processor.md#processor-token-create)
* [Processor Stripe Bank Account Token Create](../../doc/controllers/processor.md#processor-stripe-bank-account-token-create)


# Processor Bank Transfer Create

Use the `/processor/bank_transfer/create` endpoint to initiate a new bank transfer as a processor

Find out more here: [/api/processors/#bank_transfercreate](/api/processors/#bank_transfercreate)

```csharp
ProcessorBankTransferCreateAsync(
    Models.ProcessorBankTransferCreateRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProcessorBankTransferCreateRequest`](../../doc/models/processor-bank-transfer-create-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ProcessorBankTransferCreateResponse](../../doc/models/processor-bank-transfer-create-response.md).

## Example Usage

```csharp
ProcessorBankTransferCreateRequest body = new ProcessorBankTransferCreateRequest
{
    IdempotencyKey = "idempotency_key2",
    ProcessorToken = "processor_token4",
    Type = BankTransferType.Debit,
    Network = BankTransferNetwork.Samedayach,
    Amount = "amount8",
    IsoCurrencyCode = "iso_currency_code0",
    Description = "description4",
    User = new BankTransferUser
    {
        LegalName = "legal_name8",
    },
};

try
{
    ApiResponse<ProcessorBankTransferCreateResponse> result = await processorApi.ProcessorBankTransferCreateAsync(body);
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
| Default | Error response | [`ErrorErrorException`](../../doc/models/error-error-exception.md) |


# Processor Balance Get

The `/processor/balance/get` endpoint returns the real-time balance for each of an Item's accounts. While other endpoints may return a balance object, only `/processor/balance/get` forces the available and current balance fields to be refreshed rather than cached.

Find out more here: [/api/processors/#processorbalanceget](/api/processors/#processorbalanceget)

```csharp
ProcessorBalanceGetAsync(
    Models.ProcessorBalanceGetRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProcessorBalanceGetRequest`](../../doc/models/processor-balance-get-request.md) | Body, Required | The `/processor/balance/get` endpoint returns the real-time balance for the account associated with a given `processor_token`.<br><br>The current balance is the total amount of funds in the account. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account.<br><br>Note that not all institutions calculate the available balance. In the event that available balance is unavailable from the institution, Plaid will return an available balance value of `null`. |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ProcessorBalanceGetResponse](../../doc/models/processor-balance-get-response.md).

## Example Usage

```csharp
ProcessorBalanceGetRequest body = new ProcessorBalanceGetRequest
{
    ProcessorToken = "processor_token4",
};

try
{
    ApiResponse<ProcessorBalanceGetResponse> result = await processorApi.ProcessorBalanceGetAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "account": {
    "account_id": "QKKzevvp33HxPWpoqn6rI13BxW4awNSjnw4xv",
    "balances": {
      "available": 100,
      "current": 110,
      "limit": null,
      "iso_currency_code": "USD",
      "unofficial_currency_code": null
    },
    "mask": "0000",
    "name": "Plaid Checking",
    "official_name": "Plaid Gold Checking",
    "subtype": "checking",
    "type": "depository"
  },
  "request_id": "1zlMf"
}
```


# Processor Auth Get

The `/processor/auth/get` endpoint returns the bank account and bank identification number (such as the routing number, for US accounts), for a checking or savings account that's associated with a given `processor_token`. The endpoint also returns high-level account data and balances when available.

Find out more here: [/api/processors/#processorauthget](/api/processors/#processorauthget)

```csharp
ProcessorAuthGetAsync(
    Models.ProcessorAuthGetRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProcessorAuthGetRequest`](../../doc/models/processor-auth-get-request.md) | Body, Required | - |

## Response Type

**200**: success

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ProcessorAuthGetResponse](../../doc/models/processor-auth-get-response.md).

## Example Usage

```csharp
ProcessorAuthGetRequest body = new ProcessorAuthGetRequest
{
    ProcessorToken = "processor_token4",
};

try
{
    ApiResponse<ProcessorAuthGetResponse> result = await processorApi.ProcessorAuthGetAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "account": {
    "account_id": "vzeNDwK7KQIm4yEog683uElbp9GRLEFXGK98D",
    "balances": {
      "available": 100,
      "current": 110,
      "iso_currency_code": "USD",
      "limit": null,
      "unofficial_currency_code": null
    },
    "mask": "0000",
    "name": "Plaid Checking",
    "official_name": "Plaid Gold Checking",
    "subtype": "checking",
    "type": "depository"
  },
  "numbers": {
    "ach": {
      "account": "9900009606",
      "account_id": "vzeNDwK7KQIm4yEog683uElbp9GRLEFXGK98D",
      "routing": "011401533",
      "wire_routing": "021000021"
    },
    "eft": {
      "account": "111122223333",
      "account_id": "vzeNDwK7KQIm4yEog683uElbp9GRLEFXGK98D",
      "institution": "021",
      "branch": "01140"
    },
    "international": {
      "account_id": "vzeNDwK7KQIm4yEog683uElbp9GRLEFXGK98D",
      "bic": "NWBKGB21",
      "iban": "GB29NWBK60161331926819"
    },
    "bacs": {
      "account": "31926819",
      "account_id": "vzeNDwK7KQIm4yEog683uElbp9GRLEFXGK98D",
      "sort_code": "601613"
    }
  },
  "request_id": "1zlMf"
}
```


# Processor Identity Get

The `/processor/identity/get` endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.

Find out more here: [/api/processors/#processoridentityget](/api/processors/#processoridentityget)

```csharp
ProcessorIdentityGetAsync(
    Models.ProcessorIdentityGetRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProcessorIdentityGetRequest`](../../doc/models/processor-identity-get-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ProcessorIdentityGetResponse](../../doc/models/processor-identity-get-response.md).

## Example Usage

```csharp
ProcessorIdentityGetRequest body = new ProcessorIdentityGetRequest
{
    ProcessorToken = "processor_token4",
};

try
{
    ApiResponse<ProcessorIdentityGetResponse> result = await processorApi.ProcessorIdentityGetAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "account": {
    "account_id": "XMGPJy4q1gsQoKd5z9R3tK8kJ9EWL8SdkgKMq",
    "balances": {
      "available": 100,
      "current": 110,
      "iso_currency_code": "USD",
      "limit": null,
      "unofficial_currency_code": null
    },
    "mask": "0000",
    "name": "Plaid Checking",
    "official_name": "Plaid Gold Standard 0% Interest Checking",
    "owners": [
      {
        "addresses": [
          {
            "data": {
              "city": "Malakoff",
              "country": "US",
              "postal_code": "14236",
              "region": "NY",
              "street": "2992 Cameron Road"
            },
            "primary": true
          },
          {
            "data": {
              "city": "San Matias",
              "country": "US",
              "postal_code": "93405-2255",
              "region": "CA",
              "street": "2493 Leisure Lane"
            },
            "primary": false
          }
        ],
        "emails": [
          {
            "data": "accountholder0@example.com",
            "primary": true,
            "type": "primary"
          },
          {
            "data": "accountholder1@example.com",
            "primary": false,
            "type": "secondary"
          },
          {
            "data": "extraordinarily.long.email.username.123456@reallylonghostname.com",
            "primary": false,
            "type": "other"
          }
        ],
        "names": [
          "Alberta Bobbeth Charleson"
        ],
        "phone_numbers": [
          {
            "data": "1112223333",
            "primary": false,
            "type": "home"
          },
          {
            "data": "1112224444",
            "primary": false,
            "type": "work"
          },
          {
            "data": "1112225555",
            "primary": false,
            "type": "mobile1"
          }
        ]
      }
    ],
    "subtype": "checking",
    "type": "depository"
  },
  "request_id": "eOPkBl6t33veI2J"
}
```


# Processor Apex Processor Token Create

Used to create a token suitable for sending to Apex to enable Plaid-Apex integrations.

Find out more here: [/none/](/none/)

```csharp
ProcessorApexProcessorTokenCreateAsync(
    Models.ProcessorApexProcessorTokenCreateRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProcessorApexProcessorTokenCreateRequest`](../../doc/models/processor-apex-processor-token-create-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ProcessorTokenCreateResponse](../../doc/models/processor-token-create-response.md).

## Example Usage

```csharp
ProcessorApexProcessorTokenCreateRequest body = new ProcessorApexProcessorTokenCreateRequest
{
    AccessToken = "access_token4",
    AccountId = "account_id8",
};

try
{
    ApiResponse<ProcessorTokenCreateResponse> result = await processorApi.ProcessorApexProcessorTokenCreateAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```


# Processor Token Create

Used to create a token suitable for sending to one of Plaid's partners to enable integrations. Note that Stripe partnerships use bank account tokens instead; see `/processor/stripe/bank_account_token/create` for creating tokens for use with Stripe integrations.

Find out more here: [/api/processors/#processortokencreate](/api/processors/#processortokencreate)

```csharp
ProcessorTokenCreateAsync(
    Models.ProcessorTokenCreateRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProcessorTokenCreateRequest`](../../doc/models/processor-token-create-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ProcessorTokenCreateResponse](../../doc/models/processor-token-create-response.md).

## Example Usage

```csharp
ProcessorTokenCreateRequest body = new ProcessorTokenCreateRequest
{
    AccessToken = "access_token4",
    AccountId = "account_id8",
    Processor = Processor.Astra,
};

try
{
    ApiResponse<ProcessorTokenCreateResponse> result = await processorApi.ProcessorTokenCreateAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "processor_token": "processor-sandbox-0asd1-a92nc",
  "request_id": "xrQNYZ7Zoh6R7gV"
}
```


# Processor Stripe Bank Account Token Create

Used to create a token suitable for sending to Stripe to enable Plaid-Stripe integrations. For a detailed guide on integrating Stripe, see [Add Stripe to your app](https://plaid.com/docs/auth/partnerships/stripe/).

Find out more here: [/api/processors/#processorstripebank_account_tokencreate](/api/processors/#processorstripebank_account_tokencreate)

```csharp
ProcessorStripeBankAccountTokenCreateAsync(
    Models.ProcessorStripeBankAccountTokenCreateRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProcessorStripeBankAccountTokenCreateRequest`](../../doc/models/processor-stripe-bank-account-token-create-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ProcessorStripeBankAccountTokenCreateResponse](../../doc/models/processor-stripe-bank-account-token-create-response.md).

## Example Usage

```csharp
ProcessorStripeBankAccountTokenCreateRequest body = new ProcessorStripeBankAccountTokenCreateRequest
{
    AccessToken = "access_token4",
    AccountId = "account_id8",
};

try
{
    ApiResponse<ProcessorStripeBankAccountTokenCreateResponse> result = await processorApi.ProcessorStripeBankAccountTokenCreateAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "stripe_bank_account_token": "btok_5oEetfLzPklE1fwJZ7SG",
  "request_id": "xrQNYZ7Zoh6R7gV"
}
```

