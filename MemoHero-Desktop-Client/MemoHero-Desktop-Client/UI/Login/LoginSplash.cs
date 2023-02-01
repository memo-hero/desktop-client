using ClientBack.Core;
using ClientBack.Domain.User;
using DevExpress.XtraSplashScreen;
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
            SplashScreenManager.ShowForm(typeof(SplashScreen));
        }

        private async void Start()
        {
            if (!await memoCore.IsServiceOnline())
            {
                Close();
            }

            var isLogged = memoCore.IsLoggedIn();

            if (isLogged)
            {
                user = memoCore.GetLocalUser();
                GoToMainWindow();
            }
            loginButton.Enabled = true;
        }

        private void LoginSplash_Load(object sender, EventArgs e)
        {
            Start();
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
                SplashScreenManager.CloseForm();
                var mainWindow = new MainWindow.MainMenu(this, memoCore, user);
                user = await memoCore.GetUserInfo(user);
                mainWindow.Show();
                Hide();
            }
            loginButton.Enabled = true;
        }
    }
}