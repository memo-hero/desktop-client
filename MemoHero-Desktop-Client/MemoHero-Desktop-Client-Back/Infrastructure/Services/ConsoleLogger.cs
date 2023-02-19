using ClientBack.Domain.Logger;
using System;
using System.Collections.Generic;

namespace ClientBack.Infrastructure.Services
{
    public class ConsoleLogger : ILogger
    {
        public List<Log> GetUnpushedLogs() => new List<Log>();

        public void Log(Log log) => Console.WriteLine($"{ log.Id } { log.Message }");

        public void Log(string message, Severity severity) => Log(new Log(message, severity));

        public void Log(Exception exception)
        {
            var message = $"{ exception.Message }\nStackTrace:\n{ exception.StackTrace }";

            Log(new Log(message, Severity.ERROR));
        }

        public void UpdateLogs(List<Log> logs) { }
    }
}
