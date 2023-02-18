using System;

namespace ClientBack.Domain.Logger
{
    public class Log
    {
        public DateTime Id { get; set; }
        public string Message { get; set; }
        public bool SentToServer { get; set; }

        public Log(string message)
        {
            Id = DateTime.Now;
            Message = message;
            SentToServer = false;
        }
    }
}
