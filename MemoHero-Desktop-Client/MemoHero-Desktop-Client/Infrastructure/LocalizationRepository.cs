using LiteDB;

namespace MemoHeroDesktopClient.Infrastructure.Translation
{
    internal class LocalizationRepository : ILocalizationRepository
    {
        private readonly LiteDatabase database;
        private readonly string tableName = "localization";

        public LocalizationRepository(LiteDatabase database) => this.database = database;

        public Localization RetrieveLocalization(string locale)
            => database.GetCollection<Localization>(tableName).FindOne(x => x.id == locale);

        public void StoreLocalization(Localization content)
            => database.GetCollection<Localization>(tableName).Upsert(content);

        public bool LocalizationExists(string locale)
         => database.GetCollection<Localization>(tableName).Exists(x => x.id == locale);
    }
}