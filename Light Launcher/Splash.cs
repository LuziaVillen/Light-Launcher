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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }


        Random rnd = new Random();
        int RandomN;
        int Value;

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            RandomN = rnd.Next(20, 90);
            SplashTimer.Interval = RandomN;
            Value++;
            if (Value == 100)
            {
                LoginPage Lg = new LoginPage();
                Lg.Show();
                Hide();
            }
        }
    }
}
