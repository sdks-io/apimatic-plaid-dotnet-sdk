# Deposit Switch

```csharp
DepositSwitchApi depositSwitchApi = client.DepositSwitchApi;
```

## Class Name

`DepositSwitchApi`

## Methods

* [Deposit Switch Get](../../doc/controllers/deposit-switch.md#deposit-switch-get)
* [Deposit Switch Alt Create](../../doc/controllers/deposit-switch.md#deposit-switch-alt-create)
* [Deposit Switch Create](../../doc/controllers/deposit-switch.md#deposit-switch-create)
* [Deposit Switch Token Create](../../doc/controllers/deposit-switch.md#deposit-switch-token-create)


# Deposit Switch Get

This endpoint returns information related to how the user has configured their payroll allocation and the state of the switch. You can use this information to build logic related to the user's direct deposit allocation preferences.

Find out more here: [/api/products#deposit_switchget](/api/products#deposit_switchget)

```csharp
DepositSwitchGetAsync(
    Models.DepositSwitchGetRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DepositSwitchGetRequest`](../../doc/models/deposit-switch-get-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DepositSwitchGetResponse](../../doc/models/deposit-switch-get-response.md).

## Example Usage

```csharp
DepositSwitchGetRequest body = new DepositSwitchGetRequest
{
    DepositSwitchId = "deposit_switch_id4",
};

try
{
    ApiResponse<DepositSwitchGetResponse> result = await depositSwitchApi.DepositSwitchGetAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "target_item_id": "MdRAkq1QikR3BLjDyMfMkVpqLmEm1VR7bX5hE",
  "target_account_id": "bX5hEMdRAkq1QikR3BLjDyMfMkVpqLmEm1VR7",
  "deposit_switch_id": "LjDyMfMkVpqLmEm1VR7bQikR3BX5hEMdRAkq1",
  "state": "completed",
  "switch_method": "instant",
  "date_created": "2019-11-01",
  "date_completed": "2019-11-01",
  "account_has_multiple_allocations": true,
  "is_allocated_remainder": false,
  "percent_allocated": 50,
  "amount_allocated": null,
  "employer_name": "COMPANY INC",
  "employer_id": "pqLmEm1VR7bQi11231",
  "institution_name": "Bank of America",
  "institution_id": "ins_1",
  "request_id": "lMjeOeu9X1VUh1F"
}
```


# Deposit Switch Alt Create

This endpoint provides an alternative to `/deposit_switch/create` for customers who have not yet fully integrated with Plaid Exchange. Like `/deposit_switch/create`, it creates a deposit switch entity that will be persisted throughout the lifecycle of the switch.

Find out more here: [/api/products#deposit_switchaltcreate](/api/products#deposit_switchaltcreate)

```csharp
DepositSwitchAltCreateAsync(
    Models.DepositSwitchAltCreateRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DepositSwitchAltCreateRequest`](../../doc/models/deposit-switch-alt-create-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DepositSwitchAltCreateResponse](../../doc/models/deposit-switch-alt-create-response.md).

## Example Usage

```csharp
DepositSwitchAltCreateRequest body = new DepositSwitchAltCreateRequest
{
    TargetAccount = new DepositSwitchTargetAccount
    {
        AccountNumber = "account_number8",
        RoutingNumber = "routing_number6",
        AccountName = "account_name0",
        AccountSubtype = AccountSubtype1.Checking,
    },
    TargetUser = new DepositSwitchTargetUser
    {
        GivenName = "given_name6",
        FamilyName = "family_name8",
        Phone = "phone4",
        Email = "email2",
    },
};

try
{
    ApiResponse<DepositSwitchAltCreateResponse> result = await depositSwitchApi.DepositSwitchAltCreateAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "deposit_switch_id": "c7jMwPPManIwy9rwMewWP7lpb4pKRbtrbMomp",
  "request_id": "lMjeOeu9X1VUh1F"
}
```


# Deposit Switch Create

This endpoint creates a deposit switch entity that will be persisted throughout the lifecycle of the switch.

Find out more here: [/api/products#deposit_switchcreate](/api/products#deposit_switchcreate)

```csharp
DepositSwitchCreateAsync(
    Models.DepositSwitchCreateRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DepositSwitchCreateRequest`](../../doc/models/deposit-switch-create-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DepositSwitchCreateResponse](../../doc/models/deposit-switch-create-response.md).

## Example Usage

```csharp
DepositSwitchCreateRequest body = new DepositSwitchCreateRequest
{
    TargetAccessToken = "target_access_token4",
    TargetAccountId = "target_account_id2",
};

try
{
    ApiResponse<DepositSwitchCreateResponse> result = await depositSwitchApi.DepositSwitchCreateAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "deposit_switch_id": "c7jMwPPManIwy9rwMewWP7lpb4pKRbtrbMomp",
  "request_id": "lMjeOeu9X1VUh1F"
}
```


# Deposit Switch Token Create

In order for the end user to take action, you will need to create a public token representing the deposit switch. This token is used to initialize Link. It can be used one time and expires after 30 minutes.

Find out more here: [/deposit-switch/reference#deposit_switchtokencreate](/deposit-switch/reference#deposit_switchtokencreate)

```csharp
DepositSwitchTokenCreateAsync(
    Models.DepositSwitchTokenCreateRequest body)
```

## Authentication

This endpoint requires [PLAID-CLIENT-ID](../../doc/auth/custom-header-signature.md) **AND** [PLAID-SECRET](../../doc/auth/custom-header-signature-1.md) **AND** [Plaid-Version](../../doc/auth/custom-header-signature-2.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DepositSwitchTokenCreateRequest`](../../doc/models/deposit-switch-token-create-request.md) | Body, Required | - |

## Response Type

**200**: OK

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DepositSwitchTokenCreateResponse](../../doc/models/deposit-switch-token-create-response.md).

## Example Usage

```csharp
DepositSwitchTokenCreateRequest body = new DepositSwitchTokenCreateRequest
{
    DepositSwitchId = "deposit_switch_id4",
};

try
{
    ApiResponse<DepositSwitchTokenCreateResponse> result = await depositSwitchApi.DepositSwitchTokenCreateAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "deposit_switch_token": "deposit-switch-sandbox-3e5cacca-10a6-11ea-bcdb-6003089acac0",
  "deposit_switch_token_expiration_time": "2019-12-31T12:01:37Z",
  "request_id": "68MvHx4Ub5NYoXt"
}
```

