using ClientBack.Domain.Cards;
using MemoHeroDesktopClient.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.CustomControls
{
    public partial class CardListControl : UserControl
    {
        private List<Card> cards;
        private List<GridableCard> gridableCards;

        public CardListControl()
        {
            InitializeComponent();
        }

        internal void SetDataSource(ref List<Card> list)
        {
            cards = list;
            gridableCards = list.Select(c => new GridableCard(c)).ToList();
            gridCards.DataSource = new BindingList<GridableCard>(gridableCards);
        }

        internal void AddCard(Card card)
        {
            gridableCards.Add(new GridableCard(card));
            gridCards.RefreshDataSource();
        }

        internal Card GetCardFromGridableCard(GridableCard gridableCard)
        {
            return cards.FirstOrDefault(c => c.Id == gridableCard.Id);
        }
    }
}
