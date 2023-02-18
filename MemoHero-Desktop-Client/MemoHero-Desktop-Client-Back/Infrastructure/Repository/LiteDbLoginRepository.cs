using ClientBack.Domain.Login;
using LiteDB;

namespace ClientBack.Infrastructure.Repository
{
    internal class LiteDbLoginRepository : ILoginRepository
    {
        private readonly LiteDatabase database;
        private readonly string tableName = "logins";

        internal LiteDbLoginRepository(LiteDatabase database) => this.database = database;

        public void Store(LoginResult loginResult)
        {
            var col = database.GetCollection<Login>(tableName);

            col.Upsert(new Login
            {
                Id = loginResult.user.Email,
                Expiration = loginResult.expiration,
                User = loginResult.user
            });
        }

        public Login Retrieve(string lastUser)
        {
            var col = database.GetCollection<Login>(tableName);

            var login = col.FindOne(x => x.Id == lastUser);
            return login;
        }

        public void RemoveLastLogin(string lastUser)
        {
            var col = database.GetCollection<Login>(tableName);

            col.Delete(lastUser);
        }
    }
}
