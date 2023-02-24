using ClientBack.Domain.Logger;
using ClientBack.Domain.User;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClientBack.Infrastructure.Services.Logger
{
    public class LiteDbLogger : ILogger
    {
        private readonly LiteDatabase database;
        private readonly string tableName = "logs";
        private readonly LiteDbLoggerConfiguration configuration;
        private User currentUser;

        public LiteDbLogger(LiteDatabase database, LiteDbLoggerConfiguration configuration)
        {
            this.database = database;
            this.configuration = configuration;
        }

        public List<Log> GetUnpushedLogs() => database
                .GetCollection<Log>(tableName)
                .Find(x => x.userId == currentUser.Id && x.SentToServer == false)
                .ToList();

        public void Log(Log log)
        {
            if (currentUser == null) return;
            if (configuration.MinimumSeverity > log.Severity) return;
            database.GetCollection<Log>(tableName).Upsert(log);
        }

        public void Log(string message, Severity severity)
        {
            if (currentUser == null) return;
            Log(new Log(currentUser, message, severity));
        }

        public void Log(Exception exception)
        {
            if (currentUser == null) return;
            var message = $"{ exception.Message }\nStackTrace:\n{ exception.StackTrace }";

            Log(new Log(currentUser, message, Severity.ERROR));
        }

        public void SetUser(User user) => currentUser = user;

        public void UpdateLogs(List<Log> logs) => logs.ForEach(x => Log(x));
    }
}
