using ClientBack.Domain.User;
using Newtonsoft.Json;

namespace ClientBack.Infrastructure.HTTP
{
    public class StudyResult
    {
        [JsonProperty("didLevelUp")]
        public bool DidLevelUp { get; set; }

        [JsonProperty("didGetKnockedOut")]
        public bool DidGetKnockedOut { get; set; }

        [JsonProperty("category")]
        public CategoryProperties Category { get; set; }

        [JsonProperty("userStats")]
        public UserStats UserStats { get; set; }
    }
}