using ClientBack.Domain.Cards;
using ClientBack.Domain.Study;
using ClientBack.Infrastructure.Services;
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

        public HttpClientService(ISerializer serializer, HttpClientConfiguration configuration)
        {
            client = new RestClient(configuration.BaseUrl);
            this.serializer = serializer;
        }

        public async Task<bool> IsServiceOnline() => await IsPostSuccessful(new RestRequest("healthz"));

        public async Task<bool> PushLogs(string userId, List<LogJson> logs)
        {
            var request = new RestRequest("users/{userId}/logs")
                .AddUrlSegment("userId", userId)
                .AddStringBody(serializer.Serialize(logs), DataFormat.Json);

            try
            {
                return await IsPostSuccessful(request);
            }
            catch (Exception ex)
            {
                ClientBackServiceProvider.logger.Log(ex);
                // We shouldnt show a message that the logs couldnt be pushed, not important for the user
                return false;
            }
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
            var result = await MakeGet(request);

            if (result.IsSuccessStatusCode) return serializer.Deserialize<StoredUser>(result.Content);

            return null;
        }

        public async Task<List<Card>> GetUserCards(string userId)
        {
            var request = new RestRequest("users/{userId}/cards")
                .AddUrlSegment("userId", userId);
            
            return await MakeGet<List<Card>>(request);
        }

        public async Task<List<Card>> GetUserDueCards(string userId)
        {
            var request = new RestRequest("users/{userId}/cards/due")
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

        public async Task<bool> DeleteCard(string userId, string cardId)
        {
            var request = new RestRequest("users/{userId}/cards/{cardId}")
                .AddUrlSegment("userId", userId)
                .AddUrlSegment("cardId", cardId);

                return await IsDeleteSuccessful(request);
        }

        private async Task<T> MakePost<T>(RestRequest request)
        {
            var result = await client.PostAsync(request);
            return serializer.Deserialize<T>(result.Content);
        }

        private async Task<bool> IsPostSuccessful(RestRequest request)
        {
            var result = await client.PostAsync(request);
            return result.IsSuccessful;
        }

        private async Task<T> MakeGet<T>(RestRequest request)
        {
            var result = await client.GetAsync(request);
            return serializer.Deserialize<T>(result.Content);
        }

        private async Task<RestResponse> MakeGet(RestRequest request) => await client.GetAsync(request);

        private async Task<bool> IsDeleteSuccessful(RestRequest request)
        {
            var result = await client.DeleteAsync(request);
            return result.IsSuccessful;
        }
    }
}