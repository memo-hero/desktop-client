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
        public CardFormControl()
        {
            InitializeComponent();
        }

        private bool TagIsEmpty(string tag) => string.IsNullOrWhiteSpace(tag);
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

        internal Card GetNewCard()
        {
            if (!dxValidationProvider.Validate()) return null;

            _ = Enum.TryParse(listCategories.Text.ToUpper(), out Category category);
            return new Card
            {
                Front = textCardFront.Text,
                Back = textCardBack.Text,
                Category = category,
                Tags = TokensToHashSet(tokenTags.GetTokenList())
            };
        }

        internal void ClearForm()
        {
            textCardFront.Text = string.Empty;
            textCardBack.Text = string.Empty;
        }

        internal void ClearTags() => tokenTags.EditValue = string.Empty;
    }
}
