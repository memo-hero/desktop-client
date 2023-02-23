using ClientBack.Domain.User;
using ClientBack.Infrastructure.Helpers;
using ClientBack.Infrastructure.HTTP;
using System.Threading.Tasks;

namespace ClientBack.Core
{
    internal class UserModule
    {
        private readonly IMemoHeroRestClient restClient;

        public UserModule(IMemoHeroRestClient restClient)
        {
            this.restClient = restClient;
        }

        internal async Task<User> GetUserInfo(User user)
        {
            var storedUser = await restClient.RetrieveUser(user.Id);
            if (storedUser == null) storedUser = await restClient.CreateUser(new NewUser(user.Id));

            user.Stats = storedUser.Stats;
            return user;
        }
    }
}
