using ClientBack.Domain.Cards;
using System;

namespace MemoHeroDesktopClient.Common
{

    internal class GridableCard
    {
        public string Id { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
        public string Tags { get; set; }
        public DateTime DueDate { get; set; }

        public GridableCard(Card card)
        {
            Id = card.Id;
            Front = card.Front;
            Back = card.Back;
            Tags = string.Join(", ", card.Tags);
            DueDate = UnixTimeStampToDateTime(card.DueDate);
        }

        private static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddDays(unixTimeStamp).ToLocalTime();
            return dateTime;
        }
    }
}