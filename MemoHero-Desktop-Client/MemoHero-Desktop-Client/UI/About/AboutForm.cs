using System.Reflection;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.UI.About
{
    internal partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            lblVersion.Text = $"Ver. { Assembly.GetExecutingAssembly().GetName().Version }.";
        }
    }
}
