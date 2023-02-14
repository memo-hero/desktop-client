using ClientBack.Infrastructure.HTTP;
using Newtonsoft.Json;

namespace ClientBack.Infrastructure.Helpers
{
    class NewtonSoftSerializer : ISerializer
    {
        private readonly JsonSerializerSettings settings;

        public NewtonSoftSerializer()
        {
            settings = new JsonSerializerSettings();
            settings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
        }

        public T Deserialize<T>(string value) => JsonConvert.DeserializeObject<T>(value);

        public string Serialize<T>(T objectToSerialize) => JsonConvert.SerializeObject(objectToSerialize, Formatting.None, settings);
    }
}
