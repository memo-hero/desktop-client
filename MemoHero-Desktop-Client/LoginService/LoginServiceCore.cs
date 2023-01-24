using Auth0.OidcClient;
using System.Threading.Tasks;

namespace LoginService
{
    public class LoginServiceCore
    {
        private const string domain = "dev-qxkjr-8h.us.auth0.com";
        private const string clientId = "tpUZcdeRhUZqSOseouBJjDdijnhuE3Tt";
        private const string redirectUri = "https://dev-qxkjr-8h.us.auth0.com/desktop-client";
        private Auth0Client client;

        public LoginServiceCore()
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

        public async Task<User> Login()
        {
            var loginResult = await client.LoginAsync();
            return new User(loginResult.User);
        }

        public async void Logout()
        {
            await client.LogoutAsync();
        }
    }
}
