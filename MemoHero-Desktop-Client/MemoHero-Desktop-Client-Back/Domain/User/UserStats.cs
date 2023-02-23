using ClientBack.Domain.Cards;
using System.Collections.Generic;

namespace ClientBack.Domain.User
{
    public class UserStats
    {
        public int Health { get; set; }
        public Dictionary<Category, CategoryProperty> Categories { get; set; }
    }
}