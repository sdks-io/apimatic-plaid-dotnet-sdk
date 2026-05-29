
# Custom Header Signature



Documentation for accessing and setting credentials for Plaid-Version.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| PlaidVersion | `string` | - | `PlaidVersion` | `PlaidVersion` |



**Note:** Auth credentials can be set using `PlaidVersionCredentials` in the client builder and accessed through `PlaidVersionCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```csharp
using Plaid.Standard;
using Plaid.Standard.Authentication;

namespace ConsoleApp;

PlaidClient client = new PlaidClient.Builder()
    .PlaidVersionCredentials(
        new PlaidVersionModel.Builder(
            "Plaid-Version"
        )
        .Build())
    .Build();
```


