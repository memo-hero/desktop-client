using ClientBack.Infrastructure.LoginProvider;
using ClientBack.Infrastructure.Repository;
using LiteDB;
using System.IO;

namespace ClientBack.Infrastructure.Services
{
    internal static class ClientBackServiceProvider
    {
        private static readonly LiteDatabase LiteDatabase = new LiteDatabase($@"{ Directory.GetCurrentDirectory() }\memohero.db");

        internal static ILoginService LoginService = new Auth0Provider();
        internal static ILoginRepository LoginRepository = new LiteDbLoginRepository(LiteDatabase);
    }
}
