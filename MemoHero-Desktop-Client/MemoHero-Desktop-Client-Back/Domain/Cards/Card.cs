using System.Collections.Generic;

namespace ClientBack.Domain.Cards
{
    public class Card
    {
        public string Id { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
        public Category Category { get; set; }
        public HashSet<string> Tags { get; set; }
        public int DueDate { get; set; }
        public StudyMetadata StudyMetadata { get; set; }
    }
}
