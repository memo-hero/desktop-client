namespace MemoHeroDesktopClient.Domain.Localization
{
    internal interface ILocalizableControl
    {
        void SetText(string value);
        LocalizedControl GetControlEnum();
    }
}