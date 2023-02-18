using ClientBack.Domain.Cards;
using ClientBack.Domain.Logger;
using ClientBack.Domain.Study;
using ClientBack.Domain.User;
using ClientBack.Infrastructure.HTTP;
using ClientBack.Infrastructure.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientBack.Core
{
    internal class CardsModule
    {
        private readonly ILogger logger = ClientBackServiceProvider.logger;
        private readonly IMemoHeroRestClient restClient;

        public CardsModule(IMemoHeroRestClient restClient) => this.restClient = restClient;

        internal async Task<List<Card>> GetUserCards(string userId) => await ExceptionHandler.Execute(async () =>
        {
            logger.Log("Getting user's cards from the server...", Severity.INFO);
            return await restClient.GetUserCards(userId);
        });

        internal async Task<CreateCardResult> CreateCard(User currentUser, Card newCard) => await ExceptionHandler.Execute(async () =>
        {
            logger.Log("Sending new card to server...", Severity.INFO);
            var card = NewCard.FromCard(newCard);
            return await restClient.CreateCard(currentUser.Id, card);
        });

        internal async Task<bool> UpdateCard(User currentUser, Card updatedCard) => await ExceptionHandler.Execute(async () =>
        {
            logger.Log("Sending updated card to server...", Severity.INFO);
            return await restClient.UpdateCard(currentUser.Id, new UpdatedCard(updatedCard));
        });

        internal async Task<StudyResult> StudyCard(User currentUser, Card card, int quality) => await ExceptionHandler.Execute(async () =>
        {
            logger.Log("Sending card response to server...", Severity.INFO);
            return await restClient.StudyCard(currentUser.Id, card.Id, quality);
        });

        internal async Task<List<Card>> GetDueCards(string userId) => await ExceptionHandler.Execute(async () =>
        {
            logger.Log("Getting due cards from server...", Severity.INFO);
            return await restClient.GetUserDueCards(userId);
        });

        internal async Task<bool> DeleteCard(User user, Card card) => await ExceptionHandler.Execute(async () =>
        {
            logger.Log("Deleting card from server...", Severity.INFO);
            return await restClient.DeleteCard(user.Id, card.Id);
        });
    }
}
