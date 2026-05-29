
# Custom Header Signature



Documentation for accessing and setting credentials for PLAID-CLIENT-ID.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| PlaidClientId | `string` | - | `PlaidClientId` | `PlaidClientId` |



**Note:** Auth credentials can be set using `PlaidClientIdCredentials` in the client builder and accessed through `PlaidClientIdCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```csharp
using Plaid.Standard;
using Plaid.Standard.Authentication;

namespace ConsoleApp;

PlaidClient client = new PlaidClient.Builder()
    .PlaidClientIdCredentials(
        new PlaidClientIdModel.Builder(
            "PLAID-CLIENT-ID"
        )
        .Build())
    .Build();
```


