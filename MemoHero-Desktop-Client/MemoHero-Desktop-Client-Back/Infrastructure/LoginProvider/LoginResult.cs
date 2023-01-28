using ClientBack.Infrastructure.LoginProvider;

namespace ClientBack
{
    internal class LoginResult
    {
        internal Auth0User user;
        internal System.DateTimeOffset expiration;
    }
}
