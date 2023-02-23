using Newtonsoft.Json;

namespace ClientBack.Infrastructure.HTTP
{
    public class CategoryProperties
    {
        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("exp")]
        public long Exp { get; set; }

        [JsonProperty("needed")]
        public long Needed { get; set; }
    }
}