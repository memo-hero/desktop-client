using ClientBack.Domain.Cards;
using ClientBack.Infrastructure.HTTP;
using System.Collections.Generic;
using System.Linq;

namespace MemoHeroDesktopClient.Infrastructure.Translation
{
    internal partial class LocalizationService
    {
        private readonly Dictionary<LocalizedControl, ILocalizableControl> localizableControls = new Dictionary<LocalizedControl, ILocalizableControl>();
        private readonly ISerializer serializer;
        private Dictionary<string, string> localizationContent;
        private ISOCode isoCode = ISOCode.ENGLISH;

        public LocalizationService(ISerializer serializer)
        {
            this.serializer = serializer;
            LoadDefaultLanguage();
        }

        internal void AddLocalizableControl(ILocalizableControl control)
        {
            if (IsControlInListAlready(control)) UpdateControlInList(control);
            else AddControlToList(control);

            SetControlContent(control);
        }

        private bool IsControlInListAlready(ILocalizableControl control) => localizableControls.ContainsKey(control.GetControlEnum());

        private void UpdateControlInList(ILocalizableControl control) => localizableControls[control.GetControlEnum()] = control;

        private void AddControlToList(ILocalizableControl control) => localizableControls.Add(control.GetControlEnum(), control);

        private void SetControlContent(ILocalizableControl control) => control.SetText(localizationContent[GetKey(control.GetControlEnum())]);

        internal void LocalizeControls() => localizableControls.ToList().ForEach(x => SetControlContent(x.Value));

        private void LoadDefaultLanguage()
        {
            var content = FileManager.GetDefaultLanguageContent();
            localizationContent = serializer.Deserialize<Dictionary<string, string>>(content);
        }

        internal void SetISOCode(ISOCode isoCode) => this.isoCode = isoCode;

        internal void LoadLanguage(Dictionary<string, string> newContent) => newContent.ToList().ForEach(x => localizationContent.Add(x.Key, x.Value));

        internal string LocalizeMessage(LocalizedMessage message) => localizationContent[GetKey(message)];
        internal string LocalizeCategory(Category message) => localizationContent[GetKey(message)];

        private string GetKey(LocalizedMessage message) => $"{ isoCode }_{ message }";
        private string GetKey(LocalizedControl control) => $"{ isoCode }_{ control }";
        private string GetKey(Category category) => $"{ isoCode }_{ category }";
    }
}