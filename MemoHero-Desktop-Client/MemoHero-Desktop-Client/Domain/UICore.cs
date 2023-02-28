using ClientBack.Core;
using ClientBack.Domain.Cards;
using ClientBack.Domain.Study;
using ClientBack.Domain.User;
using MemoHeroDesktopClient.Common;
using MemoHeroDesktopClient.CustomControls;
using MemoHeroDesktopClient.Domain.Events;
using MemoHeroDesktopClient.Domain.Localization;
using MemoHeroDesktopClient.Services;
using MemoHeroDesktopClient.Services.ExceptionHandler;
using MemoHeroDesktopClient.Services.FileManagement;
using MemoHeroDesktopClient.UI.EditCard;
using MemoHeroDesktopClient.UI.Login;
using MemoHeroDesktopClient.UI.NewCard;
using MemoHeroDesktopClient.UI.StudyCards;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.Domain
{
    internal class UICore
    {
        // Forms
        internal readonly LoginSplash login;
        internal PrivateFontCollection fontCollection;

        internal EditCardForm editCardForm;
        internal UI.MainWindow.MainMenu mainMenuForm;
        internal NewCardForm newCardForm;
        internal StudyCardsForm studyCardsForm;
        private static readonly ILocalization localizationService = MemoHeroServices.TranslationService;

        // Controls
        private readonly Dictionary<string, UserControl> customControls = new Dictionary<string, UserControl>();

        private readonly MemoHeroCore memoCore = MemoHeroServices.Core;

        private CardListControl cardListControl;

        private CardListControl dueCardsControl;

        // User Data
        private User user;

        private UserStatsControl userStatsControl;

        public UICore()
        {
            login = new LoginSplash(this);
            mainMenuForm = new UI.MainWindow.MainMenu(this);
            LocalizationService.LocalizationChanged += LocalizationService_LocalizationChanged;
        }

        internal delegate void StudyResultHandler(object source, StudyResultHandlerArgs args);

        // Events
        internal delegate void UserLoginHandler(object source, UserLoginResultArgs args);

        internal event StudyResultHandler StudyResult;

        internal event UserLoginHandler UserLoggedIn;
        internal static ILocalization LocalizationService => localizationService;

        internal void CloseApplication() => login.Close();

        internal async Task DeleteSelectedCard()
        {
            var selectedCard = cardListControl.GetSelectedCard();
            if (selectedCard == null) return;

            var response = MessagesRepository.ShowDeleteCardConfirmation();
            if (response == DialogResult.OK)
            {
                if (await memoCore.DeleteCard(selectedCard))
                {
                    await UpdateCardListControl();
                    UpdateDueCardsControl();
                }
            }
        }

        internal void ExportCards()
        {
            var cards = memoCore.ExportCards();
            if (!string.IsNullOrWhiteSpace(cards)) FileManager.SaveFile(cards);
        }

        internal async Task GetCardsFromServer() => await UpdateCardListControl();

        internal async Task ImportCards()
        {
            var content = FileManager.OpenFile();
            await memoCore.ImportCards(content);
            UpdateDueCardsControl();
        }

        internal void InitializeControls()
        {
            var panel = mainMenuForm.mainPanel;

            userStatsControl = new UserStatsControl(user);
            customControls.Add("pageUserStatus", userStatsControl);
            panel.Controls.Add(userStatsControl);

            dueCardsControl = new CardListControl();
            customControls.Add("pageStudy", dueCardsControl);
            dueCardsControl.Visible = false;
            dueCardsControl.Dock = DockStyle.Fill;
            dueCardsControl.SetDataSource(ref memoCore.DueCards);
            panel.Controls.Add(dueCardsControl);

            cardListControl = new CardListControl();
            cardListControl.Visible = false;
            cardListControl.Dock = DockStyle.Fill;
            cardListControl.SetDataSource(ref memoCore.UserCards);
            customControls.Add("pageCards", cardListControl);
            panel.Controls.Add(cardListControl);
        }

        internal void Logout()
        {
            ClearState();
            login.loginButton.Enabled = true;
            login.Show();
        }

        internal void ShowEditCardForm()
        {
            var selectedCard = cardListControl.GetSelectedCard();
            if (selectedCard == null) return;

            editCardForm = new EditCardForm(selectedCard);
            editCardForm.CardEdited += EditCardWindow_CardEdited;
            editCardForm.ShowDialog();
        }

        internal void ShowNewCardForm()
        {
            newCardForm = new NewCardForm();
            newCardForm.CardCreated += NewCardWindow_CardCreated;
            newCardForm.StartPosition = FormStartPosition.CenterParent;

            newCardForm.ShowDialog();
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
                if (manualLogin) mainMenuForm = new UI.MainWindow.MainMenu(this);
                user = await memoCore.GetUserInfo(user);
                await memoCore.GetUserDueCards();
                mainMenuForm.Show();
                login.Hide();

                return;
            }

            OnUserLoggedIn(true);
        }

        internal void StudyFilteredCards()
        {
            var cards = dueCardsControl.GetCards();
            if (cards.Count == 0) return;

            LoadFont();
            using (studyCardsForm = new StudyCardsForm(this, ref user, new Queue<Card>(cards), new StudyStatsControl()))
            {
                studyCardsForm.UserResponded += StudyCardsForm_UserResponded;
                studyCardsForm.StartPosition = FormStartPosition.CenterParent;
                studyCardsForm.ShowDialog();
                UpdateDueCardsControl();
            }
        }

        internal void UpdatePanel(string currentPageName)
        {
            foreach (var control in customControls)
            {
                control.Value.Visible = control.Key == currentPageName;
            }
        }

        protected virtual void OnStudyResult(StudyResult result) => StudyResult(this, new StudyResultHandlerArgs(result));

        protected virtual void OnUserLoggedIn(bool failed) => UserLoggedIn(this, new UserLoginResultArgs(failed));

        private void ClearState()
        {
            user = null;
            customControls.Clear();
            memoCore.Logout();
            mainMenuForm.Dispose();
        }

        private async void EditCardWindow_CardEdited(object source, EditCardArgs args)
        {
            await ExceptionHandler.Execute(async () =>
            {
                if (await memoCore.UpdateCardAsync(args.editedCard))
                {
                    cardListControl.UpdateCard(args.editedCard);
                    UpdateDueCardsControl();
                };
            });
        }

        private void LocalizationService_LocalizationChanged(object source, LocalizationChangedEventArgs args)
        {
            cardListControl.UpdateGrid();
            dueCardsControl.UpdateGrid();
            user.Locale = args.ISOCode;
            memoCore.UpdateLocale();
        }
        private async void NewCardWindow_CardCreated(object source, CreateCardArgs args)
        {
            await ExceptionHandler.Execute(async () =>
            {
                await memoCore.CreateCardAsync(args.newCard);
                dueCardsControl.UpdateGrid();
            });
        }

        private async void StudyCardsForm_UserResponded(object source, UserResponseArgs args)
        {
            await ExceptionHandler.Execute(async () =>
            {
                var result = await memoCore.StudyCard(args.Card, args.Quality);
                user.Stats = result.UserStats;
                userStatsControl.UpdateTableStats(user);
                OnStudyResult(result);
            });
        }

        private async Task UpdateCardListControl()
        {
            await memoCore.GetUserCards();
            cardListControl.SetDataSource(ref memoCore.UserCards);
            cardListControl.UpdateGrid();
        }

        private async void UpdateDueCardsControl()
        {
            await memoCore.GetUserDueCards();
            dueCardsControl.SetDataSource(ref memoCore.DueCards);
            dueCardsControl.UpdateGrid();
        }

        internal async Task PushLogsToServer()
        {
            await memoCore.PushLogs();
        }

        private void LoadFont()
        {
            fontCollection = new PrivateFontCollection();
            int fontLength = Properties.Resources.Weber_Hand.Length;
            byte[] fontdata = Properties.Resources.Weber_Hand;
            var data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            fontCollection.AddMemoryFont(data, fontLength);
        }

        internal FontFamily GetCustomFont() => fontCollection.Families[0];
    }
}