using MemoHeroDesktopClient.Domain;
using System;
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

            var uiCore = new UICore();
            uiCore.CheckService();
            uiCore.StartLoginProcess(false);

            Application.Run(uiCore.login);
        }
    }
}
