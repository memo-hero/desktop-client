using Flagsmith;
using System.Threading.Tasks;

namespace ClientBack.Infrastructure.Services.Configuration
{
    internal class FlagsmithClient : IConfigurationProvider
    {
        private readonly Flagsmith.FlagsmithClient client = new Flagsmith.FlagsmithClient("JMThVixjs7ndLpKSL6oJKp");
        private Flags flags;

        public async Task<string> GetFeatureValue(string featureName)
        {
            await GetFlags();
            return await flags.GetFeatureValue(featureName);
        }

        public async Task<bool> IsFeatureEnabled(string featureName)
        {
            await GetFlags();
            return await flags.IsFeatureEnabled(featureName);
        }

        private async Task GetFlags()
        {
            if (flags == null) flags = await client.GetEnvironmentFlags();
        }
    }
}
