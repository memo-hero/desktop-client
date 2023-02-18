using System;

namespace ClientBack.Domain.Logger
{
    public interface ILogger
    {
        void Log(Log log);
        void Log(string message, Severity severity);
        void Log(Exception exception);
    }
}
