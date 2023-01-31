namespace ClientBack.Infrastructure.Repository
{
    internal interface ILoginRepository
    {
        void Store(LoginResult loginResult);
        void RemoveLastLogin(string lastUser);
        Login Retrieve(string lastUser);
    }
}
