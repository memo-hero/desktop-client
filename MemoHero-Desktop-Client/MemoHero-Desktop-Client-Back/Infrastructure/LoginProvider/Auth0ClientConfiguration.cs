namespace ClientBack
{
    internal class Auth0ClientConfiguration
    {
        internal readonly string Domain;
        internal readonly string ClientId;
        internal readonly string RedirectUri;

        public Auth0ClientConfiguration(string domain, string clientId, string redirectUri)
        {
            Domain = domain;
            ClientId = clientId;
            RedirectUri = redirectUri;
        }
    }
}
