﻿using ClientBack.Domain.Cards;
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

            localizationService.AddLocalizableControl(new LocalizableControlText(lblWelcome));
            localizationService.LocalizationChanged += LocalizationService_LocalizationChanged;
            UpdateWelcome();
        }

        private void UpdateWelcome() => lblWelcome.Text = string.Format(lblWelcome.Text, username);


        private void LocalizationService_LocalizationChanged(object source, System.EventArgs args)
            => UpdateWelcome();

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
