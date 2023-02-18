namespace ClientBack.Domain.Logger
{
    public interface ILogger
    {
        void Log(Log log);
        void Log(string message);
    }
}
