using MemoHeroDesktopClient.Infrastructure;
using MemoHeroDesktopClient.Infrastructure.Translation;
using System.Reflection;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.UI.About
{
    internal partial class AboutForm : Form
    {
        private static readonly LocalizationService localizationService = MemoHeroServices.TranslationService;

        public AboutForm()
        {
            InitializeComponent();
            lblVersion.Text = $"Ver. { Assembly.GetExecutingAssembly().GetName().Version }.";
            localizationService.AddLocalizableControl(new LocalizableControlText(this));
        }
    }
}
