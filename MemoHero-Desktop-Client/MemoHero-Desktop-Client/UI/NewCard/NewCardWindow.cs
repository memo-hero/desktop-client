using ClientBack.Core;
using ClientBack.Domain.Cards;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using MemoHeroDesktopClient.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoHeroDesktopClient.UI.NewCard
{
    public partial class NewCardWindow : DevExpress.XtraEditors.XtraForm
    {
        internal delegate void CreateCardHandler(object source, CreateCardArgs args);
        internal event CreateCardHandler CardCreated;

        public NewCardWindow()
        {
            InitializeComponent();
        }

        private void tokenTags_ValidateToken(object sender, TokenEditValidateTokenEventArgs e)
        {
            e.IsValid = !TagIsEmpty(e.Description) && !TagIsCategory(e.Description) && !TagAlreadyExists(e.Description);
        }

        private bool TagIsEmpty(string tag) => string.IsNullOrWhiteSpace(tag);
        private bool TagIsCategory(string tag) => Enum.IsDefined(typeof(Category), tag.ToUpper());
        private bool TagAlreadyExists(string tag)
        {
            return tokenTags.GetTokenList().FirstOrDefault(token => token.Description == tag) != null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _ = Enum.TryParse(listCategories.Text.ToUpper(), out Category category);
            var newCard = new Card
            {
                Front = textCardFront.Text,
                Back = textCardBack.Text,
                Category = category,
                Tags = TokensToHashSet(tokenTags.GetTokenList())
            };

            OnCardCreated(newCard);
        }

        private HashSet<string> TokensToHashSet(TokenEditSelectedItemCollection tokens)
        {
            var tags = new HashSet<string>();
            tokens.ForEach(token => tags.Add(token.Description));
            return tags;
        }

        protected virtual void OnCardCreated(Card card) => CardCreated(this, new CreateCardArgs(card));
    }
}