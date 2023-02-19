using System;
using System.Threading.Tasks;

namespace ClientBack.Infrastructure.Services
{
    internal static class ExceptionHandler
    {
        internal static async Task<T> Execute<T>(Func<Task<T>> method)
        {
            try { return await method.Invoke(); }
            catch (Exception ex)
            {
                ClientBackServiceProvider.logger.Log(ex);
            }

            return default;
        }
    }
}
