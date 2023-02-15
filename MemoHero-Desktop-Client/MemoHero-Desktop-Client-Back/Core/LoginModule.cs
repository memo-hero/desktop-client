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

        internal bool IsLoggedIn()
        {
            var lastUser = Environment.GetEnvironmentVariable(envVarName, EnvironmentVariableTarget.User);
            if (lastUser == null) return false;

            var login = repository.Retrieve(lastUser);
            if (login == null) return false;
            return login.Expiration > DateTime.Now;
        }

        internal LoginResult GetUserFromLocalDb()
        {
            var lastUser = Environment.GetEnvironmentVariable(envVarName, EnvironmentVariableTarget.User);
            var login = repository.Retrieve(lastUser);

            return new LoginResult
            {
                user = login.User
            };
        }

        internal async Task<LoginResult> Login()
        {
            var lastUser = Environment.GetEnvironmentVariable(envVarName, EnvironmentVariableTarget.User);

            LoginResult loginResult;
            if (lastUser == null) loginResult = await NewUserLoginAsync();
            else loginResult = await ExistingUserLoginAsync(lastUser);

            if (loginResult == null) return loginResult;

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
            var lastUser = Environment.GetEnvironmentVariable(envVarName, EnvironmentVariableTarget.User);
            repository.RemoveLastLogin(lastUser);
        }
    }
}
