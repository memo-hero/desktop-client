namespace ClientBack.Infrastructure.HTTP
{
    public interface ISerializer
    {
        string Serialize<T>(T objectToSerialize);
        T Deserialize<T>(string value);
    }
}
