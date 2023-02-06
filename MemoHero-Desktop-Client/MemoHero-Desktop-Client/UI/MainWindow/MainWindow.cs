using ClientBack.Core;
using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MemoHeroDesktopClient.UI.EditCard;
using MemoHeroDesktopClient.UI.NewCard;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.UI.MainWindow
{
    public partial class MainMenu : DevExpress.XtraEditors.XtraForm
    {
        private readonly MemoHeroCore memoCore;
        private readonly User user;
        private readonly XtraForm login;
        private GridViewService gridViewService;

        public MainMenu(XtraForm login, MemoHeroCore memoCore, User user)
        {
            InitializeComponent();
            this.memoCore = memoCore;
            this.user = user;
            this.login = login;
        }

        private async void MainMenu_Load(object sender, EventArgs e)
        {
            gridViewService = new GridViewService(gridCards);
            if (await memoCore.GetUserCards(user.Id))
            {
                var cards = memoCore.UserCards.Select(c => new GridableCard(c)).ToList();
                gridViewService.SetDataSource(memoCore.UserCards);
            }

            lblWelcome.Text = $"Welcome { user.Nickname }!";
            //lblDueCardsCount.Text = $"You have cards { "test" } due";

            UpdateStats();
        }

        private void UpdateStats()
        {
            lblArts.Text = "Arts";
            lblArtsLevel.Text = "LVL: " + user.Stats.Categories[Category.ARTS].Level.ToString();
            expArts.EditValue = ControlRepository.GetExpPercentValue(user, Category.ARTS);

            lblComputers.Text = "Computers";
            lblComputersLevel.Text = "LVL: " + user.Stats.Categories[Category.COMPUTERS].Level.ToString();
            expComputers.EditValue = ControlRepository.GetExpPercentValue(user, Category.COMPUTERS);

            lblHistory.Text = "History";
            lblHistoryLevel.Text = "LVL: " + user.Stats.Categories[Category.HISTORY].Level.ToString();
            expHistory.EditValue = ControlRepository.GetExpPercentValue(user, Category.HISTORY);

            lblLanguages.Text = "Languages";
            lblLanguagesLevel.Text = "LVL: " + user.Stats.Categories[Category.LANGUAGES].Level.ToString();
            expLanguages.EditValue = ControlRepository.GetExpPercentValue(user, Category.LANGUAGES);

            lblScience.Text = "Science";
            lblScienceLevel.Text = "LVL: " + user.Stats.Categories[Category.SCIENCE].Level.ToString();
            expScience.EditValue = ControlRepository.GetExpPercentValue(user, Category.SCIENCE);
        }

        private void cardBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Hide();
        }

        private void btnLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            memoCore.Logout();
            Close();
        }

        private void btnCardEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = gridViewCards.GetRow(gridViewCards.FocusedRowHandle);
            var selectedCard = gridViewService.GetCardFromGridableCard(row as GridableCard);
            var newCardWindow = new EditCardWindow(memoCore, ref selectedCard);
            newCardWindow.Show();
        }

        private void gridCards_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnCreateCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newCardWindow = new NewCardWindow(memoCore);
            newCardWindow.Show();
        }
    }

    class ControlRepository
    {
        internal static int GetExpPercentValue(User user, Category category)
        {
            var currentExp = user.Stats.Categories[category].Exp;
            var neededExp = user.Stats.Categories[category].Needed;

            if (neededExp == 0) return 0;

            return (currentExp * 100 / neededExp);
        }
    }

    class GridViewService
    {
        private readonly GridControl gridViewCards;
        private List<Card> cards;
        private List<GridableCard> gridableCards;

        public GridViewService(GridControl gridViewCards)
        {
            this.gridViewCards = gridViewCards;
        }

        internal void SetDataSource(List<Card> list)
        {
            cards = list;
            gridableCards = list.Select(c => new GridableCard(c)).ToList();
            gridViewCards.DataSource = new BindingList<GridableCard>(gridableCards);
        }

        internal Card GetCardFromGridableCard(GridableCard gridableCard)
        {
            return cards.FirstOrDefault(c => c.Id == gridableCard.Id);
        }
    }

    class GridableCard
    {
        public string Id { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
        public string Tags { get; set; }
        public DateTime DueDate { get; set; }

        public GridableCard(Card card)
        {
            Id = card.Id;
            Front = card.Front;
            Back = card.Back;
            Tags = string.Join(", ", card.Tags);
            DueDate = UnixTimeStampToDateTime(card.DueDate);
        }

        private static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddDays(unixTimeStamp).ToLocalTime();
            return dateTime;
        }
    }
}