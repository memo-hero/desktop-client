using System;

namespace ClientBack.Domain.Exceptions
{
    public class CannotConnectToRemoteService : Exception
    {
        public CannotConnectToRemoteService(string message) : base(message) { }
    }
}
