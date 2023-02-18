using ClientBack.Domain.Logger;
using System;

namespace ClientBack.Infrastructure.Services
{
    public class ConsoleLogger : ILogger
    {
        public void Log(Log log) => Console.WriteLine($"{ log.Id } { log.Message }");

        public void Log(string message, Severity severity) => Log(new Log(message, severity));

        public void Log(Exception exception)
        {
            var message = $"{ exception.Message }\nStackTrace:\n{ exception.StackTrace }";

            Log(new Log(message, Severity.EXCEPTION));
        }
    }
}
