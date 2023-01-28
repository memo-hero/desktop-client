using ClientBack.Domain.User;
using ClientBack.Infrastructure.HTTP;
using ClientBack.Infrastructure.LoginProvider;

namespace ClientBack
{
    internal class LoginResult
    {
        internal Auth0User user;
        internal StoredUser storedUser;
        internal System.DateTimeOffset expiration;

        internal User ToUser()
        {
            return new User
            {
                Id = storedUser.Id,
                Nickname = user.Nickname,
                Email = user.Email,
                Picture = user.Picture,
                Locale = user.Locale,
                Stats = storedUser.Stats
            };
        }
    }
}
