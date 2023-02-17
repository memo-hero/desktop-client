using System.Collections.Generic;

namespace MemoHeroDesktopClient.Infrastructure.Translation
{
    internal class Localization
    {
        public string id { get; set; }
        public Dictionary<string, string> content { get; set; }

        public Localization(string locale) => id = locale;

        public Localization() { }
    }
}