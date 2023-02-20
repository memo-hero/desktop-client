using ClientBack.Domain.Logger;
using ClientBack.Domain.Login;
using ClientBack.Infrastructure.LoginProvider;
using ClientBack.Infrastructure.Services;
using ClientBack.Infrastructure.Services.Logger;
using System;
using System.Threading.Tasks;

namespace ClientBack.Core
{
    internal class LoginModule
    {
        private static readonly ILogger logger = ClientBackServiceProvider.logger;
        private readonly string envVarName = "memohero-lastlogin-user";
        private readonly ILoginService loginService = ClientBackServiceProvider.LoginService;
        private readonly ILoginRepository repository = ClientBackServiceProvider.LoginRepository;

        internal bool IsLoggedIn()
        {
            logger.Log("Retrieving environment variable...", Severity.INFO);
            var lastUser = Environment.GetEnvironmentVariable(envVarName, EnvironmentVariableTarget.User);
            if (lastUser == null) return false;

            logger.Log("Retrieving user from local db...", Severity.INFO);
            var login = repository.Retrieve(lastUser);
            if (login == null) return false;
            return login.Expiration > DateTime.Now;
        }

        internal LoginResult GetUserFromLocalDb()
        {
            logger.Log("Retrieving environment variable...", Severity.INFO);
            var lastUser = Environment.GetEnvironmentVariable(envVarName, EnvironmentVariableTarget.User);
            
            logger.Log("Retrieving user from local db...", Severity.INFO);
            var login = repository.Retrieve(lastUser);

            if (login == null) return null;

            return new LoginResult
            {
                user = login.User,
                expiration = login.Expiration
            };
        }

        internal async Task<LoginResult> Login()
        {
            logger.Log("Retrieving environment variable...", Severity.INFO);
            var lastUser = Environment.GetEnvironmentVariable(envVarName, EnvironmentVariableTarget.User);

            LoginResult loginResult;
            if (lastUser == null) loginResult = await NewUserLoginAsync();
            else loginResult = await ExistingUserLoginAsync(lastUser);

            if (loginResult == null) return loginResult;

            return loginResult;
        }

        private async Task<LoginResult> ExistingUserLoginAsync(string lastUser)
        {
            logger.Log("Retrieving login from local db...", Severity.INFO);
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
            logger.Log("Invoking Auth0 Service...", Severity.INFO);
            var result = await ExceptionHandler.Execute(loginService.Login);
            repository.Store(result);
            return result;
        }

        internal void Logout()
        {
            logger.Log("Loging out...", Severity.INFO);
            loginService.Logout();
            var lastUser = Environment.GetEnvironmentVariable(envVarName, EnvironmentVariableTarget.User);
            repository.RemoveLastLogin(lastUser);
        }

        internal void UpdateLoginLocale(string newLocale)
        {
            logger.Log("Updating user locale...", Severity.INFO);
            var login = GetUserFromLocalDb();
            login.user.Locale = newLocale;
            repository.Store(login);
        }
    }
}
