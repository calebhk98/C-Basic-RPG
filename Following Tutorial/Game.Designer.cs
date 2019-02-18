namespace Following_Tutorial
{
    partial class Game
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
			this.health = new System.Windows.Forms.ProgressBar();
			this.currentHealth = new System.Windows.Forms.Label();
			this.maxHealth = new System.Windows.Forms.Label();
			this.lineBetweenHealth = new System.Windows.Forms.Label();
			this.userName = new System.Windows.Forms.Label();
			this.Menu = new System.Windows.Forms.Panel();
			this.Quit = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.player = new System.Windows.Forms.PictureBox();
			this.XPlabel = new System.Windows.Forms.Label();
			this.Menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
			this.SuspendLayout();
			// 
			// health
			// 
			this.health.BackColor = System.Drawing.SystemColors.Control;
			this.health.Cursor = System.Windows.Forms.Cursors.Default;
			this.health.Location = new System.Drawing.Point(12, 12);
			this.health.Name = "health";
			this.health.Size = new System.Drawing.Size(161, 23);
			this.health.TabIndex = 1;
			this.health.Value = 100;
			// 
			// currentHealth
			// 
			this.currentHealth.AutoSize = true;
			this.currentHealth.Location = new System.Drawing.Point(26, 38);
			this.currentHealth.Name = "currentHealth";
			this.currentHealth.Size = new System.Drawing.Size(25, 13);
			this.currentHealth.TabIndex = 21;
			this.currentHealth.Text = "100";
			// 
			// maxHealth
			// 
			this.maxHealth.AutoSize = true;
			this.maxHealth.BackColor = System.Drawing.SystemColors.Control;
			this.maxHealth.Cursor = System.Windows.Forms.Cursors.No;
			this.maxHealth.Location = new System.Drawing.Point(93, 38);
			this.maxHealth.Name = "maxHealth";
			this.maxHealth.Size = new System.Drawing.Size(25, 13);
			this.maxHealth.TabIndex = 22;
			this.maxHealth.Text = "100";
			// 
			// lineBetweenHealth
			// 
			this.lineBetweenHealth.AutoSize = true;
			this.lineBetweenHealth.Location = new System.Drawing.Point(66, 38);
			this.lineBetweenHealth.Name = "lineBetweenHealth";
			this.lineBetweenHealth.Size = new System.Drawing.Size(12, 13);
			this.lineBetweenHealth.TabIndex = 23;
			this.lineBetweenHealth.Text = "/";
			// 
			// userName
			// 
			this.userName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.userName.AutoSize = true;
			this.userName.Location = new System.Drawing.Point(401, 315);
			this.userName.Name = "userName";
			this.userName.Size = new System.Drawing.Size(57, 13);
			this.userName.TabIndex = 30;
			this.userName.Text = "UserName";
			this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Menu
			// 
			this.Menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Menu.BackgroundImage = global::Following_Tutorial.Properties.Resource.Inv;
			this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Menu.Controls.Add(this.Quit);
			this.Menu.Controls.Add(this.label1);
			this.Menu.Enabled = false;
			this.Menu.Location = new System.Drawing.Point(263, 30);
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(300, 168);
			this.Menu.TabIndex = 29;
			this.Menu.Visible = false;
			// 
			// Quit
			// 
			this.Quit.AutoSize = true;
			this.Quit.Location = new System.Drawing.Point(143, 111);
			this.Quit.Name = "Quit";
			this.Quit.Size = new System.Drawing.Size(26, 13);
			this.Quit.TabIndex = 1;
			this.Quit.Text = "Quit";
			this.Quit.Click += new System.EventHandler(this.Quit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(136, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Menu";
			// 
			// player
			// 
			this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
			this.player.Location = new System.Drawing.Point(401, 279);
			this.player.Name = "player";
			this.player.Size = new System.Drawing.Size(32, 32);
			this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.player.TabIndex = 0;
			this.player.TabStop = false;
			// 
			// XPlabel
			// 
			this.XPlabel.AutoSize = true;
			this.XPlabel.Location = new System.Drawing.Point(193, 18);
			this.XPlabel.Name = "XPlabel";
			this.XPlabel.Size = new System.Drawing.Size(32, 13);
			this.XPlabel.TabIndex = 31;
			this.XPlabel.Text = "Xp: 0";
			// 
			// Game
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.XPlabel);
			this.Controls.Add(this.userName);
			this.Controls.Add(this.Menu);
			this.Controls.Add(this.lineBetweenHealth);
			this.Controls.Add(this.maxHealth);
			this.Controls.Add(this.currentHealth);
			this.Controls.Add(this.health);
			this.Controls.Add(this.player);
			this.Name = "Game";
			this.Tag = "Apple";
			this.Text = "Game";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
			this.Menu.ResumeLayout(false);
			this.Menu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.ProgressBar health;
        private System.Windows.Forms.Label currentHealth;
        private System.Windows.Forms.Label maxHealth;
        private System.Windows.Forms.Label lineBetweenHealth;
		private new System.Windows.Forms.Panel Menu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label userName;
		private System.Windows.Forms.Label Quit;
		private System.Windows.Forms.Label XPlabel;
	}
}