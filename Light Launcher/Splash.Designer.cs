namespace Light_Launcher
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.SplashLogo = new System.Windows.Forms.PictureBox();
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.Panel = new System.Windows.Forms.Panel();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplashLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashLogo
            // 
            this.SplashLogo.Image = global::Light_Launcher.Properties.Resources.Logo;
            this.SplashLogo.Location = new System.Drawing.Point(161, 76);
            this.SplashLogo.Name = "SplashLogo";
            this.SplashLogo.Size = new System.Drawing.Size(128, 128);
            this.SplashLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SplashLogo.TabIndex = 0;
            this.SplashLogo.TabStop = false;
            // 
            // PanelBackground
            // 
            this.PanelBackground.Location = new System.Drawing.Point(0, 483);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(457, 29);
            this.PanelBackground.TabIndex = 1;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.PaleGreen;
            this.Panel.Location = new System.Drawing.Point(0, 483);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(10, 30);
            this.Panel.TabIndex = 2;
            this.Panel.Visible = false;
            // 
            // SplashTimer
            // 
            this.SplashTimer.Enabled = true;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Launcher yükleniyor..";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.PanelBackground);
            this.Controls.Add(this.SplashLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.SplashLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SplashLogo;
        private System.Windows.Forms.Panel PanelBackground;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Label label1;
    }
}

