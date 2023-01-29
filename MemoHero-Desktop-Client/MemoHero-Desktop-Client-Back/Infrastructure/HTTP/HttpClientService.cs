using ClientBack.Domain;
using ClientBack.Domain.Cards;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClientBack.Infrastructure.HTTP
{
    internal class HttpClientService : IMemoHeroRestClient
    {
        static RestClient client;
        private readonly string baseUrl = "http://localhost:8080/";

        public HttpClientService()
        {
            client = new RestClient(baseUrl);
        }

        public async Task<StoredUser> CreateUser(NewUser newUser)
        {
            var body = JsonConvert.SerializeObject(newUser, Formatting.None);
            var request = new RestRequest("users")
                .AddStringBody(body, DataFormat.Json);
            
            return await client.PostAsync<StoredUser>(request);
        }

        public async Task<StoredUser> RetrieveUser(string userId)
        {
            var request = new RestRequest("users/{user}").AddUrlSegment("user", userId);
            try
            {
                return await client.GetAsync<StoredUser>(request);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<Card>> GetUserCards(string userId)
        {
            var request = new RestRequest("users/{userId}/cards").AddUrlSegment("userId", userId);
            try
            {
                return await client.GetAsync<List<Card>>(request);
            }
            catch (Exception)
            {
                return new List<Card>();
            }
        }

        internal async Task<Card> GetCardByIdAsync(string userId, string cardId)
        {
            var request = new RestRequest("users/{userId}/cards/{cardId}")
                .AddUrlSegment("userId", userId)
                .AddUrlSegment("cardId", cardId);
            try
            {
                return await client.GetAsync<Card>(request);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}