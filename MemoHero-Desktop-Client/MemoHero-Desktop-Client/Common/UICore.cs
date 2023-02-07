using ClientBack.Core;
using ClientBack.Domain.User;
using MemoHeroDesktopClient.CustomControls;
using MemoHeroDesktopClient.Infrastructure;
using MemoHeroDesktopClient.UI.Login;
using MemoHeroDesktopClient.UI.NewCard;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.Common
{
    internal class UICore
    {
        // Forms
        internal readonly LoginSplash login;
        internal UI.MainWindow.MainMenu mainMenu;
        internal NewCardWindow newCardWindow;

        // Events
        internal delegate void UserLoginHandler(object source, UserLoginResultArgs args);
        internal event UserLoginHandler UserLoggedIn;

        private readonly MemoHeroCore memoCore = MemoHeroServices.Core;

        // User Data
        private User user;
        
        // Controls
        private Dictionary<string, UserControl> customControls = new Dictionary<string, UserControl>();
        private UserStatsControl userStatsControl;
        private CardListControl cardListControl;

        public UICore()
        {
            login = new LoginSplash(this);
            mainMenu = new UI.MainWindow.MainMenu(this);
        }

        internal void InitializeControls()
        {
            var panel = mainMenu.mainPanel;

            userStatsControl = new UserStatsControl(user);
            customControls.Add("ribbonPageUserStatus", userStatsControl);
            panel.Controls.Add(userStatsControl);

            cardListControl = new CardListControl();
            cardListControl.SetDataSource(ref memoCore.UserCards);
            customControls.Add("ribbonPageCards", cardListControl);
            panel.Controls.Add(cardListControl);
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
            if (newCardWindow == null) newCardWindow = new NewCardWindow();
            newCardWindow.CardCreated += NewCardWindow_CardCreated;
            
            newCardWindow.ShowDialog();
        }

        private async void NewCardWindow_CardCreated(object source, CreateCardArgs args)
        {
            var card = await memoCore.CreateCardAsync(args.newCard);
            cardListControl.AddCard(card);
        }

        internal void Logout()
        {
            user = null;
            customControls.Clear();
            memoCore.Logout();
            mainMenu.Dispose();
            login.loginButton.Enabled = true;
            login.Show();
        }

        internal async void CheckService()
        {
            if (!await memoCore.IsServiceOnline())
            {
                MessageBox.Show("The services is down.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login.Close();
            }
        }

        internal async void StartLoginProcess(bool manualLogin)
        {
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
                if (manualLogin) mainMenu = new UI.MainWindow.MainMenu(this);
                user = await memoCore.GetUserInfo(user);
                await memoCore.GetUserCards(user.Id);
                mainMenu.Show();
                login.Hide();
                
                return;
            }

            OnUserLoggedIn(true);
        }

        protected virtual void OnUserLoggedIn(bool failed) => UserLoggedIn(this, new UserLoginResultArgs(failed));

        internal void CloseApplication()
        {
            login.Close();
        }
    }
}
