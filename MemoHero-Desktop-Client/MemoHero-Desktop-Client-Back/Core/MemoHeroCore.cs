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

        public MemoHeroCore()
        {
            loginModule = new LoginModule();
            cardsModule = new CardsModule(ClientBackServiceProvider.RestClient);
            userModule = new UserModule(ClientBackServiceProvider.RestClient);
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

        public async Task<List<Card>> GetUserCards(string userId)
        {
            return await cardsModule.GetUserCards(userId);
        }

        public async Task<User> GetUserInfo(User user)
        {
            return await userModule.GetUserInfo(user);
        }

        public void Logout()
        {
            loginModule.Logout();
        }

        public void CreateCard(Card newCard)
        {
            cardsModule.CreateCard(currentUser, newCard);
        }
    }
}
