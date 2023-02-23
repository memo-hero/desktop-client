using ClientBack.Domain.Cards;
using System;

namespace MemoHeroDesktopClient.UI.EditCard
{
    internal class EditCardArgs : EventArgs
    {
        internal Card editedCard;

        public EditCardArgs(Card card) => editedCard = card;
    }
}