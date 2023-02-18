using ClientBack.Domain.Logger;
using ClientBack.Domain.Login;
using ClientBack.Infrastructure.Helpers;
using ClientBack.Infrastructure.HTTP;
using ClientBack.Infrastructure.LoginProvider;
using ClientBack.Infrastructure.Repository;
using LiteDB;
using System.IO;

namespace ClientBack.Infrastructure.Services
{
    public static class ClientBackServiceProvider
    {
        public static readonly LiteDatabase LiteDatabase = new LiteDatabase($@"{ Directory.GetCurrentDirectory() }\memohero.db");
        public static readonly ISerializer serializer = new NewtonSoftSerializer();
        public static readonly ILogger logger = new LiteDbLogger(LiteDatabase);

        internal static ILoginRepository LoginRepository = new LiteDbLoginRepository(LiteDatabase);
        internal static ILoginService LoginService = new Auth0Provider();
        internal static IMemoHeroRestClient RestClient = new HttpClientService(serializer);
    }
}
