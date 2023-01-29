using ClientBack.Core;
using ClientBack.Domain.Cards;
using ClientBack.Domain.User;
using DevExpress.XtraEditors;
using MemoHeroDesktopClient.UI.NewCard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.UI.MainWindow
{
    public partial class MainMenu : DevExpress.XtraEditors.XtraForm
    {
        private readonly MemoHeroCore memoCore;
        private readonly User user;
        private readonly XtraForm login;

        public MainMenu(XtraForm login, MemoHeroCore memoCore, User user)
        {
            InitializeComponent();
            this.memoCore = memoCore;
            this.user = user;
            this.login = login;
        }

        private async void MainMenu_Load(object sender, EventArgs e)
        {
            var cards = await memoCore.GetUserCards(user.Id);
            BindingList<Card> list = new BindingList<Card>(cards);

            gridCards.DataSource = list;
        }

        private void cardBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Close();
        }

        private void btnNewCard_Click(object sender, EventArgs e)
        {
            var newCardWindow = new NewCardWindow(memoCore);
            newCardWindow.Show();
        }
    }
}