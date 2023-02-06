using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.CustomControls
{
    public partial class UserStatsControl : UserControl
    {
        public UserStatsControl(User user)
        {
            InitializeComponent();
            UpdateLabels(user);
        }

        private void UpdateLabels(User user)
        {
            lblWelcome.Text = $"Welcome { user.Nickname }!";

            lblArts.Text = "Arts";
            lblArtsLevel.Text = "LVL: " + user.Stats.Categories[Category.ARTS].Level.ToString();
            expArts.EditValue = GetExpPercentValue(user, Category.ARTS);

            lblComputers.Text = "Computers";
            lblComputersLevel.Text = "LVL: " + user.Stats.Categories[Category.COMPUTERS].Level.ToString();
            expComputers.EditValue = GetExpPercentValue(user, Category.COMPUTERS);

            lblHistory.Text = "History";
            lblHistoryLevel.Text = "LVL: " + user.Stats.Categories[Category.HISTORY].Level.ToString();
            expHistory.EditValue = GetExpPercentValue(user, Category.HISTORY);

            lblLanguages.Text = "Languages";
            lblLanguagesLevel.Text = "LVL: " + user.Stats.Categories[Category.LANGUAGES].Level.ToString();
            expLanguages.EditValue = GetExpPercentValue(user, Category.LANGUAGES);

            lblScience.Text = "Science";
            lblScienceLevel.Text = "LVL: " + user.Stats.Categories[Category.SCIENCE].Level.ToString();
            expScience.EditValue = GetExpPercentValue(user, Category.SCIENCE);
        }

        private static int GetExpPercentValue(User user, Category category)
        {
            var currentExp = user.Stats.Categories[category].Exp;
            var neededExp = user.Stats.Categories[category].Needed;

            if (neededExp == 0) return 0;

            return (currentExp * 100 / neededExp);
        }
    }
}
