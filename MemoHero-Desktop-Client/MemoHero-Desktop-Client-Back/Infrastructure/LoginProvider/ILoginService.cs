using ClientBack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBack.Infrastructure.LoginProvider
{
    public interface ILoginService
    {
        Task<User> Login();
        void Logout();
    }
}
