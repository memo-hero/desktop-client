using Auth0.OidcClient;
using ClientBack.Infrastructure.LoginProvider;
using System.Threading.Tasks;

namespace ClientBack
{
    internal class Auth0Provider : ILoginService
    {
        private const string domain = "dev-qxkjr-8h.us.auth0.com";
        private const string clientId = "tpUZcdeRhUZqSOseouBJjDdijnhuE3Tt";
        private const string redirectUri = "https://dev-qxkjr-8h.us.auth0.com/desktop-client";
        private readonly Auth0Client client;

        internal Auth0Provider()
        {
            var clientOptions = new Auth0ClientOptions
            {
                Domain = domain,
                ClientId = clientId,
                RedirectUri = redirectUri
            };

            clientOptions.PostLogoutRedirectUri = clientOptions.RedirectUri;
            client = new Auth0Client(clientOptions);
        }

        public async Task<LoginResult> Login()
        {
            var loginResult = await client.LoginAsync();
            return new LoginResult
            {
                user = loginResult.IsError ? null : new Auth0User(loginResult.User),
                expiration = loginResult.AccessTokenExpiration
            };
        }

        public async void Logout()
        {
            await client.LogoutAsync();
        }
    }
}
