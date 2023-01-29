using ClientBack.Domain.User;
using ClientBack.Infrastructure.Helpers;
using ClientBack.Infrastructure.LoginProvider;

namespace ClientBack
{
    internal class LoginResult
    {
        internal Auth0User user;
        internal System.DateTimeOffset expiration;

        internal User ToUser()
        {
            return new User
            {
                Id = HashTool.SHA256_hash(user.Email),
                Nickname = user.Nickname,
                Email = user.Email,
                Picture = user.Picture,
                Locale = user.Locale
            };
        }
    }
}
