using ClientBack.Core;
using DevExpress.XtraBars.Ribbon;
using MemoHeroDesktopClient.Common;
using MemoHeroDesktopClient.UI.NewCard;
using System;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.UI.MainWindow
{
    internal partial class MainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly MemoHeroCore memoCore;
        private readonly UICore uiCore;

        public MainMenu(UICore uiCore)
        {
            InitializeComponent();
            this.uiCore = uiCore;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            uiCore.InitializeControls();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            uiCore.CloseApplication();
        }

        private void btnLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uiCore.Logout();
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