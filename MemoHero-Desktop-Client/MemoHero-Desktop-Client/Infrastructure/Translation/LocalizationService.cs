using ClientBack.Domain.Cards;
using ClientBack.Infrastructure.HTTP;
using DevExpress.Utils.Extensions;
using MemoHeroDesktopClient.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoHeroDesktopClient.Infrastructure.Translation
{
    internal partial class LocalizationService
    {
        private readonly Dictionary<LocalizedControl, ILocalizableControl> localizableControls = new Dictionary<LocalizedControl, ILocalizableControl>();
        private readonly ISerializer serializer;
        private readonly ILocalizationRepository repository;
        private Dictionary<string, string> localizationContent = new Dictionary<string, string>();
        private ISOCode isoCode = ISOCode.ENGLISH;

        internal delegate void LocalizationChangeHandler(object source, LocalizationChangedEventArgs args);
        internal event LocalizationChangeHandler LocalizationChanged;

        public LocalizationService(ISerializer serializer, ILocalizationRepository repository, string locale)
        {
            this.serializer = serializer;
            this.repository = repository;
            StoreDefaultLocalization("EN", "ES");
            LoadLocalization(locale);
        }

        internal class LocalizationChangedEventArgs : EventArgs
        {
            internal string ISOCode;
            public LocalizationChangedEventArgs(ISOCode isoCode) => ISOCode = Extensions.GetDescription(isoCode);
        }

        private void StoreDefaultLocalization(params string[] locales)
        {
            locales.ForEach(locale =>
            {
                if (!repository.LocalizationExists(locale))
                {
                    var content = serializer.Deserialize<Dictionary<string, string>>(FileManager.GetDefaultLanguageContent(locale));
                    repository.StoreLocalization(new Localization(locale) { content = content });
                }
            });
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

        private void LoadLocalization(string locale)
        {
            isoCode = Extensions.GetValueFromDescription<ISOCode>(locale.ToUpper());
            var localization = repository.RetrieveLocalization(locale.ToUpper());
            if (localization == null) repository.RetrieveLocalization(locale.ToUpper());
            else localizationContent = localization.content;
        }

        internal void SetISOCode(ISOCode isoCode)
        {
            if (this.isoCode == isoCode) return;
            this.isoCode = isoCode;
            LoadLocalization(Extensions.GetDescription(isoCode));
            LocalizeControls();
            OnLocalizationChanged(isoCode);
        }

        internal virtual void OnLocalizationChanged(ISOCode isoCode) => LocalizationChanged(this, new LocalizationChangedEventArgs(isoCode));

        internal void LoadLanguage(Dictionary<string, string> newContent) => newContent.ToList().ForEach(x => localizationContent.Add(x.Key, x.Value));

        internal string LocalizeMessage(LocalizedMessage message) => localizationContent[GetKey(message)];
        internal string LocalizeCategory(Category message) => localizationContent[GetKey(message)];

        private string GetKey(LocalizedMessage message) => $"{ isoCode }_{ message }";
        private string GetKey(LocalizedControl control) => $"{ isoCode }_{ control }";
        private string GetKey(Category category) => $"{ isoCode }_{ category }";
    }
}