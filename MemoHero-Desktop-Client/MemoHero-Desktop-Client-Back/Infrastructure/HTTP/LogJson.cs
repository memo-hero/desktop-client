using ClientBack.Domain.Logger;
using System;
using System.Reflection;

namespace ClientBack.Infrastructure.HTTP
{
    internal class LogJson
    {
        public long timestamp { get; set; }
        public string message { get; set; }
        public string source { get; set; }
        public Severity severity { get; set; }

        public LogJson(Log log)
        {
            timestamp = DateTimeToNano(log.Id);
            message = $"app_version={ Assembly.GetExecutingAssembly().GetName().Version } { log.Message }";
            source = "MEMOHERO_DESKTOP";
            severity = log.Severity;
        }

        private long DateTimeToNano(DateTime dateTime)
        {
            var epochTime = dateTime.ToUniversalTime().Ticks - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks;
            return epochTime *= 100;
        }
    }
}