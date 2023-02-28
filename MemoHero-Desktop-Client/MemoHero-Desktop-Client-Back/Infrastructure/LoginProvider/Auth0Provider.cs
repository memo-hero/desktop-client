using Auth0.OidcClient;
using ClientBack.Infrastructure.LoginProvider;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace ClientBack
{
    internal class Auth0Provider : ILoginService
    {
        private readonly Auth0Client client;

        internal Auth0Provider(Auth0ClientConfiguration configuration)
        {
            var clientOptions = new Auth0ClientOptions
            {
                Domain = configuration.Domain,
                ClientId = configuration.ClientId,
                RedirectUri = configuration.RedirectUri
            };

            clientOptions.PostLogoutRedirectUri = clientOptions.RedirectUri;
            client = new Auth0Client(clientOptions);
        }

        public Task<LoginResult> Login()
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

            return Task.FromResult(new LoginResult
            {
                user = result.IsError ? null : new Auth0User(result.User),
                expiration = result.AccessTokenExpiration
            });
        }

        public void Logout()
        {
            // Due to multithreading issues, the auth0 client needs to run as single threaded
            var thread = new Thread(delegate ()
            {
                var dispatcher = Dispatcher.CurrentDispatcher;
                dispatcher.InvokeAsync(async delegate
                {
                    await client.LogoutAsync(federated: true);
                    dispatcher.BeginInvokeShutdown(DispatcherPriority.Normal);
                });

                Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
