using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.CustomControls
{
    public partial class StudyStatsControl : UserControl
    {
        public StudyStatsControl()
        {
            InitializeComponent();
        }

        internal void UpdateStats(UserStats userStats, Category category)
        {
            var currentCategory = userStats.Categories[category];

            progressBarHP.EditValue = CalculateHPPercentage(userStats.Health);
            lblCurrentCategory.Text = category.ToString();
            progressBarCategory.EditValue = CalculateCategoryPercentage(currentCategory);
        }

        private double CalculateCategoryPercentage(CategoryProperty categoryProperty)
        {
            return (categoryProperty.Exp * 100) / categoryProperty.Needed;
        }

        private double CalculateHPPercentage(int currentHP)
        {
            return (currentHP * 100) / 100;
        }
    }
}
