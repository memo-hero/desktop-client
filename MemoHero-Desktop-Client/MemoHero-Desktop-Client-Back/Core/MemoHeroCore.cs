﻿using ClientBack.Domain.Cards;
using ClientBack.Domain.Exceptions;
using ClientBack.Domain.Logger;
using ClientBack.Domain.Study;
using ClientBack.Domain.User;
using ClientBack.Infrastructure.Helpers;
using ClientBack.Infrastructure.HTTP;
using ClientBack.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientBack.Core
{
    public class MemoHeroCore
    {
        private static readonly ILogger logger = ClientBackServiceProvider.logger;
        private readonly LoginModule loginModule;
        private readonly CardsModule cardsModule;
        private readonly UserModule userModule;
        private User currentUser;

        public string GetLastLocale()
        {
            var result = loginModule.GetUserFromLocalDb();
            if (result != null) return result.user.Locale;
            else return "EN";
        }

        private readonly ISerializer serializer = new NewtonSoftSerializer();

        public List<Card> UserCards = new List<Card>();
        public List<Card> DueCards;

        public MemoHeroCore()
        {
            loginModule = new LoginModule();
            cardsModule = new CardsModule(ClientBackServiceProvider.RestClient);
            userModule = new UserModule(ClientBackServiceProvider.RestClient);
        }

        public static bool IsLocalDbAvailable()
            => ClientBackServiceProvider.LiteDatabase.Engine.Info() != null;

        public static async Task<bool> IsServiceOnline() => await ExceptionHandler.Execute(async () =>
        {
            return await ClientBackServiceProvider.RestClient.IsServiceOnline();
        });

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
            if (UserCards == null) throw new CannotConnectToRemoteService();

            return true;
        }

        public async Task<bool> GetUserDueCards()
        {
            DueCards = await cardsModule.GetDueCards(currentUser.Id);
            if (DueCards == null) throw new CannotConnectToRemoteService();

            return true;
        }

        public async Task<User> GetUserInfo(User user)
        {
            user = await userModule.GetUserInfo(user);
            if (user == null) throw new CannotConnectToRemoteService();
            
            return user;
        }

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

        public async Task ImportCards(string content)
        {
            if (string.IsNullOrWhiteSpace(content)) return;

            var cards = serializer.Deserialize<List<Card>>(content);
            var tasks = cards.Select(x => CreateCardAsync(x));
            await Task.WhenAll(tasks);
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

        public void UpdateLocale()
        {
            loginModule.UpdateLoginLocale(currentUser.Locale);
        }

        public async Task<bool> PushLogs()
        {
            var logs = logger.GetUnpushedLogs();
            var logsJson = logs.Select(x => new LogJson(x)).ToList();
            if (await ClientBackServiceProvider.RestClient.PushLogs(currentUser.Id, logsJson))
            {
                logs.ForEach(x => x.SentToServer = true);
                logger.UpdateLogs(logs);
                return true;
            }

            return false;
        }
    }
}
