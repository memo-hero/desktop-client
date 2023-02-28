using ClientBack.Domain.Exceptions;
using MemoHeroDesktopClient.Common;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.Services.ExceptionHandler
{
    public static class ExceptionHandler
    {
        public static async Task Execute(Func<Task> method)
        {
            try { await method.Invoke(); }
            catch (CannotConnectToRemoteService)
            {
                MessagesRepository.ShowServiceOffline();
            }
            catch (Exception ex)
            {
                MessagesRepository.ShowUnexpectedError(ex.Message);
            }

            return;
        }

        public static void Execute(Action method)
        {
            try { method.Invoke(); }
            catch (CannotConnectToRemoteService)
            {
                MessagesRepository.ShowServiceOffline();
            }
            catch (Exception ex)
            {
                MessagesRepository.ShowUnexpectedError(ex.Message);
            }

            return;
        }

        public static T Execute<T>(Func<T> method)
        {
            try { return method.Invoke(); }
            catch (Exception)
            {
                MessageBox.Show(
                    "The local database is open.\nPlase close it and re open MemoHero.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            return default;
        }
    }
}
