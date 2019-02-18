namespace Following_Tutorial
{
    partial class MainMenu
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
            this.submissionButton = new System.Windows.Forms.Button();
            this.mainText = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.openGameButton = new System.Windows.Forms.Button();
            this.continueText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submissionButton
            // 
            this.submissionButton.Location = new System.Drawing.Point(58, 89);
            this.submissionButton.Name = "submissionButton";
            this.submissionButton.Size = new System.Drawing.Size(75, 23);
            this.submissionButton.TabIndex = 1;
            this.submissionButton.Text = "Submit";
            this.submissionButton.UseVisualStyleBackColor = true;
            this.submissionButton.Click += new System.EventHandler(this.submissionButton_Click);
            // 
            // mainText
            // 
            this.mainText.AutoSize = true;
            this.mainText.Location = new System.Drawing.Point(12, 9);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(147, 13);
            this.mainText.TabIndex = 1;
            this.mainText.Text = "Hello World, type in your pass";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(33, 41);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '^';
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 0;
            // 
            // openGameButton
            // 
            this.openGameButton.Location = new System.Drawing.Point(167, 28);
            this.openGameButton.Name = "openGameButton";
            this.openGameButton.Size = new System.Drawing.Size(75, 51);
            this.openGameButton.TabIndex = 2;
            this.openGameButton.Text = "Continue";
            this.openGameButton.UseVisualStyleBackColor = true;
            this.openGameButton.Click += new System.EventHandler(this.openGameButton_Click);
            // 
            // continueText
            // 
            this.continueText.AutoSize = true;
            this.continueText.Location = new System.Drawing.Point(164, 94);
            this.continueText.Name = "continueText";
            this.continueText.Size = new System.Drawing.Size(0, 13);
            this.continueText.TabIndex = 4;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 159);
            this.Controls.Add(this.continueText);
            this.Controls.Add(this.openGameButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.submissionButton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submissionButton;
        private System.Windows.Forms.Label mainText;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button openGameButton;
        private System.Windows.Forms.Label continueText;
    }
}

