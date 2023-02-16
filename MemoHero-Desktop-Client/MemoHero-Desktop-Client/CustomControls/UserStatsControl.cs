using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using MemoHeroDesktopClient.Infrastructure;
using MemoHeroDesktopClient.Infrastructure.Translation;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.CustomControls
{
    public partial class UserStatsControl : UserControl
    {
        private static readonly LocalizationService localizationService = MemoHeroServices.TranslationService;
        private static string username;

        public UserStatsControl(User user)
        {
            InitializeComponent();
            username = user.Nickname;
            UpdateTableStats(user);
            LoadLocalizableControls();
        }

        private void LoadLocalizableControls()
        {
            localizationService.AddLocalizableControl(new LocalizableControlText(lblWelcome));
            lblWelcome.Text = string.Format(lblWelcome.Text, username);
        }

        internal void UpdateTableStats(User user)
        {
            tableStats.Controls.Clear();
            foreach (var item in user.Stats.Categories)
            {
                var stat = new CategoryStats(new KeyValuePair<Category, CategoryProperty>(item.Key, item.Value));
                tableStats.Controls.Add(stat);
            }
        }
    }
}
