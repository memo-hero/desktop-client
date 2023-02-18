using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using MemoHeroDesktopClient.Domain.Localization;
using MemoHeroDesktopClient.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.CustomControls
{
    internal partial class CategoryStats : UserControl
    {
        private static readonly ILocalization localizationService = MemoHeroServices.TranslationService;
        private readonly Category category;

        public CategoryStats(KeyValuePair<Category, CategoryProperty> stats)
        {
            InitializeComponent();
            category = stats.Key;
            localizationService.LocalizationChanged += LocalizationService_LocalizationChanged;
            Initialize(stats);
        }

        private void LocalizationService_LocalizationChanged(object source, EventArgs args)
            => UpdateLabel();

        private void Initialize(KeyValuePair<Category, CategoryProperty> stats)
        {
            pictureCategory.Image = ResolveCategoryImage(category);
            lblCategoryLevel.Text = "LVL: " + stats.Value.Level.ToString();
            progressCategory.EditValue = GetExpPercentValue(stats.Value);
            UpdateLabel();
        }

        private void UpdateLabel()
            => lblCategoryName.Text = localizationService.LocalizeCategory(category);

        private Bitmap ResolveCategoryImage(Category category)
        {
            switch (category)
            {
                case Category.ARTS:
                    return Properties.Resources.art_512;
                case Category.COMPUTERS:
                    return Properties.Resources.computers_512;
                case Category.HISTORY:
                    return Properties.Resources.history_512;
                case Category.LANGUAGES:
                    return Properties.Resources.languages_512;
                case Category.SCIENCE:
                    return Properties.Resources.science_512;
                default:
                    throw new Exception("Could not resolve category");
            }
        }

        private static long GetExpPercentValue(CategoryProperty properties)
        {
            if (properties.Needed == 0) return 0;

            return properties.Exp * 100 / properties.Needed;
        }
    }
}
