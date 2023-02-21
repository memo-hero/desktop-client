namespace ClientBack.Infrastructure.HTTP
{
    internal class HttpClientConfiguration
    {
        internal readonly string BaseUrl;

        public HttpClientConfiguration(string value, bool isSecure)
            => BaseUrl = $"http{ (isSecure ? "s" : string.Empty) }://{ value }/";
    }
}