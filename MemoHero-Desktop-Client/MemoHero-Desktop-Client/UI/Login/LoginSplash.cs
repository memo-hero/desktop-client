using ClientBack.Core;
using ClientBack.Domain.User;
using MemoHeroDesktopClient.Infrastructure;
using System;

namespace MemoHeroDesktopClient.UI.Login
{
    public partial class LoginSplash : DevExpress.XtraEditors.XtraForm
    {
        private readonly MemoHeroCore memoCore = MemoHeroServices.Core;
        private User user;

        public LoginSplash()
        {
            InitializeComponent();
        }

        private void LoginSplash_Load(object sender, EventArgs e)
        {
            var isLogged = memoCore.IsLoggedIn();

            if (isLogged)
            {
                user = memoCore.GetLocalUser();
            }

            GoToMainWindow();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            user = await memoCore.Login();
            GoToMainWindow();
        }

        private async void GoToMainWindow()
        {
            if(user != null)
            {
                var mainWindow = new MainWindow.MainMenu(this, memoCore, user);
                user = await memoCore.GetUserInfo(user);
                mainWindow.Show();
                Hide();
            }
        }
    }
}