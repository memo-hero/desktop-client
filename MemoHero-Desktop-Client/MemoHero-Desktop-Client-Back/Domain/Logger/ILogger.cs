using System;
using System.Collections.Generic;

namespace ClientBack.Domain.Logger
{
    public interface ILogger
    {
        void SetUser(User.User user);
        void Log(Log log);
        void Log(string message, Severity severity);
        void Log(Exception exception);
        List<Log> GetUnpushedLogs();
        void UpdateLogs(List<Log> logs);
    }
}
