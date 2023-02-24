using System;

namespace ClientBack.Domain.Logger
{
    public class Log
    {
        public string Id { get; set; }
        public string userId { get; set; }
        public DateTime DateTime { get; set; }
        public string Message { get; set; }
        public Severity Severity { get; set; }
        public bool SentToServer { get; set; }

        public Log() { }

        public Log(User.User user, string message, Severity severity)
        {
            userId = user.Id;
            DateTime = DateTime.Now.ToUniversalTime();
            Id = $"{DateTime.Ticks }-{ userId }";
            Message = message;
            Severity = severity;
            SentToServer = false;
        }
    }
}
