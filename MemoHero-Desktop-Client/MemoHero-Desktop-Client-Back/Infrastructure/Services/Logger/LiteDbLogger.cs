using ClientBack.Domain.Logger;
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
        private readonly Severity minimumSeverity = Severity.INFO;

        public LiteDbLogger(LiteDatabase database) => this.database = database;

        public List<Log> GetUnpushedLogs() => database
                .GetCollection<Log>(tableName)
                .Find(x => x.SentToServer == false)
                .ToList();

        public void Log(Log log)
        {
            if (minimumSeverity > log.Severity) return;
            database.GetCollection<Log>(tableName).Upsert(log);
        }

        public void Log(string message, Severity severity) => Log(new Log(message, severity));

        public void Log(Exception exception)
        {
            var message = $"{ exception.Message }\nStackTrace:\n{ exception.StackTrace }";

            Log(new Log(message, Severity.ERROR));
        }

        public void UpdateLogs(List<Log> logs) => logs.ForEach(x => Log(x));
    }
}
