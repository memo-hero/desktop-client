using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using ClientBack.Infrastructure.HTTP;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ClientBack.Domain.Study
{
    public class StudyResult
    {
        [JsonProperty("didLevelUp")]
        public bool DidLevelUp { get; set; }

        [JsonProperty("didGetKnockedOut")]
        public bool DidGetKnockedOut { get; set; }

        [JsonProperty("category")]
        public Dictionary<Category, CategoryProperties> Category { get; set; }

        [JsonProperty("userStats")]
        public UserStats UserStats { get; set; }
    }
}