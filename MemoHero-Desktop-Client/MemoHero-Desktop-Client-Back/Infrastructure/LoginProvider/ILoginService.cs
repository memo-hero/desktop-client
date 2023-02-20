using System.Threading.Tasks;

namespace ClientBack.Infrastructure.LoginProvider
{
    internal interface ILoginService
    {
        Task<LoginResult> Login();
        void Logout();
    }
}
