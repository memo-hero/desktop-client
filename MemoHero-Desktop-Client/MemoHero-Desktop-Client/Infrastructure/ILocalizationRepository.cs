namespace MemoHeroDesktopClient.Infrastructure.Translation
{
    internal interface ILocalizationRepository
    {
        void StoreLocalization(Localization content);

        Localization RetrieveLocalization(string locale);

        bool LocalizationExists(string locale);
    }
}