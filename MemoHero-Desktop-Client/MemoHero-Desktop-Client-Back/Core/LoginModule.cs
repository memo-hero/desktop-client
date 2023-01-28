using ClientBack.Infrastructure.Helpers;
using ClientBack.Infrastructure.HTTP;
using ClientBack.Infrastructure.LoginProvider;
using ClientBack.Infrastructure.Repository;
using ClientBack.Infrastructure.Services;
using System;
using System.Threading.Tasks;

namespace ClientBack.Core
{
    internal class LoginModule
    {
        private readonly string envVarName = "memohero-lastlogin-user";
        private readonly ILoginService loginService = ClientBackServiceProvider.LoginService;
        private readonly ILoginRepository repository = ClientBackServiceProvider.LoginRepository;
        private readonly IMemoHeroRestClient restClient = ClientBackServiceProvider.RestClient;

        internal async Task<LoginResult> Login()
        {
            var lastUser = Environment.GetEnvironmentVariable("memohero-lastlogin-user", EnvironmentVariableTarget.User);

            LoginResult loginResult;
            if (lastUser == null) loginResult = await NewUserLoginAsync();
            else loginResult = await ExistingUserLoginAsync(lastUser);

            if (loginResult == null) return loginResult;

            // Now that we have the user's email, we can hash it and see if it exist in the service
            var userId = HashTool.SHA256_hash(loginResult.user.Email);
            var user = await restClient.RetrieveUser(userId);
            if (user == null) user = await restClient.CreateUser(new NewUser(userId));

            // Now that we have both the auth0 user and the service user, we return both
            loginResult.storedUser = user;
            return loginResult;
        }

        private async Task<LoginResult> ExistingUserLoginAsync(string lastUser)
        {
            var login = repository.Retrieve(lastUser);

            if (login == null) return await NewUserLoginAsync();
            if (login.Expiration < DateTime.Now) return await InternalLogin();

            return new LoginResult
            {
                user = login.User
            };
        }

        private async Task<LoginResult> NewUserLoginAsync()
        {
            var result = await InternalLogin();
            if (result != null)
                Environment.SetEnvironmentVariable(envVarName, result.user.Email, EnvironmentVariableTarget.User);

            return result;
        }

        private async Task<LoginResult> InternalLogin()
        {
            var result = await loginService.Login();
            repository.Store(result);
            return result;
        }

        internal void Logout()
        {
            loginService.Logout();
        }
    }
}
