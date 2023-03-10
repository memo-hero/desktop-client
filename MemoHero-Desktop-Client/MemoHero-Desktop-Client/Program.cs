using ClientBack.Core;
using ClientBack.Infrastructure.Services;
using MemoHeroDesktopClient.Common;
using MemoHeroDesktopClient.Domain;
using MemoHeroDesktopClient.Services.ExceptionHandler;
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
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                UICore uiCore = null;
                if (!ExceptionHandler.Execute(MemoHeroCore.IsLocalDbAvailable)) return;
                if (await ExceptionHandler.Execute(MemoHeroCore.IsServiceOnline))
                {
                    uiCore = new UICore();
                    uiCore.StartLoginProcess(false);
                    Application.Run(uiCore.login);
                }
                else MessagesRepository.ShowServiceOffline();

                if (uiCore != null)
                    await uiCore.PushLogsToServer();
            }
            catch (Exception ex)
            {
                MessagesRepository.ShowUnexpectedError(ex.Message);
                ClientBackServiceProvider.logger.Log(ex);
            }
        }
    }
}
