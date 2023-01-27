using ClientBack.Infrastructure.LoginProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBack.Infrastructure.Services
{
    public static class ClientBackServiceProvider
    {
        public static ILoginService GetLoginService()
        {
            return new Auth0Provider();
        }
    }
}
