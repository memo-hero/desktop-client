using ClientBack.Core;
using ClientBack.Domain.User;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using MemoHeroDesktopClient.Infrastructure;
using MemoHeroDesktopClient.UI.Login;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoHeroDesktopClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginSplash());
        }
    }
}
