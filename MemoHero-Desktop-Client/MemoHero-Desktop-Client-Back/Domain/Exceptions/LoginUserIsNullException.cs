using System;

namespace ClientBack.Domain.Exceptions
{
    class LoginUserIsNullException : Exception
    {
        public LoginUserIsNullException(string message = "") : base(message) { }
    }
}
