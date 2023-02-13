using ClientBack.Domain.Cards;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientBack.Infrastructure.HTTP
{
    interface IMemoHeroRestClient
    {
        Task<StoredUser> CreateUser(NewUser newUser);
        Task<StoredUser> RetrieveUser(string userId);
        Task<List<Card>> GetUserCards(string userId);
        Task<CreateCardResult> CreateCard(string id, NewCard newCard);
        Task<bool> UpdateCard(string userId, UpdatedCard card);
        Task<bool> IsServiceOnline();
        Task<StudyResult> StudyCard(string id1, string id2, int quality);
        Task<List<Card>> GetUserDueCards(string userId);
        Task<bool> DeleteCard(string userId, string cardId);
    }
}
