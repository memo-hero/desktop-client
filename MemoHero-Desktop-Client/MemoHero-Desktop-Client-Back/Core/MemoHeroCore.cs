using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using ClientBack.Infrastructure.HTTP;
using ClientBack.Infrastructure.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientBack.Core
{
    public class MemoHeroCore
    {
        private readonly LoginModule loginModule;
        private readonly IMemoHeroRestClient restClient = ClientBackServiceProvider.RestClient;

        public MemoHeroCore()
        {
            loginModule = new LoginModule();
        }

        public async Task<User> Login()
        {
            var result = await loginModule.Login();
            
            return result?.ToUser();
        }

        public async Task<List<Card>> GetUserCards(string userId)
        {
            return await restClient.GetUserCards(userId);
        }

        public void Logout()
        {
            loginModule.Logout();
        }
    }
}
