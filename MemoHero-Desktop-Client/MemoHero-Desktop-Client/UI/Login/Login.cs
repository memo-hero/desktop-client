using ClientBack.Infrastructure.LoginProvider;
using MemoHeroDesktopClient.Domain;
using MemoHeroDesktopClient.UI.MainMenu;
using System;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.UI.Login
{
    public partial class Login : Form
    {
        private ILoginService client;

        public Login()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var user = await client.Login();
            if(user != null)
            {
                var window = new MainWindow(User.FromLoginUser(user));
                window.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.Logout();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
