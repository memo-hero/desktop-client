using ClientBack.Domain.User;

namespace ClientBack.Infrastructure.HTTP
{
    internal class StoredUser
    {
        public string Id { get; set; }
        public UserStats Stats { get; set; }

    }
}