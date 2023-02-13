using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ClientBack.Infrastructure.HTTP
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