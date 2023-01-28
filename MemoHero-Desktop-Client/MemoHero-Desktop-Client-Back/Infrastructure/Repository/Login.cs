using ClientBack.Infrastructure.LoginProvider;
using System;

namespace ClientBack.Infrastructure.Repository
{
    public class Login
    {
        public string Id { get; set; }
        public DateTimeOffset Expiration { get; set; }
        public Auth0User User { get; set; }
    }
}
