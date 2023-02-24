using System;

namespace ClientBack.Domain.Logger
{
    public class Log
    {
        public string Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Message { get; set; }
        public Severity Severity { get; set; }
        public bool SentToServer { get; set; }

        public Log() { }

        public Log(User.User user, string message, Severity severity)
        {
            Id = user.Id;
            DateTime = DateTime.Now.ToUniversalTime();
            Message = message;
            Severity = severity;
            SentToServer = false;
        }
    }
}
