using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
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

        public List<Card> UserCards;

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

        public async Task<bool> GetUserCards(string userId)
        {
            UserCards = await cardsModule.GetUserCards(userId);
            return true;
        }

        public async Task<User> GetUserInfo(User user)
        {
            return await userModule.GetUserInfo(user);
        }

        public void Logout()
        {
            currentUser = null;
            UserCards = null;
            loginModule.Logout();
        }

        public async Task<Card> CreateCardAsync(Card newCard)
        {
            var card = await cardsModule.CreateCard(currentUser, newCard);
            UserCards.Add(newCard);

            return card;
        }
    }
}
