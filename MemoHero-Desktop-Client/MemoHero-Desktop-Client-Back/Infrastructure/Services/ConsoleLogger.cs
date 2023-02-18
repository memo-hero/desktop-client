using ClientBack.Domain.Logger;
using System;

namespace ClientBack.Infrastructure.Services
{
    public class ConsoleLogger : ILogger
    {
        public void Log(Log log) => Console.WriteLine($"{ log.Id } { log.Message }");

        public void Log(string message) => Log(new Log(message));
    }
}
