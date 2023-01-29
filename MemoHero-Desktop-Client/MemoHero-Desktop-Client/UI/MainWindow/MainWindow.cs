using ClientBack.Core;
using ClientBack.Domain.User;
using MemoHeroDesktopClient.Infrastructure;
using System;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.UI.MainMenu
{
    public partial class MainWindow : Form
    {
        MemoHeroCore memoCore = MemoHeroServices.Core;
        User user;

        public MainWindow(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            label1.Text = user.Nickname;
            var result = await memoCore.GetUserCards(user.Id);
        }
    }
}
