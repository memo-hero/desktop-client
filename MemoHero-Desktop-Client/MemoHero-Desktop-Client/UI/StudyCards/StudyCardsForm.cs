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
            InitializeLabel();
            ShowNextCard();
        }

        private void InitializeLabel()
        {
            lblCardFront.Parent = pictureCard;
            lblCardFront.Location = new Point(10, 50);
            lblCardFront.BackColor = Color.Transparent;

            lblCardBack.Parent = pictureCard;
            lblCardBack.Location = new Point(10,170);
            lblCardBack.BackColor = Color.Transparent;
        }

        private void btnReveal_Click(object sender, EventArgs e)
        {
            lblCardBack.Visible = !lblCardBack.Visible;
            ToggleResponseButtons(lblCardBack.Visible);
        }

        private void ShowNextCard()
        {
            if (cards.Count == 0)
            {
                EndOfSession();
                return;
            }

            currentCard = cards.Dequeue();
            lblCardFront.Text = currentCard.Front;
            lblCardBack.Text = currentCard.Back;
            lblCardBack.Visible = false;
            ToggleResponseButtons(lblCardBack.Visible);
        }

        protected virtual void OnUserResponse(int quality) => UserResponded(this, new UserResponseArgs(currentCard, quality));
        
        protected virtual void Response(int quality)
        {
            OnUserResponse(quality);
            ShowNextCard();
        }

        private void EndOfSession()
        {
            lblCardFront.Visible = false;
            lblCardBack.Visible = false;
            lblCardFront.Text = string.Empty;
            lblCardBack.Text = string.Empty;

            btnReveal.Enabled = false;
            ToggleResponseButtons(false);
        }

        private void ToggleResponseButtons(bool state)
        {
            btnResponse0.Enabled = state;
            btnResponse1.Enabled = state;
            btnResponse2.Enabled = state;
            btnResponse3.Enabled = state;
            btnResponse4.Enabled = state;
            btnResponse5.Enabled = state;
        }

        private void btnResponse0_Click(object sender, EventArgs e) => Response(0);
        private void btnResponse1_Click(object sender, EventArgs e) => Response(1);
        private void btnResponse2_Click(object sender, EventArgs e) => Response(2);
        private void btnResponse3_Click(object sender, EventArgs e) => Response(3);
        private void btnResponse4_Click(object sender, EventArgs e) => Response(4);
        private void btnResponse5_Click(object sender, EventArgs e) => Response(5);
    }
}