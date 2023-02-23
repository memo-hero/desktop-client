using ClientBack.Domain.Cards;
using MemoHeroDesktopClient.Domain.Events;

namespace MemoHeroDesktopClient.Domain.Localization
{
    internal delegate void LocalizationChangeHandler(object source, LocalizationChangedEventArgs args);

    interface ILocalization
    {
        event LocalizationChangeHandler LocalizationChanged;
        void AddLocalizableControl(ILocalizableControl control);
        void SetISOCode(ISOCode isoCode);
        string LocalizeMessage(LocalizedMessage message);
        string LocalizeCategory(Category message);
    }
}
