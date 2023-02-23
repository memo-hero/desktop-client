using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace MemoHeroDesktopClient.Services.FileManagement
{
    static internal class FileManager
    {
        private static readonly string filter = "JSON file (*.json) | *.json";


        internal static string GetDefaultLanguageContent(string locale)
        {
            var fileContent = Properties.Resources.ResourceManager.GetObject(locale.ToUpper());
            return new StreamReader(new MemoryStream((byte[])fileContent), Encoding.GetEncoding(65000)).ReadToEnd();
        }

        internal static string OpenFile()
        {
            // Due to multithreading issues, the auth0 client needs to run as single threaded
            var tcs = new TaskCompletionSource<string>();
            var thread = new Thread(delegate ()
            {
                var dispatcher = Dispatcher.CurrentDispatcher;
                dispatcher.InvokeAsync(delegate
                {
                    var fileContent = string.Empty;

                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Filter = filter;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var fileStream = openFileDialog.OpenFile();
                            using (StreamReader reader = new StreamReader(fileStream))
                                fileContent = reader.ReadToEnd();
                        }
                    }

                    tcs.SetResult(fileContent);
                    dispatcher.BeginInvokeShutdown(DispatcherPriority.Normal);
                });

                Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            return tcs.Task.Result;
        }

        internal static void SaveFile(string content)
        {
            // Due to multithreading issues, the auth0 client needs to run as single threaded
            var thread = new Thread(delegate ()
            {
                var dispatcher = Dispatcher.CurrentDispatcher;
                dispatcher.InvokeAsync(delegate
                {
                    var saveFileDialog = new SaveFileDialog() { Filter = filter };
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        File.WriteAllText(saveFileDialog.FileName, content);

                    dispatcher.BeginInvokeShutdown(DispatcherPriority.Normal);
                });

                Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
