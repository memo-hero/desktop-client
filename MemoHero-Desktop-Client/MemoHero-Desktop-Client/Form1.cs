using Auth0.OidcClient;
using LoginService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoHero_Desktop_Client
{
    public partial class Form1 : Form
    {
        LoginServiceCore client = new LoginServiceCore();

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var user = await client.Login();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.Logout();
        }
    }
}
