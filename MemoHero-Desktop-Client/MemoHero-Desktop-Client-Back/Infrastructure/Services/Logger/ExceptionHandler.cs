using ClientBack.Domain.Exceptions;
using System;
using System.Threading.Tasks;

namespace ClientBack.Infrastructure.Services.Logger
{
    internal static class ExceptionHandler
    {
        internal static async Task<T> Execute<T>(Func<Task<T>> method)
        {
            try { return await method.Invoke(); }
            catch (Exception ex)
            {
                ClientBackServiceProvider.logger.Log(ex);
                if (ex.Message == "An error occurred while sending the request.")
                    throw new CannotConnectToRemoteService();
            }

            return default;
        }
    }
}
