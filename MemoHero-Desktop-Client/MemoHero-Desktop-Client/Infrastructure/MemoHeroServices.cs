using ClientBack.Core;
using ClientBack.Infrastructure.Services;
using MemoHeroDesktopClient.Infrastructure.Translation;

namespace MemoHeroDesktopClient.Infrastructure
{
    static class MemoHeroServices
    {
        internal static MemoHeroCore Core = new MemoHeroCore();
        internal static LocalizationService TranslationService = new LocalizationService(ClientBackServiceProvider.serializer);
    }
}
