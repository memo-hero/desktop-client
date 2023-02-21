namespace ClientBack.Infrastructure.Services.Configuration
{
    static class EnumExtensions
    {
        public static string GetValue(this ConfigurationEnum configuration) => configuration.ToString().ToLower();
    }
}
