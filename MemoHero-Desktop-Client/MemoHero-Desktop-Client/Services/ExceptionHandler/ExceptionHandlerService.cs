using ClientBack.Domain.Exceptions;
using MemoHeroDesktopClient.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoHeroDesktopClient.Services.ExceptionHandler
{
    public static class ExceptionHandlerService
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
    }
}
