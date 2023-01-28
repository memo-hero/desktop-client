using ClientBack.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            
            return result?.user.ToUser();
        }

        public void Logout()
        {
            loginModule.Logout();
        }
    }
}
