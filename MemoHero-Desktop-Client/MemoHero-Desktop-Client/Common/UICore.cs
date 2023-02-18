using ClientBack.Core;
using ClientBack.Domain.Cards;
using ClientBack.Domain.Exceptions;
using ClientBack.Domain.User;
using ClientBack.Infrastructure.HTTP;
using MemoHeroDesktopClient.CustomControls;
using MemoHeroDesktopClient.Infrastructure;
using MemoHeroDesktopClient.Infrastructure.Translation;
using MemoHeroDesktopClient.Services.ExceptionHandler;
using MemoHeroDesktopClient.UI.EditCard;
using MemoHeroDesktopClient.UI.Login;
using MemoHeroDesktopClient.UI.NewCard;
using MemoHeroDesktopClient.UI.StudyCards;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MemoHeroDesktopClient.Infrastructure.Translation.LocalizationService;

namespace MemoHeroDesktopClient.Common
{
    internal class UICore
    {
        private static readonly LocalizationService localizationService = MemoHeroServices.TranslationService;

        // Forms
        internal readonly LoginSplash login;
        internal UI.MainWindow.MainMenu mainMenuForm;
        internal NewCardForm newCardForm;
        internal EditCardForm editCardForm;
        internal StudyCardsForm studyCardsForm;

        // Events
        internal delegate void UserLoginHandler(object source, UserLoginResultArgs args);
        internal event UserLoginHandler UserLoggedIn;

        internal delegate void StudyResultHandler(object source, StudyResultHandlerArgs args);
        internal event StudyResultHandler StudyResult;

        private readonly MemoHeroCore memoCore = MemoHeroServices.Core;

        // User Data
        private User user;
        
        // Controls
        private Dictionary<string, UserControl> customControls = new Dictionary<string, UserControl>();

        private UserStatsControl userStatsControl;
        private CardListControl dueCardsControl;
        private CardListControl cardListControl;

        internal static LocalizationService LocalizationService => localizationService;

        public UICore()
        {
            login = new LoginSplash(this);
            mainMenuForm = new UI.MainWindow.MainMenu(this);
            LocalizationService.LocalizationChanged += LocalizationService_LocalizationChanged;
        }

        private void LocalizationService_LocalizationChanged(object source, LocalizationChangedEventArgs args)
        {
            cardListControl.UpdateGrid();
            dueCardsControl.UpdateGrid();
            user.Locale = args.ISOCode;
            memoCore.UpdateLocale();
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

        internal async Task ImportCards()
        {
            var content = FileManager.OpenFile();
            await memoCore.ImportCards(content);
            UpdateDueCardsControl();
        }

        internal void ExportCards()
        {
            var cards = memoCore.ExportCards();
            if(cards != null) FileManager.SaveFile(cards);
        }

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

        internal async Task GetCardsFromServer() => await UpdateCardListControl();

        internal void StudyFilteredCards()
        {
            var cards = dueCardsControl.GetCards();
            using (studyCardsForm = new StudyCardsForm(this, ref user, new Queue<Card>(cards), new StudyStatsControl()))
            {
                studyCardsForm.UserResponded += StudyCardsForm_UserResponded;
                studyCardsForm.ShowDialog();
                UpdateDueCardsControl();
            }
        }

        private async void StudyCardsForm_UserResponded(object source, UserResponseArgs args)
        {
            await ExceptionHandlerService.Execute(async () => {
                var result = await memoCore.StudyCard(args.Card, args.Quality);
                user.Stats = result.UserStats;
                userStatsControl.UpdateTableStats(user);
                OnStudyResult(result);
            });
        }

        protected virtual void OnStudyResult(StudyResult result) => StudyResult(this, new StudyResultHandlerArgs(result));

        internal void UpdatePanel(string currentPageName)
        {
            foreach (var control in customControls)
            {
                control.Value.Visible = control.Key == currentPageName;
            }
        }

        internal void ShowNewCardForm()
        {
            newCardForm = new NewCardForm();
            newCardForm.CardCreated += NewCardWindow_CardCreated;
            
            newCardForm.ShowDialog();
        }

        internal void ShowEditCardForm()
        {
            var selectedCard = cardListControl.GetSelectedCard();
            if (selectedCard == null) return;
            
            editCardForm = new EditCardForm(selectedCard);
            editCardForm.CardEdited += EditCardWindow_CardEdited;
            editCardForm.ShowDialog();
        }

        private async void NewCardWindow_CardCreated(object source, CreateCardArgs args)
        {
            var card = await memoCore.CreateCardAsync(args.newCard);
            dueCardsControl.UpdateGrid();
        }

        private async void EditCardWindow_CardEdited(object source, EditCardArgs args)
        {
            if (await memoCore.UpdateCardAsync(args.editedCard))
            {
                cardListControl.UpdateCard(args.editedCard);
                UpdateDueCardsControl();
            };
        }

        internal void Logout()
        {
            ClearState();
            login.loginButton.Enabled = true;
            login.Show();
        }

        private void ClearState()
        {
            user = null;
            customControls.Clear();
            memoCore.Logout();
            mainMenuForm.Dispose();
        }

        internal async void CheckService()
        {
            if (await memoCore.IsServiceOnline()) return;

            MessagesRepository.ShowServiceOffline();
            login.Close();
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

        protected virtual void OnUserLoggedIn(bool failed) => UserLoggedIn(this, new UserLoginResultArgs(failed));

        internal void CloseApplication()
        {
            login.Close();
        }
    }
}
