using ClientBack.Domain.User;
using System.Threading.Tasks;

namespace ClientBack.Core
{
    public class MemoHeroCore
    {
        readonly LoginModule loginModule;

        public MemoHeroCore()
        {
            loginModule = new LoginModule();
        }

        public async Task<User> Login()
        {
            var result = await loginModule.Login();
            
            return result?.ToUser();
        }

        public void Logout()
        {
            loginModule.Logout();
        }
    }
}
