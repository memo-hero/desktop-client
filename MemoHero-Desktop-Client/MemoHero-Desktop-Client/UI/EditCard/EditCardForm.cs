﻿using ClientBack.Domain.Cards;
using MemoHeroDesktopClient.Common;
using MemoHeroDesktopClient.CustomControls;
using System;

namespace MemoHeroDesktopClient.UI.EditCard
{
    public partial class EditCardForm : DevExpress.XtraEditors.XtraForm
    {
        internal delegate void EditCardHandler(object source, EditCardArgs args);
        internal event EditCardHandler CardEdited;
        private readonly CardFormControl cardFormControl;

        public EditCardForm(Card card)
        {
            InitializeComponent();
            cardFormControl = new CardFormControl(card);
            editPanel.Controls.Add(cardFormControl);
        }

        protected virtual void OnCardEdited(Card card) => CardEdited(this, new EditCardArgs(card));

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = cardFormControl.GetCard();
            if (result == null) return;
            OnCardEdited(result);
        }

        private void btnClearDueDate_Click(object sender, EventArgs e)
        {
            var card = cardFormControl.GetCard();
            card.DueDate = DateTimeHelper.DateTimeToEpoch(DateTime.UtcNow);
            cardFormControl.SetCard(card);
        }

        private void btnClearTags_Click(object sender, EventArgs e)
        {
            var card = cardFormControl.GetCard();
            card.Tags.Clear();
            cardFormControl.SetCard(card);
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}