using ClientBack.Domain.Cards;
using System;

namespace MemoHeroDesktopClient.UI.StudyCards
{
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