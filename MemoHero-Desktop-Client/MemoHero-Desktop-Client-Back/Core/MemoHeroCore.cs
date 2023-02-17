using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using ClientBack.Infrastructure.Helpers;
using ClientBack.Infrastructure.HTTP;
using ClientBack.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientBack.Core
{
    public class MemoHeroCore
    {
        private User currentUser;
        private readonly LoginModule loginModule;
        private readonly CardsModule cardsModule;
        private readonly UserModule userModule;

        public string GetLastLocale() => loginModule.GetUserFromLocalDb().user.Locale;

        private ISerializer serializer = new NewtonSoftSerializer();

        public List<Card> UserCards = new List<Card>();
        public List<Card> DueCards;

        public MemoHeroCore()
        {
            loginModule = new LoginModule();
            cardsModule = new CardsModule(ClientBackServiceProvider.RestClient);
            userModule = new UserModule(ClientBackServiceProvider.RestClient);
        }

        public async Task<bool> IsServiceOnline()
        {
            var client = ClientBackServiceProvider.RestClient;
            return await client.IsServiceOnline();
        }

        public bool IsLoggedIn()
        {
            return loginModule.IsLoggedIn();
        }

        public User GetLocalUser()
        {
            currentUser = loginModule.GetUserFromLocalDb().ToUser();

            return currentUser;
        }

        public async Task<User> Login()
        {
            var result = await loginModule.Login();
            currentUser = result?.ToUser();
            
            return currentUser;
        }

        public async Task<bool> GetUserCards()
        {
            UserCards = await cardsModule.GetUserCards(currentUser.Id);
            return true;
        }

        public async Task<bool> GetUserDueCards()
        {
            DueCards = await cardsModule.GetDueCards(currentUser.Id);
            return true;
        }

        public async Task<User> GetUserInfo(User user) => await userModule.GetUserInfo(user);

        public void Logout()
        {
            currentUser = null;
            UserCards = new List<Card>();
            loginModule.Logout();
        }

        public async Task<Card> CreateCardAsync(Card newCard)
        {
            var card = await cardsModule.CreateCard(currentUser, newCard);
            if (card != null) DueCards.Add(card);

            return card;
        }

        public async Task<bool> UpdateCardAsync(Card editedCard)
        {
            if (await cardsModule.UpdateCard(currentUser, editedCard))
            {
                UserCards.Remove(UserCards.Find(x => x.Id == editedCard.Id));
                UserCards.Add(editedCard);
                return true;
            }

            return false;
        }

        public async void ImportCards(string content)
        {
            if (string.IsNullOrWhiteSpace(content)) return;

            var cards = serializer.Deserialize<List<Card>>(content);
            cards.ForEach(async x => await CreateCardAsync(x));
            await GetUserDueCards();
        }

        public string ExportCards()
        {
            if (UserCards.Count == 0) return string.Empty;
            return serializer.Serialize(UserCards);
        }

        public async Task<StudyResult> StudyCard(Card card, int quality)
        {
            var result = await cardsModule.StudyCard(currentUser, card, quality);
            currentUser.Stats = result.UserStats;

            return result;
        }

        public async Task<bool> DeleteCard(Card card)
        {
            return await cardsModule.DeleteCard(currentUser, card);
        }
    }
}
