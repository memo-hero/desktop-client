using ClientBack.Domain.Logger;
using LiteDB;

namespace ClientBack.Infrastructure.Services
{
    public class LiteDbLogger : ILogger
    {
        private readonly LiteDatabase database;
        private readonly string tableName = "logs";

        public LiteDbLogger(LiteDatabase database) => this.database = database;

        public void Log(Log log) => database.GetCollection<Log>(tableName).Upsert(log);

        public void Log(string message) => Log(new Log(message));
    }
}
