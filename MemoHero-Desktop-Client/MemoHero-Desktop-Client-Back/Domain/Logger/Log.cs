using System;

namespace ClientBack.Domain.Logger
{
    public class Log
    {
        public DateTime Id { get; set; }
        public string Message { get; set; }
        public Severity Severity { get; set; }
        public bool SentToServer { get; set; }

        public Log() { }

        public Log(string message, Severity severity)
        {
            Id = DateTime.Now.ToUniversalTime();
            Message = message;
            Severity = severity;
            SentToServer = false;
        }
    }
}
