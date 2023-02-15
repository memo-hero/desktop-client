using ClientBack.Infrastructure.HTTP;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace MemoHeroDesktopClient.Infrastructure.Translation
{
    internal partial class TranslationService
    {
        private readonly List<ILocalizableControl> localizableControls = new List<ILocalizableControl>();
        private readonly ISerializer serializer;
        private Dictionary<string, string> localizationContent;
        private ISOCode isoCode = ISOCode.ENGLISH;

        public TranslationService(ISerializer serializer)
        {
            this.serializer = serializer;
            LoadDefaultLanguage();
        }

        internal void AddLocalizableControl(ILocalizableControl localizableControl) => localizableControls.Add(localizableControl);

        private void LoadDefaultLanguage()
        {
            var content = FileManager.GetDefaultLanguageContent();
            localizationContent = serializer.Deserialize<Dictionary<string, string>>(content);
        }

        internal void SetISOCode(ISOCode isoCode) => this.isoCode = isoCode;

        internal void LoadLanguage(Dictionary<string, string> newContent) => newContent.ToList().ForEach(x => localizationContent.Add(x.Key, x.Value));

        internal string LocalizeMessage(Message message) => localizationContent[GetKey(message)];

        internal void LocalizeControls()
        {
            localizableControls.ForEach(x => x.SetText(localizationContent[GetKey(x.GetControlEnum())]));
        }

        private string GetKey(Message message) => $"{ isoCode }_{ message }";
        private string GetKey(Control message) => $"{ isoCode }_{ message }";

        internal enum Message
        {
            NO_SERVICE_MESSAGE,
            NO_SERVICE_CAPTION
        }

        internal enum Control
        {
            // Ribbon Buttons
            [Description("btnLogOut")]
            BTN_LOGOUT,

            [Description("btnStudy")]
            BTN_STUDY,

            [Description("btnServerSync")]
            BTN_SERVER_SYNC,

            [Description("btnCreateCard")]
            BTN_CREATE_CARD,

            [Description("btnCardEdit")]
            BTN_CARD_EDIT,

            [Description("btnDeleteCard")]
            BTN_DELETE_CARD,

            [Description("btnImport")]
            BTN_IMPORT,

            [Description("btnExport")]
            BTN_EXPORT,

            // Ribbon Pages
            [Description("pageUserStatus")]
            PAGE_USER_STATUS,

            [Description("pageStudy")]
            PAGE_STUDY,

            [Description("pageCards")]
            PAGE_CARDS,

            //  Ribbon Page Groups
            [Description("pageGroupUser")]
            PAGE_GROUP_USER,

            [Description("pageGroupStudy")]
            PAGE_GROUP_STUDY,

            [Description("pageGroupServer")]
            PAGE_GROUP_SERVER,

            [Description("pageGroupCards")]
            PAGE_GROUP_CARDS,

            [Description("pageGroupBackup")]
            PAGE_GROUP_BACKUP,
        }
    }
}