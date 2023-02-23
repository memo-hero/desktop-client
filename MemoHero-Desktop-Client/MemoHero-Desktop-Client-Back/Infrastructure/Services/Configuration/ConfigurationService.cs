using ClientBack.Infrastructure.HTTP;
using ClientBack.Infrastructure.Services.Logger;
using System.Threading.Tasks;

namespace ClientBack.Infrastructure.Services.Configuration
{
    public class ConfigurationService
    {
        private readonly IConfigurationProvider configurationProvider;

        public ConfigurationService(IConfigurationProvider configurationProvider) => this.configurationProvider = configurationProvider;

        internal LiteDbLoggerConfiguration GetLoggerConfiguration()
        {
            var value = GetConfigValue(ConfigurationEnum.WINDOWS_APP_MINIMUM_SEVERITY).Result;
            return new LiteDbLoggerConfiguration(value);
        }

        internal Auth0ClientConfiguration GetAuth0Configuration()
        {
            var domain = GetConfigValue(ConfigurationEnum.WINDOWS_APP_AUTH0_DOMAIN).Result;
            var clientId = GetConfigValue(ConfigurationEnum.WINDOWS_APP_AUTH0_CLIENT_ID).Result;
            var redirectUri = GetConfigValue(ConfigurationEnum.WINDOWS_APP_AUTH0_REDIRECT_URI).Result;
            return new Auth0ClientConfiguration(domain, clientId, redirectUri);
        }

        internal HttpClientConfiguration GetHttpClientConfiguration()
        {
            var endpoint = GetConfigValue(ConfigurationEnum.SERVICE_ENDPOINT).Result;
            var isSecure = IsFeatureEnabled(ConfigurationEnum.SERVICE_ENDPOINT_IS_SECURE).Result;

            return new HttpClientConfiguration(endpoint, isSecure);
        }

        private async Task<string> GetConfigValue(ConfigurationEnum configuration)
            => await configurationProvider.GetFeatureValue(configuration.GetValue());

        private async Task<bool> IsFeatureEnabled(ConfigurationEnum configuration)
            => await configurationProvider.IsFeatureEnabled(configuration.GetValue());
    }
}
