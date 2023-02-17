using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.Infrastructure
{
    static internal class FileManager
    {
        private static readonly string filter = "JSON file (*.json) | *.json";

        internal static void SaveFile(string content)
        {
            var saveFileDialog = new SaveFileDialog() { Filter = filter };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog.FileName, content);
        }

        internal static string OpenFile()
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

            return fileContent;
        }

        internal static string GetDefaultLanguageContent(string locale)
        {
            //if (locale == "EN")
            //    return new StreamReader(new MemoryStream(Properties.Resources.EN), Encoding.GetEncoding(65000)).ReadToEnd();

            var fileContent = Properties.Resources.ResourceManager.GetObject(locale.ToUpper());
            return new StreamReader(new MemoryStream((byte[])fileContent), Encoding.GetEncoding(65000)).ReadToEnd();
        }
    }
}
