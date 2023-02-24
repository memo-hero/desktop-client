using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ClientBack.Infrastructure.LoginProvider
{
    public class Auth0User
    {
        public string Id { get; set; }
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
            Id = claims.Find(x => x.Type == "sub")?.Value ?? "";
            GivenName = claims.Find(x => x.Type == "given_name")?.Value ?? "";
            FamilyName = claims.Find(x => x.Type == "family_name")?.Value ?? "";
            Nickname = claims.Find(x => x.Type == "nickname")?.Value ?? "";
            Name = claims.Find(x => x.Type == "name")?.Value ?? "";
            Picture = claims.Find(x => x.Type == "picture").Value;
            Locale = claims.Find(x => x.Type == "locale")?.Value ?? "";
            Email = claims.Find(x => x.Type == "email").Value;
            Verified = GetClaimValue(claims, "email_verified", "True") == "True";
        }

        private string GetClaimValue(List<Claim> claims, string name, string defaultValue)
        {
            var claim = claims.Find(x => x.Type == name);
            if (claim == null) return defaultValue;
            else return claim.Value;
        }
    }
}
