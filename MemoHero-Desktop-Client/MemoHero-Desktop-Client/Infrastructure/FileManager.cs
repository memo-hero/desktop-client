﻿using System.IO;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.Infrastructure
{
    static internal class FileManager
    {
        private static string filter = "JSON file (*.json) | *.json";

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
    }
}