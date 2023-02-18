using ClientBack.Core;
using ClientBack.Infrastructure.Services;
using MemoHeroDesktopClient.Domain.Localization;
using MemoHeroDesktopClient.Infrastructure.Translation;
using MemoHeroDesktopClient.Services.Localization;

namespace MemoHeroDesktopClient.Infrastructure
{
    static class MemoHeroServices
    {
        internal static MemoHeroCore Core = new MemoHeroCore();
        internal static ILocalization TranslationService = new LocalizationService(
            ClientBackServiceProvider.serializer,
            new LocalizationRepository(ClientBackServiceProvider.LiteDatabase),
            Core.GetLastLocale());
    }
}