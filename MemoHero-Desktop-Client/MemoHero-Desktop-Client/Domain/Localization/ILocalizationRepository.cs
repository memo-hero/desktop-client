namespace MemoHeroDesktopClient.Domain.Localization
{
    internal interface ILocalizationRepository
    {
        void StoreLocalization(LocalizationContent content);

        LocalizationContent RetrieveLocalization(string locale);

        bool LocalizationExists(string locale);
    }
}