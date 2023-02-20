using Auth0.OidcClient;
using ClientBack.Infrastructure.LoginProvider;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

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
            // Due to multithreading issues, the auth0 client needs to run as single threaded
            var tcs = new TaskCompletionSource<IdentityModel.OidcClient.LoginResult>();
            var thread = new Thread(delegate ()
            {
                var dispatcher = Dispatcher.CurrentDispatcher;
                dispatcher.InvokeAsync(async delegate
                {
                    var loginResult = await client.LoginAsync();
                    tcs.SetResult(loginResult);
                    dispatcher.BeginInvokeShutdown(DispatcherPriority.Normal);
                });

                Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            var result = tcs.Task.Result;

            return new LoginResult
            {
                user = result.IsError ? null : new Auth0User(result.User),
                expiration = result.AccessTokenExpiration
            };
        }

        public void Logout()
        {
            // Due to multithreading issues, the auth0 client needs to run as single threaded
            var thread = new Thread(delegate ()
            {
                var dispatcher = Dispatcher.CurrentDispatcher;
                dispatcher.InvokeAsync(async delegate
                {
                    await client.LogoutAsync();
                    dispatcher.BeginInvokeShutdown(DispatcherPriority.Normal);
                });

                Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
