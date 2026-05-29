# Categories

```csharp
CategoriesApi categoriesApi = client.CategoriesApi;
```

## Class Name

`CategoriesApi`


# Categories Get

Send a request to the `/categories/get`  endpoint to get detailed information on categories returned by Plaid. This endpoint does not require authentication.

Find out more here: [/api/products/#categoriesget](/api/products/#categoriesget)

:information_source: **Note** This endpoint does not require authentication.

```csharp
CategoriesGetAsync(
    object body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | `object` | Body, Required | - |

## Response Type

**200**: success

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CategoriesGetResponse](../../doc/models/categories-get-response.md).

## Example Usage

```csharp
object body = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");
try
{
    ApiResponse<CategoriesGetResponse> result = await categoriesApi.CategoriesGetAsync(body);
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
  "categories": [
    {
      "category_id": "10000000",
      "group": "special",
      "hierarchy": [
        "Bank Fees"
      ]
    },
    {
      "category_id": "10001000",
      "group": "special",
      "hierarchy": [
        "Bank Fees",
        "Overdraft"
      ]
    },
    {
      "category_id": "12001000",
      "group": "place",
      "hierarchy": [
        "Community",
        "Animal Shelter"
      ]
    }
  ],
  "request_id": "ixTBLZGvhD4NnmB"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`ErrorErrorException`](../../doc/models/error-error-exception.md) |

