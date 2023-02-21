using System.Threading.Tasks;

namespace ClientBack.Infrastructure.Services.Configuration
{
    public interface IConfigurationProvider
    {
        Task<string> GetFeatureValue(string featureName);
        Task<bool> IsFeatureEnabled(string featureName);
    }
}
