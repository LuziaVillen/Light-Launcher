namespace Light_Launcher
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pp = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.vercombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.playbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(-91, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pp
            // 
            this.pp.Image = global::Light_Launcher.Properties.Resources.Logo;
            this.pp.ImageRotate = 0F;
            this.pp.Location = new System.Drawing.Point(37, 424);
            this.pp.Name = "pp";
            this.pp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pp.Size = new System.Drawing.Size(64, 64);
            this.pp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pp.TabIndex = 0;
            this.pp.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox2.Location = new System.Drawing.Point(-91, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(123, 433);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(133, 27);
            this.username.TabIndex = 3;
            this.username.Text = "Kullanıcı adı";
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Silver;
            this.logout.Location = new System.Drawing.Point(135, 462);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(72, 21);
            this.logout.TabIndex = 4;
            this.logout.Text = "Çıkış yap";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // vercombo
            // 
            this.vercombo.BackColor = System.Drawing.Color.Transparent;
            this.vercombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.vercombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vercombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vercombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vercombo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vercombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.vercombo.ItemHeight = 30;
            this.vercombo.Location = new System.Drawing.Point(290, 452);
            this.vercombo.Name = "vercombo";
            this.vercombo.Size = new System.Drawing.Size(140, 36);
            this.vercombo.StartIndex = 0;
            this.vercombo.TabIndex = 5;
            this.vercombo.SelectedIndexChanged += new System.EventHandler(this.vercombo_SelectedIndexChanged);
            // 
            // playbutton
            // 
            this.playbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playbutton.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbutton.Location = new System.Drawing.Point(740, 451);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(147, 41);
            this.playbutton.TabIndex = 6;
            this.playbutton.Text = "OYNA";
            this.playbutton.UseVisualStyleBackColor = true;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(857, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.vercombo);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light Launcher";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label logout;
        private Guna.UI2.WinForms.Guna2ComboBox vercombo;
        private System.Windows.Forms.Button playbutton;
        private System.Windows.Forms.Button button2;
    }
}