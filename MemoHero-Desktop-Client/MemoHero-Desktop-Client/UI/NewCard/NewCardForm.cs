using ClientBack.Domain.Cards;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using MemoHeroDesktopClient.CustomControls;
using MemoHeroDesktopClient.Domain.Events;
using MemoHeroDesktopClient.Domain.Localization;
using MemoHeroDesktopClient.Infrastructure;
using MemoHeroDesktopClient.Infrastructure.Translation;
using MemoHeroDesktopClient.Services.Localization;
using System.Linq;

namespace MemoHeroDesktopClient.UI.NewCard
{
    public partial class NewCardForm : XtraForm
    {
        private static readonly ILocalization translationService = MemoHeroServices.TranslationService;
        private readonly CardFormControl cardFormControl = new CardFormControl();

        internal delegate void CreateCardHandler(object source, CreateCardArgs args);
        internal event CreateCardHandler CardCreated;

        public NewCardForm()
        {
            InitializeComponent();
            createPanel.Controls.Add(cardFormControl);
            LoadLocalizableControls();
        }

        protected virtual void OnCardCreated(Card card) => CardCreated(this, new CreateCardArgs(card));

        private void LoadLocalizableControls()
        {
            translationService.AddLocalizableControl(new LocalizableControlText(this));
            Controls.OfType<SimpleButton>()
                .ForEach(x => translationService.AddLocalizableControl(new LocalizableControlText(x)));
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            var result = cardFormControl.GetCard();
            if (result == null) return;
            OnCardCreated(result);
            cardFormControl.ClearForm();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnClearTags_Click(object sender, System.EventArgs e) => cardFormControl.ClearTags();
    }
}