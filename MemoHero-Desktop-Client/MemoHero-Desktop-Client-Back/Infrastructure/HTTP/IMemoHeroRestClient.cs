using System.Threading.Tasks;

namespace ClientBack.Infrastructure.HTTP
{
    interface IMemoHeroRestClient
    {
        Task<StoredUser> CreateUser(NewUser newUser);
        Task<StoredUser> RetrieveUser(string id);
    }
}
