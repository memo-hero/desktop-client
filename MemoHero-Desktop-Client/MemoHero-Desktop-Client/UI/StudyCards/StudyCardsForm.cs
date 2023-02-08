using ClientBack.Domain.Cards;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.UI.StudyCards
{
    public partial class StudyCardsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly Queue<Card> cards;
        private Card currentCard;
        public StudyCardsForm(Queue<Card> cards)
        {
            InitializeComponent();
            this.cards = cards;
            currentCard = cards.Dequeue();
            InitializeLabel();
        }

        private void InitializeLabel()
        {
            lblCardText.Parent = pictureCard;
            lblCardText.Location = new Point(10, 50);
            lblCardText.BackColor = Color.Transparent;
            lblCardText.Text = currentCard.Front;

            lblCardBack.Parent = pictureCard;
            lblCardBack.Location = new Point(10,170);
            lblCardBack.BackColor = Color.Transparent;
            lblCardBack.Text = currentCard.Back;
        }
    }
}