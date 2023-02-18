using MemoHeroDesktopClient.Domain;
using MemoHeroDesktopClient.Domain.Events;
using System;

namespace MemoHeroDesktopClient.UI.Login
{
    internal partial class LoginSplash : DevExpress.XtraEditors.XtraForm
    {
        private readonly UICore uiCore;

        public LoginSplash(UICore uiCore)
        {
            InitializeComponent();

            this.uiCore = uiCore;
            this.uiCore.UserLoggedIn += UICore_UserLoggedIn;
        }

        private void UICore_UserLoggedIn(object source, UserLoginResultArgs args) => loginButton.Enabled = args.FailedLogin;
        private void loginButton_Click(object sender, EventArgs e) => uiCore.StartLoginProcess(true);
    }
}