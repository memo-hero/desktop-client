using ClientBack.Domain.Cards;
using System;

namespace MemoHeroDesktopClient.Domain.Events
{
    internal class CreateCardArgs : EventArgs
    {
        internal Card newCard;
        public CreateCardArgs(Card card) => newCard = card;
    }
}