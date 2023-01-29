namespace ClientBack.Infrastructure.HTTP
{
    internal interface ISerializer
    {
        string Serialize<T>(T objectToSerialize);
        T Deserialize<T>(string value);
    }
}
