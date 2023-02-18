namespace MemoHeroDesktopClient.Infrastructure.Translation
{
    internal interface ILocalizableControl
    {
        void SetText(string value);
        LocalizedControl GetControlEnum();
    }
}