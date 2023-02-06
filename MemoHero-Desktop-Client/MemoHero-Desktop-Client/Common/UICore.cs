using ClientBack.Core;
using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using MemoHeroDesktopClient.CustomControls;
using MemoHeroDesktopClient.Infrastructure;
using MemoHeroDesktopClient.UI.Login;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.Common
{
    internal class UICore
    {
        internal readonly LoginSplash login;
        internal readonly UI.MainWindow.MainMenu mainMenu;

        internal delegate void UserLoginHandler(object source, UserLoginResultArgs args);
        internal event UserLoginHandler UserLoggedIn;

        private readonly MemoHeroCore memoCore = MemoHeroServices.Core;
        //private readonly Panel panel;
        private User user;
        private Dictionary<string, UserControl> customControls = new Dictionary<string, UserControl>();
        private UserStatsControl userStatsControl;
        private CardListControl cardListControl;

        public UICore()
        {
            login = new LoginSplash(this);
            mainMenu = new UI.MainWindow.MainMenu(this);
            SetupPanel(mainMenu.mainPanel);
        }

        private void SetupPanel(Panel panel)
        {
            userStatsControl = new UserStatsControl(user);
            customControls.Add("ribbonPageUserStatus", userStatsControl);
            panel.Controls.Add(userStatsControl);

            cardListControl = new CardListControl();
            cardListControl.SetDataSource(cards);
            customControls.Add("ribbonPageCards", cardListControl);
            panel.Controls.Add(cardListControl);
        }

        internal void SetCardListControl(List<Card> cards)
        {
            
        }

        internal void UpdatePanel(string currentPageName)
        {
            foreach (var control in customControls)
            {
                control.Value.Visible = control.Key == currentPageName;
            }
        }

        internal void ShowNewCardForm()
        {

        }

        internal void Logout()
        {
            memoCore.Logout();
            mainMenu.Hide();
            login.loginButton.Enabled = true;
            login.Show();
        }

        internal void Login()
        {
            StartLoginProcess(true);
        }

        internal async void StartLoginProcess(bool manualLogin)
        {
            if (!await memoCore.IsServiceOnline())
            {
                MessageBox.Show("The services is down.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login.Close();
            }

            var isLogged = memoCore.IsLoggedIn();

            if (isLogged)
            {
                user = memoCore.GetLocalUser();
            }
            else if (manualLogin)
            {
                user = await memoCore.Login();
            }

            OnUserLoggedIn(user == null);
            if (user != null)
            {
                user = await memoCore.GetUserInfo(user);
                mainMenu.Show();
                login.Hide();
                
                return;
            }

            OnUserLoggedIn(true);
        }

        private void ShowMainMenuOnSuccessfulLogin()
        {

        }

        protected virtual void OnUserLoggedIn(bool failed) => UserLoggedIn(this, new UserLoginResultArgs(failed));

        internal void CloseApplication()
        {
            login.Close();
        }
    }
}
