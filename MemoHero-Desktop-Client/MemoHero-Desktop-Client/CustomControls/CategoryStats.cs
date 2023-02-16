using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using MemoHeroDesktopClient.Infrastructure;
using MemoHeroDesktopClient.Infrastructure.Translation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.CustomControls
{
    internal partial class CategoryStats : UserControl
    {
        private static readonly LocalizationService localizationService = MemoHeroServices.TranslationService;

        public CategoryStats(KeyValuePair<Category, CategoryProperty> stats)
        {
            InitializeComponent();
            Initialize(stats);
        }

        private void Initialize(KeyValuePair<Category, CategoryProperty> stats)
        {
            pictureCategory.Image = ResolveCategoryImage(stats.Key);
            lblCategoryName.Text = localizationService.LocalizeCategory(stats.Key);
            lblCategoryLevel.Text = "LVL: " + stats.Value.Level.ToString();
            progressCategory.EditValue = GetExpPercentValue(stats.Value);
        }

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
