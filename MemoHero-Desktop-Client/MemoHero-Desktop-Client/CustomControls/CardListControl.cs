using ClientBack.Domain.Cards;
using MemoHeroDesktopClient.Common;
using System;
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

        internal void UpdateCard(Card card)
        {
            gridableCards.Remove(gridableCards.Find(x => x.Id == card.Id));
            gridableCards.Add(new GridableCard(card));
            gridCards.RefreshDataSource();
        }

        internal Card GetCardFromGridableCard(GridableCard gridableCard)
        {
            return cards.FirstOrDefault(c => c.Id == gridableCard.Id);
        }

        internal Card GetSelectedCard()
        {
            var selectedRow = gridViewCards.GetRow(gridViewCards.FocusedRowHandle);
            return GetCardFromGridableCard(selectedRow as GridableCard);
        }
    }
}
