using ClientBack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBack.Infrastructure.LoginProvider
{
    internal interface ILoginService
    {
        Task<LoginResult> Login();
        void Logout();
    }
}
