using System;

namespace MemoHeroDesktopClient.Common
{
    internal class UserLoginResultArgs : EventArgs
    {
        internal bool FailedLogin;
        public UserLoginResultArgs(bool result)
        {
            FailedLogin = result;
        }
    }
}
