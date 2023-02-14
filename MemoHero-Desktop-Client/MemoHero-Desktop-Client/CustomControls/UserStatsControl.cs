using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.CustomControls
{
    public partial class UserStatsControl : UserControl
    {
        public UserStatsControl(User user)
        {
            InitializeComponent();
            UpdateTableStats(user);
            UpdateLabels(user);
        }

        private void UpdateLabels(User user)
        {
            lblWelcome.Text = $"Welcome { user.Nickname }!";
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
