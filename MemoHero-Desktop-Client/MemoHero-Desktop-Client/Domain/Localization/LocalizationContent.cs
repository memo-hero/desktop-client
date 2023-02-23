using System.Collections.Generic;

namespace MemoHeroDesktopClient.Domain.Localization
{
    internal class LocalizationContent
    {
        public string id { get; set; }
        public Dictionary<string, string> content { get; set; }

        public LocalizationContent(string locale) => id = locale;

        public LocalizationContent() { }
    }
}