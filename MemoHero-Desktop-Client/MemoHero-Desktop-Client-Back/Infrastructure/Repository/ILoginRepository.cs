namespace ClientBack.Infrastructure.Repository
{
    internal interface ILoginRepository
    {
        void Store(LoginResult loginResult);
        Login Retrieve(string lastUser);
    }
}
