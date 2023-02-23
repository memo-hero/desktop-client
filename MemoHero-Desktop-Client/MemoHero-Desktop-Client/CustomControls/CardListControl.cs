using ClientBack.Domain.Cards;
using DevExpress.XtraGrid.Views.Base;
using MemoHeroDesktopClient.Domain.Cards;
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
            gridViewCards.Columns[0].Visible = false;
            gridViewCards.Columns[1].Width = 160;
            gridViewCards.Columns[2].Visible = false;
            gridViewCards.Columns[3].Width = 50;
            gridViewCards.Columns[4].Width = 50;
            gridViewCards.Columns[5].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gridViewCards.Columns[5].Width = 50;
        }

        internal void AddCard(Card card)
        {
            gridableCards.Add(new GridableCard(card));
            gridCards.RefreshDataSource();
        }

        internal void UpdateGrid()
        {
            gridableCards.Clear();
            gridableCards.AddRange(cards.Select(c => new GridableCard(c)).ToList());
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

        internal List<Card> GetCards()
        {
            var view = gridCards.MainView as ColumnView;
            var filteredCards = new List<GridableCard>();
            for (int i = 0; i < view.DataRowCount; i++)
                filteredCards.Add(view.GetRow(i) as GridableCard);

            return filteredCards.Select(x => GetCardFromGridableCard(x)).ToList();
        }
    }
}
