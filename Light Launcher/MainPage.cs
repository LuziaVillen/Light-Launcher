using CmlLib.Core;
using CmlLib.Core.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Light_Launcher
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public static string versiyon;

        private void vercombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            playbutton.Enabled = false;
            Thread thread = new Thread(() => Launch());
            thread.IsBackground = true;
            thread.Start();
        }


        private void path()
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);

            launcher.ProgressChanged += (s, e) =>
            {
                //bar2.Value = e.ProgressPercentage;
            };

            foreach (var item in launcher.GetAllVersions())
            {
                vercombo.Items.Add(item.Name);
            }

        }

        private void Launch()
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = 3072,
                Session = MSession.GetOfflineSession(LoginPage.user),
                ServerIp = "oyna.dunyamc.com",


            };
            versiyon = vercombo.SelectedItem.ToString();
            var process = launcher.CreateProcess(versiyon, launchOption);

            process.Start();
            Hide();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            path();
            username.Text = LoginPage.user;
            var request = WebRequest.Create("https://minotar.net/helm/" + username.Text + "/64.png");
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pp.Image = Bitmap.FromStream(stream);
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            Hide();
        }
    }
}
