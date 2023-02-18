using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using MemoHeroDesktopClient.Common;
using MemoHeroDesktopClient.CustomControls;
using MemoHeroDesktopClient.Domain;
using MemoHeroDesktopClient.Domain.Events;
using MemoHeroDesktopClient.Domain.Localization;
using MemoHeroDesktopClient.Infrastructure.Translation;
using MemoHeroDesktopClient.Services;
using MemoHeroDesktopClient.Services.Localization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MemoHeroDesktopClient.UI.StudyCards
{
    internal partial class StudyCardsForm : XtraForm
    {
        internal delegate void UserResponseHandler(object source, UserResponseArgs args);
        internal event UserResponseHandler UserResponded;

        private static readonly ILocalization localization = MemoHeroServices.TranslationService;
        private readonly StudyStatsControl studyStatsControl;
        private readonly User user;
        private readonly Queue<Card> cards;
        private Card currentCard;

        public StudyCardsForm(UICore uiCore, ref User user, Queue<Card> cards, StudyStatsControl studyStatsControl)
        {
            InitializeComponent();
            this.user = user;
            this.cards = cards;
            this.studyStatsControl = studyStatsControl;
            InitializeLabel();
            ShowNextCard();
            InitializeStatsPanel();
            LoadLocalizableControls();

            uiCore.StudyResult += UiCore_StudyResult;
        }

        private void UiCore_StudyResult(object source, StudyResultHandlerArgs args)
        {
            UpdateStatsPanel();
            if (args.studyResult.DidGetKnockedOut) MessagesRepository.ShowHPLeftMessage();
            if (args.studyResult.DidLevelUp) MessagesRepository.ShowLevelUpMessage(args.studyResult);
        }

        private void InitializeLabel()
        {
            lblCardFront.Parent = pictureCard;
            lblCardFront.Location = new System.Drawing.Point(10, 50);
            lblCardFront.BackColor = Color.Transparent;

            lblCardBack.Parent = pictureCard;
            lblCardBack.Location = new System.Drawing.Point(10,170);
            lblCardBack.BackColor = Color.Transparent;
        }

        private void InitializeStatsPanel()
        {
            panelStats.Controls.Add(studyStatsControl);
            UpdateStatsPanel();
        }

        private void UpdateStatsPanel() => studyStatsControl.UpdateStats(user.Stats, currentCard.Category);

        private void LoadLocalizableControls()
        {
            localization.AddLocalizableControl(new LocalizableControlText(this));
            localization.AddLocalizableControl(new LocalizableControlText(groupControl));
            localization.AddLocalizableControl(new LocalizableControlText(groupStats));
            groupControl.Controls
                .OfType<SimpleButton>()
                .ForEach(x => localization.AddLocalizableControl(new LocalizableControlText(x)));
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