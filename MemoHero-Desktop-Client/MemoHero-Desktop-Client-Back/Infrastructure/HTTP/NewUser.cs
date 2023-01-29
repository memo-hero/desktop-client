namespace ClientBack.Infrastructure.HTTP
{
    public class NewUser
    {
        public string id;
        public NewUser(string email)
        {
            id = email;
        }
    }
}