using ClientBack.Core;
using MemoHeroDesktopClient.Common;
using MemoHeroDesktopClient.Domain;
using MemoHeroDesktopClient.Services;
using MemoHeroDesktopClient.Services.ExceptionHandler;
using System;
using System.IO;
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
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!ExceptionHandler.Execute(MemoHeroCore.IsLocalDbAvailable)) return;
            if (await ExceptionHandler.Execute(MemoHeroCore.IsServiceOnline))
            {
                var uiCore = new UICore();
                uiCore.StartLoginProcess(false);
                Application.Run(uiCore.login);
            }
            else MessagesRepository.ShowServiceOffline();
        }
    }
}
