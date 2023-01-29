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
            // Now that we have the user's email, we can hash it and see if it exist in the service
            user.Id = HashTool.SHA256_hash(user.Email);
            var storedUser = await restClient.RetrieveUser(user.Id);
            if (user == null) storedUser = await restClient.CreateUser(new NewUser(user.Id));

            // Now that we have both the auth0 user and the service user, we return both
            user.Stats = storedUser.Stats;
            return user;
        }
    }
}
