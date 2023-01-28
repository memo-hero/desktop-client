using ClientBack.Domain;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClientBack.Infrastructure.HTTP
{
    public class HttpClientService
    {
        static HttpClient client = new HttpClient();
        private readonly string baseUrl = "http://localhost:8080/";

        public HttpClientService()
        {
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async void test()
        {
            string card = null;
            var result = await client.GetAsync(new Uri("http://localhost:8080/users/test/cards/6604be12-3273-45e4-b5e9-77574ad56637"));
            if (result.IsSuccessStatusCode)
            {
                card = await result.Content.ReadAsStringAsync();
            }
            var test = JsonConvert.DeserializeObject<Card>(card);
        }

        public async Task<Card> GetCardByIdAsync(string username, string cardId)
        {
            var url = new Uri(baseUrl + $"users/{ username }/cards/{ cardId }");
            var response = await client.GetAsync(url);
            Card card = null;
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();
                card = JsonConvert.DeserializeObject<Card>(stringResponse);
            }

            return card;
        }
    }
}