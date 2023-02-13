using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using ClientBack.Infrastructure.HTTP;
using System;
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

        internal async Task<List<Card>> GetUserCards(string userId) => await restClient.GetUserCards(userId);

        internal async Task<CreateCardResult> CreateCard(User currentUser, Card newCard)
        {
            var card = NewCard.FromCard(newCard);
            return await restClient.CreateCard(currentUser.Id, card);
        }

        internal async Task<bool> UpdateCard(User currentUser, Card updatedCard) => await restClient.UpdateCard(currentUser.Id, new UpdatedCard(updatedCard));

        internal async Task<StudyResult> StudyCard(User currentUser, Card card, int quality) => await restClient.StudyCard(currentUser.Id, card.Id, quality);

        internal async Task<List<Card>> GetDueCards(string userId) => await restClient.GetUserDueCards(userId);

        internal async Task<bool> DeleteCard(User user, Card card)
        {
            return await restClient.DeleteCard(user.Id, card.Id);
        }
    }
}
