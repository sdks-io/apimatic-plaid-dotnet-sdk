using ThePlaidApi.Core.Authentication;
using ThePlaidApi.Core.Authentication.ApiKey;

namespace ThePlaidApi;

internal sealed class AuthSchemes
{
    public IAuthScheme PlaidClientId { get; }
    public IAuthScheme PlaidSecret { get; }
    public IAuthScheme PlaidVersion { get; }

    public AuthSchemes(ThePlaidApiClientOptions options)
    {
        PlaidClientId = ApiKeyHeaderScheme.Create("PLAID-CLIENT-ID", options.PlaidClientId);
        PlaidSecret = ApiKeyHeaderScheme.Create("PLAID-SECRET", options.PlaidSecret);
        PlaidVersion = ApiKeyHeaderScheme.Create("Plaid-Version", options.PlaidVersion);
    }
}
