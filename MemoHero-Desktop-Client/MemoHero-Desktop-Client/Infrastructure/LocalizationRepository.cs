using LiteDB;
using MemoHeroDesktopClient.Domain.Localization;

namespace MemoHeroDesktopClient.Infrastructure.Translation
{
    internal class LocalizationRepository : ILocalizationRepository
    {
        private readonly LiteDatabase database;
        private readonly string tableName = "localization";

        public LocalizationRepository(LiteDatabase database) => this.database = database;

        public LocalizationContent RetrieveLocalization(string locale)
            => database.GetCollection<LocalizationContent>(tableName).FindOne(x => x.id == locale);

        public void StoreLocalization(LocalizationContent content)
            => database.GetCollection<LocalizationContent>(tableName).Upsert(content);

        public bool LocalizationExists(string locale)
         => database.GetCollection<LocalizationContent>(tableName).Exists(x => x.id == locale);
    }
}