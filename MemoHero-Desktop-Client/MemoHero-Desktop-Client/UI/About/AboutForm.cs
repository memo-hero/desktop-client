using MemoHeroDesktopClient.Domain.Localization;
using MemoHeroDesktopClient.Infrastructure;
using MemoHeroDesktopClient.Infrastructure.Translation;
using MemoHeroDesktopClient.Services.Localization;
using System.Reflection;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.UI.About
{
    internal partial class AboutForm : Form
    {
        private static readonly ILocalization localizationService = MemoHeroServices.TranslationService;

        public AboutForm()
        {
            InitializeComponent();
            lblVersion.Text = $"Ver. { Assembly.GetExecutingAssembly().GetName().Version }.";
            localizationService.AddLocalizableControl(new LocalizableControlText(this));
        }
    }
}
