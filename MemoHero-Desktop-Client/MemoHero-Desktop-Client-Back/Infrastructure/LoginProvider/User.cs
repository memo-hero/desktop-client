using System.Linq;
using System.Security.Claims;

namespace ClientBack
{
    public class User
    {
        public readonly string GivenName;
        public readonly string FamilyName;
        public readonly string Nickname;
        public readonly string Name;
        public readonly string Picture;
        public readonly string Locale;
        public readonly string Email;
        public readonly bool Verified;

        public User(ClaimsPrincipal user)
        {
            var claims = user.Claims.ToList();
            GivenName = claims.Find(x => x.Type == "given_name").Value;
            FamilyName = claims.Find(x => x.Type == "family_name").Value;
            Nickname = claims.Find(x => x.Type == "nickname").Value;
            Name = claims.Find(x => x.Type == "name").Value;
            Picture = claims.Find(x => x.Type == "picture").Value;
            Locale = claims.Find(x => x.Type == "locale").Value;
            Email = claims.Find(x => x.Type == "email").Value;
            Verified = claims.Find(x => x.Type == "email_verified").Value == "True";
        }
    }
}
