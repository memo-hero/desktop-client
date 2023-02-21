using ClientBack.Domain.Logger;

namespace ClientBack.Infrastructure.Services.Logger
{
    public class LiteDbLoggerConfiguration
    {
        internal readonly Severity MinimumSeverity;

        public LiteDbLoggerConfiguration(string minimumSeverity) => MinimumSeverity = (Severity)int.Parse(minimumSeverity);
    }
}
