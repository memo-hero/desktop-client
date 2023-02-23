using ClientBack.Domain.Cards;
using System.Collections.Generic;

namespace ClientBack.Infrastructure.HTTP
{
    internal class UpdatedCard
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string front { get; set; }
        public string back { get; set; }
        public Category category { get; set; }
        public HashSet<string> tags { get; set; }
        public int dueDate { get; set; }
        public UpdatedStudyMetadata studyMetadata { get; set; }

        public UpdatedCard(Card card)
        {
            id = card.Id;
            userId = card.UserId;
            front = card.Front;
            back = card.Back;
            category = card.Category;
            tags = card.Tags;
            dueDate = card.DueDate;
            studyMetadata = new UpdatedStudyMetadata(card.StudyMetadata);
        }

        internal class UpdatedStudyMetadata
        {
            public int repetition;
            public double easeFactor;
            public long interval;

            public UpdatedStudyMetadata(StudyMetadata studyMetadata)
            {
                repetition = studyMetadata.Repetition;
                easeFactor = studyMetadata.EaseFactor;
                interval = studyMetadata.Interval;
            }
        }
    }
}
