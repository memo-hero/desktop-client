using ClientBack.Core;
using MemoHeroDesktopClient.Infrastructure;
using MemoHeroDesktopClient.UI.MainMenu;
using System;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.UI.Login
{
    public partial class Login : Form
    {
        private MemoHeroCore memoCore = MemoHeroServices.Core;

        public Login()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            var user = await memoCore.Login();
            if(user != null)
            {
                MainWindow mainMenu = new MainWindow(user);
                mainMenu.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            memoCore.Logout();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
