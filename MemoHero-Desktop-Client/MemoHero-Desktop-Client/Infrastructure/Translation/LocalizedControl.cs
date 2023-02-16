using System.ComponentModel;

namespace MemoHeroDesktopClient.Infrastructure.Translation
{
    internal partial class LocalizationService
    {
        internal enum LocalizedControl
        {
            // Buttons
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

            [Description("btnAbout")]
            BTN_ABOUT,

            [Description("btnReveal")]
            BTN_REVEAL,

            [Description("btnResponse0")]
            BTN_RESPONSE_0,

            [Description("btnResponse1")]
            BTN_RESPONSE_1,

            [Description("btnResponse2")]
            BTN_RESPONSE_2,

            [Description("btnResponse3")]
            BTN_RESPONSE_3,

            [Description("btnResponse4")]
            BTN_RESPONSE_4,

            [Description("btnResponse5")]
            BTN_RESPONSE_5,

            [Description("btnClearTags")]
            BTN_CLEAR_TAGS,

            [Description("btnCreate")]
            BTN_CREATE,

            [Description("btnClose")]
            BTN_CLOSE,

            [Description("btnClearDueDate")]
            BTN_CLEAR_DUE_DATE,

            [Description("btnSave")]
            BTN_SAVE,

            [Description("barItemLanguage")]
            BAR_ITEM_LANGUAGE,

            // Labels
            [Description("lblFront")]
            LBL_FRONT,

            [Description("lblBack")]
            LBL_BACK,

            [Description("lblTags")]
            LBL_TAGS,

            [Description("lblCategory")]
            LBL_CATEGORY,

            [Description("lblDueDate")]
            LBL_DUE_DATE,

            [Description("lblWelcome")]
            LBL_WELCOME,

            [Description("lblCurrentHP")]
            LBL_CURRENT_HP,

            [Description("lblLabelCurrentCategory")]
            LBL_CURRENT_CATEGORY,

            [Description("lblLabelCurrentCategoryLevel")]
            LBL_CURRENT_CATEGORY_LEVEL,

            [Description("lblCategoryProgress")]
            LBL_CATEGORY_PROGRESS,

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

            [Description("pageGroupConfiguration")]
            PAGE_GROUP_CONFIGURATION,

            // Groups
            [Description("groupControl")]
            GROUP_CONTROL,

            [Description("groupStats")]
            GROUP_STATS,

            // Forms
            [Description("StudyCardsForm")]
            FORM_STUDY_CARDS,

            [Description("NewCardForm")]
            FORM_NEW_CARD,

            [Description("EditCardForm")]
            FORM_EDIT_CARD,

            [Description("AboutForm")]
            FORM_ABOUT,
        }
    }
}