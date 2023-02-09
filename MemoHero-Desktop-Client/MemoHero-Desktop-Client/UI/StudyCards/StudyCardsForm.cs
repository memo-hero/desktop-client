using ClientBack.Domain.Cards;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.UI.StudyCards
{
    public partial class StudyCardsForm : DevExpress.XtraEditors.XtraForm
    {
        internal delegate void UserResponseHandler(object source, UserResponseArgs args);
        internal event UserResponseHandler UserResponded;

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

            lblCardBack.Visible = false;
            lblCardBack.Parent = pictureCard;
            lblCardBack.Location = new Point(10,170);
            lblCardBack.BackColor = Color.Transparent;
            lblCardBack.Text = currentCard.Back;
        }

        private void btnReveal_Click(object sender, EventArgs e)
        {
            lblCardBack.Visible = !lblCardBack.Visible;
        }

        protected virtual void OnUserResponse(int quality) => UserResponded(this, new UserResponseArgs(currentCard, quality));

        private void btnResponse3_Click(object sender, EventArgs e) => OnUserResponse(3);
    }

    internal class UserResponseArgs: EventArgs
    {
        internal Card Card;
        internal int Quality;

        public UserResponseArgs(Card card, int quality)
        {
            Card = card;
            Quality = quality;
        }
    }
}