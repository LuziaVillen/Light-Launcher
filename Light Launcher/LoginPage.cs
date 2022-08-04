using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Light_Launcher
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public static string user;

        private void loginbutton_Click(object sender, EventArgs e)
        {
            loginbutton.Text = user;
            MainPage main = new MainPage();
            main.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbutton_Click_1(object sender, EventArgs e)
        {
            user = usernamebox.Text;
            MainPage main = new MainPage();
            main.Show();
            Hide();
        }
    }
}
