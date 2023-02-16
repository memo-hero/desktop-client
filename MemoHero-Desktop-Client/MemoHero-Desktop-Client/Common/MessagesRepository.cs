using ClientBack.Infrastructure.HTTP;
using MemoHeroDesktopClient.Infrastructure;
using MemoHeroDesktopClient.Infrastructure.Translation;
using System.Linq;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.Common
{
    internal static class MessagesRepository
    {
        private static readonly LocalizationService localization = MemoHeroServices.TranslationService;

        internal static void ShowServiceOffline() => MessageBox.Show(
            GetText(LocalizedMessage.NO_SERVICE_MESSAGE),
            GetText(LocalizedMessage.NO_SERVICE_CAPTION),
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        );

        internal static void ShowHPLeftMessage() => MessageBox.Show(
            GetText(LocalizedMessage.NO_SERVICE_MESSAGE),
            GetText(LocalizedMessage.NO_SERVICE_CAPTION),
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        );
        

        internal static void ShowLevelUpMessage(StudyResult studyresult)
        {
            var categoryEnum = studyresult.Category.Keys.First();
            var category = localization.LocalizeCategory(categoryEnum);
            var newLevel = studyresult.Category[categoryEnum].Level.ToString();
            var message = GetText(LocalizedMessage.LEVEL_UP_MESSAGE);
            var caption = GetText(LocalizedMessage.LEVEL_UP_CAPTION);

            message = string.Format(message, category, newLevel);

            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static DialogResult ShowDeleteCardConfirmation() => MessageBox.Show(
            GetText(LocalizedMessage.CONFIRM_CARD_DELETION_MESSAGE),
            GetText(LocalizedMessage.CONFIRM_CARD_DELETION_CAPTION),
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning
        );

        private static string GetText(LocalizedMessage message) => localization.LocalizeMessage(message);
    }
}
