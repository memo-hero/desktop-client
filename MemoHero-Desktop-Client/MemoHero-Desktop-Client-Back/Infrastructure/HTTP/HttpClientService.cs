using ClientBack.Domain;
using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClientBack.Infrastructure.HTTP
{
    internal class HttpClientService : IMemoHeroRestClient
    {
        static HttpClient client = new HttpClient();
        static RestClient client2 = new RestClient("http://localhost:8080/");
        private readonly string baseUrl = "http://localhost:8080/";

        public HttpClientService()
        {
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<StoredUser> CreateUser(NewUser newUser)
        {
            var body = JsonConvert.SerializeObject(newUser, Formatting.None);
            var request = new RestRequest("users")
                .AddStringBody(body, DataFormat.Json);
            
            return await client2.PostAsync<StoredUser>(request);
        }

        public async Task<StoredUser> RetrieveUser(string id)
        {
            var request = new RestRequest("users/{user}").AddUrlSegment("user", id);
            try
            {
                return await client2.GetAsync<StoredUser>(request);
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal async void test()
        {
            string card = null;
            var result = await client.GetAsync(new Uri("http://localhost:8080/users/test/cards/6604be12-3273-45e4-b5e9-77574ad56637"));
            if (result.IsSuccessStatusCode)
            {
                card = await result.Content.ReadAsStringAsync();
            }
            var test = JsonConvert.DeserializeObject<Card>(card);
        }

        internal async Task<Card> GetCardByIdAsync(string username, string cardId)
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

    public class NewUser
    {
        public string id;
        public NewUser(string email)
        {
            id = email;
        }
    }

    internal class StoredUser
    {
        public string Id { get; set; }
        public UserStats Stats { get; set; }

    }
}