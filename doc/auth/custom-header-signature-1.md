
# Custom Header Signature



Documentation for accessing and setting credentials for PLAID-SECRET.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| PlaidSecret | `string` | - | `PlaidSecret` | `PlaidSecret` |



**Note:** Auth credentials can be set using `PlaidSecretCredentials` in the client builder and accessed through `PlaidSecretCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```csharp
using Plaid.Standard;
using Plaid.Standard.Authentication;

namespace ConsoleApp;

PlaidClient client = new PlaidClient.Builder()
    .PlaidSecretCredentials(
        new PlaidSecretModel.Builder(
            "PLAID-SECRET"
        )
        .Build())
    .Build();
```


