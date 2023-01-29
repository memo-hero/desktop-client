using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using ClientBack.Infrastructure.HTTP;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientBack.Core
{
    internal class CardsModule
    {
        private readonly IMemoHeroRestClient restClient;

        public CardsModule(IMemoHeroRestClient restClient)
        {
            this.restClient = restClient;
        }

        internal async Task<List<Card>> GetUserCards(string userId)
        {
            return await restClient.GetUserCards(userId);
        }

        internal void CreateCard(User currentUser, Card newCard)
        {
            var card = NewCard.FromCard(newCard);
            restClient.CreateCard(currentUser.Id, card);
        }
    }
}
