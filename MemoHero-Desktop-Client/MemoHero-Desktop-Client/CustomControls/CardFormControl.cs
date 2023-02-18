using ClientBack.Domain.Cards;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using MemoHeroDesktopClient.Common;
using MemoHeroDesktopClient.Domain.Localization;
using MemoHeroDesktopClient.Infrastructure.Translation;
using MemoHeroDesktopClient.Services;
using MemoHeroDesktopClient.Services.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.CustomControls
{
    internal partial class CardFormControl : UserControl
    {
        private static readonly ILocalization localizationService = MemoHeroServices.TranslationService;

        private Card card;
        
        public CardFormControl(Card card = null)
        {
            InitializeComponent();
            this.card = card;
            SetCard(card);
            LoadLocalizableControls();
        }

        private void LoadLocalizableControls()
        {
            Root.Items.ForEach(x =>
            {
                localizationService.AddLocalizableControl(new LocalizableControlText(x));
            });
        }

        private bool TagIsEmpty(string tag) => string.IsNullOrWhiteSpace(tag);

        internal void SetCard(Card card = null)
        {
            if (card == null) card = new Card() { DueDate = DateTimeHelper.DateTimeToEpoch(DateTime.Today) };
            this.card = card;

            textCardFront.Text = card.Front;
            textCardBack.Text = card.Back;
            listCategories.SelectedItem = GetListItemFromCategory(card.Category);
            tokenTags.EditValue = HashSetToTokens(card.Tags);
            dateDueDate.EditValue = DateTimeHelper.EpochToDateTime(card.DueDate);
        }

        private bool TagIsCategory(string tag) => Enum.IsDefined(typeof(Category), tag.ToUpper());
        private bool TagAlreadyExists(string tag)
        {
            return tokenTags.GetTokenList().FirstOrDefault(token => token.Description == tag) != null;
        }

        private void tokenTags_ValidateToken(object sender, TokenEditValidateTokenEventArgs e)
        {
            e.IsValid = !TagIsEmpty(e.Description) && !TagIsCategory(e.Description) && !TagAlreadyExists(e.Description);
        }

        private HashSet<string> TokensToHashSet(TokenEditSelectedItemCollection tokens)
        {
            var tags = new HashSet<string>();
            tokens.ForEach(token => tags.Add(token.Description));
            return tags;
        }

        private string HashSetToTokens(HashSet<string> hashSet) => string.Join(", ", hashSet);

        private object GetListItemFromCategory(Category category)
        {
            foreach (var item in listCategories.Properties.Items)
            {
                if (item.ToString().ToUpper() == category.ToString().ToUpper()) return item;
            }

            return null;
        }

        internal Card GetCard()
        {
            if (!dxValidationProvider.Validate()) return null;

            var category = (Category)listCategories.SelectedIndex;
            //_ = Enum.TryParse(listCategories.Text.ToUpper(), out Category category);

            card.Front = textCardFront.Text;
            card.Back = textCardBack.Text;
            card.Category = category;
            card.Tags = TokensToHashSet(tokenTags.GetTokenList());

            return card;
        }

        internal void ClearForm()
        {
            textCardFront.Text = string.Empty;
            textCardBack.Text = string.Empty;
        }

        internal void ClearTags() => tokenTags.EditValue = string.Empty;
    }
}
