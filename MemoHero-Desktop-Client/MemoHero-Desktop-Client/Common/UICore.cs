using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using MemoHeroDesktopClient.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.Common
{
    internal class UICore
    {
        private User user;
        private Dictionary<string, UserControl> customControls = new Dictionary<string, UserControl>();
        private UserStatsControl userStatsControl;
        private CardListControl cardListControl;
        private Panel panel;

        public UICore(ref User user, Panel panel)
        {
            this.user = user;
            this.panel = panel;

            SetUserStatsControl();
        }

        internal void SetUserStatsControl()
        {
            userStatsControl = new UserStatsControl(user);
            customControls.Add("ribbonPageUserStatus", userStatsControl);
            panel.Controls.Add(userStatsControl);
        }

        internal void SetCardListControl(List<Card> cards)
        {
            cardListControl = new CardListControl();
            cardListControl.SetDataSource(cards);
            customControls.Add("ribbonPageCards", cardListControl);
            panel.Controls.Add(cardListControl);
        }

        internal void UpdatePanel(string currentPageName)
        {
            foreach (var control in customControls)
            {
                control.Value.Visible = control.Key == currentPageName;
            }
        }
    }
}
