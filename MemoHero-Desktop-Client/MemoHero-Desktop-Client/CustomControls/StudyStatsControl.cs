using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using MemoHeroDesktopClient.Domain.Localization;
using MemoHeroDesktopClient.Infrastructure;
using MemoHeroDesktopClient.Services.Localization;
using System.Linq;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.CustomControls
{
    public partial class StudyStatsControl : UserControl
    {
        private static readonly ILocalization localizationService = MemoHeroServices.TranslationService;

        public StudyStatsControl()
        {
            InitializeComponent();
            LoadLocalizableControls();
        }

        private void LoadLocalizableControls() => tableLayoutPanel.Controls
            .OfType<LabelControl>()
            .Where(x => x.Tag == null)
            .ForEach(x => Localize(new LocalizableControlText(x)));

        private void Localize(ILocalizableControl control)
            => localizationService.AddLocalizableControl(control);

        internal void UpdateStats(UserStats userStats, Category category)
        {
            var currentCategory = userStats.Categories[category];

            progressBarHP.EditValue = CalculateHPPercentage(userStats.Health);
            lblCurrentCategory.Text = localizationService.LocalizeCategory(category);
            lblCurrentCategoryLevel.Text = currentCategory.Level.ToString();
            progressBarCategory.EditValue = CalculateCategoryPercentage(currentCategory);
        }

        private double CalculateCategoryPercentage(CategoryProperty categoryProperty)
            => (categoryProperty.Exp * 100) / categoryProperty.Needed;

        private double CalculateHPPercentage(int currentHP)
            => (currentHP * 100) / 100;
    }
}
