using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using MemoHeroDesktopClient.Domain;
using MemoHeroDesktopClient.Domain.Localization;
using MemoHeroDesktopClient.Services;
using MemoHeroDesktopClient.Services.ExceptionHandler;
using MemoHeroDesktopClient.Services.Localization;
using MemoHeroDesktopClient.UI.About;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.UI.MainWindow
{
    internal partial class MainMenu : RibbonForm
    {
        private static readonly ILocalization localizationService = MemoHeroServices.TranslationService;
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
                .ForEach(x => localizationService.AddLocalizableControl(new LocalizableControlCaption(x)));

            ribbonControl.Pages.ForEach(page =>
            {
                page.Groups.ForEach(group => localizationService.AddLocalizableControl(new LocalizableControlText(group)));
                localizationService.AddLocalizableControl(new LocalizableControlText(page));
            });

            localizationService.AddLocalizableControl(new LocalizableControlHint(btnAbout));
            localizationService.AddLocalizableControl(new LocalizableControlCaption(barItemLanguage));
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

        private async void btnServerSync_ItemClick(object sender, ItemClickEventArgs e) => await ExceptionHandler.Execute(uiCore.GetCardsFromServer);

        private async void btnDeleteCard_ItemClick(object sender, ItemClickEventArgs e) => await ExceptionHandler.Execute(uiCore.DeleteSelectedCard);

        private void btnExport_ItemClick(object sender, ItemClickEventArgs e) => uiCore.ExportCards();

        private async void btnImport_ItemClick(object sender, ItemClickEventArgs e) => await ExceptionHandler.Execute(uiCore.ImportCards);

        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var about = new AboutForm()) { about.ShowDialog(); };
        }

        private void btnSetLanguageEnglish_ItemClick(object sender, ItemClickEventArgs e)
            => localizationService.SetISOCode(ISOCode.ENGLISH);

        private void btnSetLanguageSpanish_ItemClick(object sender, ItemClickEventArgs e)
            => localizationService.SetISOCode(ISOCode.SPANISH);
    }
}