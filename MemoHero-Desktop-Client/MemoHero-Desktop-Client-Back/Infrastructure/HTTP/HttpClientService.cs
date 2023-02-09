using ClientBack.Domain.Cards;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientBack.Infrastructure.HTTP
{
    internal class HttpClientService : IMemoHeroRestClient
    {
        private static RestClient client;
        private readonly ISerializer serializer;
        private readonly string baseUrl = "http://localhost:8080/";

        public HttpClientService(ISerializer serializer)
        {
            client = new RestClient(baseUrl);
            this.serializer = serializer;
        }

        public async Task<StoredUser> CreateUser(NewUser newUser)
        {
            var request = new RestRequest("users")
                .AddStringBody(serializer.Serialize(newUser), DataFormat.Json);
            
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
                var result = await client.GetAsync(request);
                return serializer.Deserialize<List<Card>>(result.Content);
            }
            catch (Exception ex)
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

        public async Task<CreateCardResult> CreateCard(string userId, NewCard newCard)
        {
            var request = new RestRequest("users/{userId}/cards")
                .AddUrlSegment("userId", userId)
                .AddStringBody(serializer.Serialize(newCard), DataFormat.Json);

            try
            {
                var createResult = await client.PostAsync(request);
                return serializer.Deserialize<CreateCardResult>(createResult.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<bool> IsServiceOnline()
        {
            var request = new RestRequest("healthz");
            
            try
            {
                var result = await client.PostAsync(request);
                return result.StatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateCard(string userId, UpdatedCard card)
        {
            var request = new RestRequest("users/{userId}/cards/{cardId}")
                .AddUrlSegment("userId", userId)
                .AddUrlSegment("cardId", card.id)
                .AddStringBody(serializer.Serialize(card), DataFormat.Json);

            try
            {
                var createResult = await client.PostAsync(request);
                return createResult.IsSuccessful;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<StudyResult> StudyCard(string userId, string cardId, int quality)
        {
            var request = new RestRequest("users/{userId}/cards/{cardId}/study")
                .AddUrlSegment("userId", userId)
                .AddUrlSegment("cardId", cardId)
                .AddQueryParameter("quality", quality);

            try
            {
                var createResult = await client.PostAsync(request);
                return serializer.Deserialize<StudyResult>(createResult.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}