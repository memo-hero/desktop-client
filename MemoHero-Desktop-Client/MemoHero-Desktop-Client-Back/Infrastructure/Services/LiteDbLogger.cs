using ClientBack.Domain.Logger;
using LiteDB;
using System;

namespace ClientBack.Infrastructure.Services
{
    public class LiteDbLogger : ILogger
    {
        private readonly LiteDatabase database;
        private readonly string tableName = "logs";

        public LiteDbLogger(LiteDatabase database) => this.database = database;

        public void Log(Log log) => database.GetCollection<Log>(tableName).Upsert(log);

        public void Log(string message, Severity severity) => Log(new Log(message, severity));

        public void Log(Exception exception)
        {
            var message = $"{ exception.Message }\nStackTrace:\n{ exception.StackTrace }";

            Log(new Log(message, Severity.EXCEPTION));
        }
    }
}
