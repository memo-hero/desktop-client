using ClientBack.Domain.Cards;
using MemoHeroDesktopClient.Common;
using MemoHeroDesktopClient.Domain.Localization;
using MemoHeroDesktopClient.Services;
using System;

namespace MemoHeroDesktopClient.Domain.Cards
{
    internal class GridableCard
    {
        private static readonly ILocalization localizationService = MemoHeroServices.TranslationService;

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
            Category = LocalizeCategory(card.Category);
            Tags = string.Join(", ", card.Tags);
            DueDate = DateTimeHelper.EpochToDateTime(card.DueDate);
        }

        private string LocalizeCategory(Category category)
            => localizationService.LocalizeCategory(category);
    }
}