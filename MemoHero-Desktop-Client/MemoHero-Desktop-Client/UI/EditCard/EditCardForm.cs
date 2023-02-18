using ClientBack.Domain.Cards;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using MemoHeroDesktopClient.Common;
using MemoHeroDesktopClient.CustomControls;
using MemoHeroDesktopClient.Domain.Localization;
using MemoHeroDesktopClient.Infrastructure;
using MemoHeroDesktopClient.Infrastructure.Translation;
using MemoHeroDesktopClient.Services.Localization;
using System;
using System.Linq;

namespace MemoHeroDesktopClient.UI.EditCard
{
    public partial class EditCardForm : XtraForm
    {
        private static readonly ILocalization localizationService = MemoHeroServices.TranslationService;
        private readonly CardFormControl cardFormControl;

        internal delegate void EditCardHandler(object source, EditCardArgs args);
        internal event EditCardHandler CardEdited;

        public EditCardForm(Card card)
        {
            InitializeComponent();
            cardFormControl = new CardFormControl(card);
            editPanel.Controls.Add(cardFormControl);
            LoadLocalizableControls();
        }

        protected virtual void OnCardEdited(Card card) => CardEdited(this, new EditCardArgs(card));

        private void LoadLocalizableControls()
        {
            localizationService.AddLocalizableControl(new LocalizableControlText(this));
            Controls.OfType<SimpleButton>()
                .ForEach(x => localizationService.AddLocalizableControl(new LocalizableControlText(x)));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = cardFormControl.GetCard();
            if (result == null) return;
            OnCardEdited(result);
        }

        private void btnClearDueDate_Click(object sender, EventArgs e)
        {
            var card = cardFormControl.GetCard();
            card.DueDate = DateTimeHelper.DateTimeToEpoch(DateTime.UtcNow);
            cardFormControl.SetCard(card);
        }

        private void btnClearTags_Click(object sender, EventArgs e)
        {
            var card = cardFormControl.GetCard();
            card.Tags.Clear();
            cardFormControl.SetCard(card);
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}