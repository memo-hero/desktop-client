using System.Linq;
using System.Security.Claims;

namespace ClientBack.Infrastructure.LoginProvider
{
    public class Auth0User
    {
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Nickname { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Locale { get; set; }
        public string Email { get; set; }
        public bool Verified { get; set; }

        public Auth0User() { /* A constructor is needed for deserialization */ }

        internal Auth0User(ClaimsPrincipal user)
        {
            var claims = user.Claims.ToList();
            GivenName = claims.Find(x => x.Type == "given_name")?.Value ?? "";
            FamilyName = claims.Find(x => x.Type == "family_name")?.Value ?? "";
            Nickname = claims.Find(x => x.Type == "nickname")?.Value ?? "";
            Name = claims.Find(x => x.Type == "name")?.Value ?? "";
            Picture = claims.Find(x => x.Type == "picture").Value;
            Locale = claims.Find(x => x.Type == "locale")?.Value ?? "";
            Email = claims.Find(x => x.Type == "email").Value;
            Verified = claims.Find(x => x.Type == "email_verified").Value == "True";
        }
    }
}
