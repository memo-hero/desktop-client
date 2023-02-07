using ClientBack.Domain.Cards;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.CustomControls
{
    internal partial class CardFormControl : UserControl
    {
        private Card card;
        
        public CardFormControl(Card card = null)
        {
            InitializeComponent();
            this.card = card;
            SetCard();
        }

        private bool TagIsEmpty(string tag) => string.IsNullOrWhiteSpace(tag);

        private void SetCard()
        {
            if (card == null) card = new Card();

            textCardFront.Text = card.Front;
            textCardBack.Text = card.Back;
            listCategories.SelectedItem = GetListItemFromCategory(card.Category);
            tokenTags.EditValue = HashSetToTokens(card.Tags);
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

            _ = Enum.TryParse(listCategories.Text.ToUpper(), out Category category);

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
