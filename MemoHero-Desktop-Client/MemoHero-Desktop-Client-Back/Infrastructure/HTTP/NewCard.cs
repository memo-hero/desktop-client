using ClientBack.Domain.Cards;
using System.Collections.Generic;

namespace ClientBack.Infrastructure.HTTP
{
    internal class NewCard
    {
        public string front { get; set; }
        public string back { get; set; }
        public Category category { get; set; }
        public HashSet<string> tags { get; set; }

        internal static NewCard FromCard(Card card) => new NewCard
        {
            front = card.Front,
            back = card.Back,
            category = card.Category,
            tags = card.Tags
        };
    }
}
