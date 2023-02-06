using ClientBack.Core;
using ClientBack.Domain.User;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MemoHeroDesktopClient.Common;
using MemoHeroDesktopClient.CustomControls;
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
    public partial class MainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly MemoHeroCore memoCore;
        private readonly UICore uiCore;
        private readonly User user;
        private readonly XtraForm login;

        public MainMenu(XtraForm login, MemoHeroCore memoCore, User user)
        {
            InitializeComponent();
            this.memoCore = memoCore;
            this.user = user;
            this.uiCore = new UICore(ref this.user, mainPanel);
            this.login = login;
        }

        private async void MainMenu_Load(object sender, EventArgs e)
        {
            if (await memoCore.GetUserCards(user.Id))
            {
                var cards = memoCore.UserCards.Select(c => new GridableCard(c)).ToList();
                uiCore.SetCardListControl(memoCore.UserCards);
            }
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
            //var row = gridViewCards.GetRow(gridViewCards.FocusedRowHandle);
            //var selectedCard = gridViewService.GetCardFromGridableCard(row as GridableCard);
            //var newCardWindow = new EditCardWindow(memoCore, ref selectedCard);
            //newCardWindow.Show();
        }

        private void btnCreateCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newCardWindow = new NewCardWindow(memoCore);
            newCardWindow.Show();
        }

        private void ribbonControl_SelectedPageChanged(object sender, EventArgs e)
        {
            var selectedPage = (sender as RibbonControl).SelectedPage.Name;

            uiCore.UpdatePanel(selectedPage);
        }
    }
}