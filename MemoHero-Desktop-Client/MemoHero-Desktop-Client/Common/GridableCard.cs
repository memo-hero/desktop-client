using ClientBack.Domain.Cards;
using System;

namespace MemoHeroDesktopClient.Common
{

    internal class GridableCard
    {
        public string Id { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
        public string Category { get; set; }
        public string Tags { get; set; }
        public DateTime DueDate { get; set; }

        public GridableCard(Card card)
        {
            Id = card.Id;
            Front = card.Front;
            Back = card.Back;
            Category = card.Category.ToString();
            Tags = string.Join(", ", card.Tags);
            DueDate = DateTimeHelper.EpochToDateTime(card.DueDate);
        }
    }
}