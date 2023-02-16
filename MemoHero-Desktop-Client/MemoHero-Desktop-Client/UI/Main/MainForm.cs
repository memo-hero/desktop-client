using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using MemoHeroDesktopClient.Common;
using MemoHeroDesktopClient.Infrastructure;
using MemoHeroDesktopClient.Infrastructure.Translation;
using MemoHeroDesktopClient.UI.About;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.UI.MainWindow
{
    internal partial class MainMenu : RibbonForm
    {
        private static readonly LocalizationService translationService = MemoHeroServices.TranslationService;
        private readonly UICore uiCore;

        public MainMenu(UICore uiCore)
        {
            InitializeComponent();
            this.uiCore = uiCore;
            LoadLocalizableControls();
        }

        private void LoadLocalizableControls()
        {
            ribbonControl.Manager.Items
                .Where(x => x.Tag != null && (bool)x.Tag == true)
                .ToList()
                .ForEach(x => translationService.AddLocalizableControl(new LocalizableControlCaption(x)));

            ribbonControl.Pages.ForEach(page =>
            {
                page.Groups.ForEach(group => translationService.AddLocalizableControl(new LocalizableControlText(group)));
                translationService.AddLocalizableControl(new LocalizableControlText(page));
            });

            translationService.AddLocalizableControl(new LocalizableControlHint(btnAbout));
            translationService.AddLocalizableControl(new LocalizableControlCaption(barItemLanguage));
        }

        private void MainMenu_Load(object sender, EventArgs e) => uiCore.InitializeControls();

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e) => uiCore.CloseApplication();

        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e) => uiCore.Logout();

        private void btnCardEdit_ItemClick(object sender, ItemClickEventArgs e) => uiCore.ShowEditCardForm();

        private void btnCreateCard_ItemClick(object sender, ItemClickEventArgs e) => uiCore.ShowNewCardForm();

        private void ribbonControl_SelectedPageChanged(object sender, EventArgs e)
        {
            var selectedPage = (sender as RibbonControl).SelectedPage.Name;

            uiCore.UpdatePanel(selectedPage);
        }

        private void btnStudy_ItemClick(object sender, ItemClickEventArgs e) => uiCore.StudyFilteredCards();

        private void btnServerSync_ItemClick(object sender, ItemClickEventArgs e) => uiCore.GetCardsFromServer();

        private void btnDeleteCard_ItemClick(object sender, ItemClickEventArgs e) => uiCore.DeleteSelectedCard();

        private void btnExport_ItemClick(object sender, ItemClickEventArgs e) => uiCore.ExportCards();

        private void btnImport_ItemClick(object sender, ItemClickEventArgs e) => uiCore.ImportCards();

        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var about = new AboutForm()) { about.ShowDialog(); };
        }
    }
}