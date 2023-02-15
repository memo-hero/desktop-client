namespace MemoHeroDesktopClient.Infrastructure.Translation
{
    internal interface ILocalizableControl
    {
        void SetText(string value);
        TranslationService.Control GetControlEnum();
    }
}