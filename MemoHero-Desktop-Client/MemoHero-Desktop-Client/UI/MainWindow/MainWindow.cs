using ClientBack.Core;
using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using DevExpress.XtraEditors;
using MemoHeroDesktopClient.UI.NewCard;
using System;
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

        public MainMenu(XtraForm login, MemoHeroCore memoCore, User user)
        {
            InitializeComponent();
            this.memoCore = memoCore;
            this.user = user;
            this.login = login;
        }

        private async void MainMenu_Load(object sender, EventArgs e)
        {
            if(await memoCore.GetUserCards(user.Id))
            {
                BindingList<Card> list = new BindingList<Card>(memoCore.UserCards);
                gridCards.DataSource = list;
            }

            lblWelcome.Text = $"Welcome { user.Nickname }!";
            picture.LoadAsync(user.Picture);

            gridViewCards.Columns.Remove(gridViewCards.Columns.Where(x => x.CustomizationSearchCaption == "Study Metadata").FirstOrDefault());
            gridViewCards.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());

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

        private void btnNewCard_Click(object sender, EventArgs e)
        {
            var newCardWindow = new NewCardWindow(memoCore);
            newCardWindow.Show();
        }

        private void btnLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            memoCore.Logout();
            Close();
            login.Show();
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
}