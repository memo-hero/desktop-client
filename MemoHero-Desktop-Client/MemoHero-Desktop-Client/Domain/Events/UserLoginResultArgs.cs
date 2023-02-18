using System;

namespace MemoHeroDesktopClient.Domain.Events
{
    internal class UserLoginResultArgs : EventArgs
    {
        internal bool FailedLogin;
        public UserLoginResultArgs(bool result) => FailedLogin = result;
    }
}
