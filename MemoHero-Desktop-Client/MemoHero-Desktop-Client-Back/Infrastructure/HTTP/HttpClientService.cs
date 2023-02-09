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

        public async Task<bool> IsServiceOnline() => await IsPostSuccessful(new RestRequest("healthz"));

        public async Task<StoredUser> CreateUser(NewUser newUser)
        {
            var request = new RestRequest("users")
                .AddStringBody(serializer.Serialize(newUser), DataFormat.Json);
            
            return await client.PostAsync<StoredUser>(request);
        }

        public async Task<StoredUser> RetrieveUser(string userId)
        {
            var request = new RestRequest("users/{user}").AddUrlSegment("user", userId);

            return await MakeGet<StoredUser>(request);
        }

        public async Task<List<Card>> GetUserCards(string userId)
        {
            var request = new RestRequest("users/{userId}/cards")
                .AddUrlSegment("userId", userId);
            
            return await MakeGet<List<Card>>(request);
        }

        internal async Task<Card> GetCardByIdAsync(string userId, string cardId)
        {
            var request = new RestRequest("users/{userId}/cards/{cardId}")
                .AddUrlSegment("userId", userId)
                .AddUrlSegment("cardId", cardId);

            return await MakeGet<Card>(request);
        }

        public async Task<CreateCardResult> CreateCard(string userId, NewCard newCard)
        {
            var request = new RestRequest("users/{userId}/cards")
                .AddUrlSegment("userId", userId)
                .AddStringBody(serializer.Serialize(newCard), DataFormat.Json);

            return await MakePost<CreateCardResult>(request);
        }

        public async Task<bool> UpdateCard(string userId, UpdatedCard card)
        {
            var request = new RestRequest("users/{userId}/cards/{cardId}")
                .AddUrlSegment("userId", userId)
                .AddUrlSegment("cardId", card.id)
                .AddStringBody(serializer.Serialize(card), DataFormat.Json);

            return await IsPostSuccessful(request);
        }

        public async Task<StudyResult> StudyCard(string userId, string cardId, int quality)
        {
            var request = new RestRequest("users/{userId}/cards/{cardId}/study")
                .AddUrlSegment("userId", userId)
                .AddUrlSegment("cardId", cardId)
                .AddQueryParameter("quality", quality);

            return await MakePost<StudyResult>(request);
        }

        private async Task<T> MakePost<T>(RestRequest request)
        {
            try
            {
                var result = await client.PostAsync(request);
                return serializer.Deserialize<T>(result.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
        }

        private async Task<bool> IsPostSuccessful(RestRequest request)
        {
            try
            {
                var result = await client.PostAsync(request);
                return result.IsSuccessful;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
        }

        private async Task<T> MakeGet<T>(RestRequest request)
        {
            try
            {
                var result = await client.GetAsync(request);
                return serializer.Deserialize<T>(result.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
        }
    }
}