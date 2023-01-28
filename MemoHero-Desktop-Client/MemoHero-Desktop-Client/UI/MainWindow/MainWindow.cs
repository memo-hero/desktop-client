using ClientBack.Domain;
using ClientBack.Infrastructure.HTTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoHeroDesktopClient.UI.MainMenu
{
    public partial class MainWindow : Form
    {
        User user;

        public MainWindow(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            var client = new HttpClientService();
            var card = await client.GetCardByIdAsync("test", "6604be12-3273-45e4-b5e9-77574ad56637");
        }
    }
}
