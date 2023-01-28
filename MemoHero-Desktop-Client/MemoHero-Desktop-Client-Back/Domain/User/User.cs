using ClientBack.Infrastructure.LoginProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBack.Domain.User
{
    public class User
    {
        public string Id;
        public string Nickname;
        public string Email;
        public string Picture;
        public string Locale;
        public UserStats Stats;
    }
}
