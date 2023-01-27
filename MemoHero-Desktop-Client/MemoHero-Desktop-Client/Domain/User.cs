using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoHeroDesktopClient.Domain
{
    public class User
    {
        string Nickname;
        string Email;
        string Picture;
        string Locale;

        internal static User FromLoginUser(ClientBack.User user)
        {
            return new User
            {
                Nickname = user.Nickname,
                Email = user.Email,
                Picture = user.Picture,
                Locale = user.Locale
            };
        }
    }
}
