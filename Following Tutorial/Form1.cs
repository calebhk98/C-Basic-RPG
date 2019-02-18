using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//Resources needed

namespace Following_Tutorial{
    public partial class MainMenu : Form{
        bool loggedIn = false;
		string Username = "ERROR";
		public MainMenu()
        {
            InitializeComponent();//Sets the componets for the form, like the width and height
			
        }//Don't know what it does
        
        private void Form1_Load(object sender, EventArgs e){

        }//Where the form actually is

        public void submissionButton_Click(object sender, EventArgs e){
            
            if (passwordBox.Text == "unlocked")
            {
                mainText.Text = "Well done Guest";
				Username = "Guest";
				loggedIn = true;
            }
            
            else {
                mainText.Text = "ERROR, incorrect password";
            }
        }//What happens when the log-in button is clicked

        private void openGameButton_Click(object sender, EventArgs e)
        {
            if (loggedIn)
            {
                Game open_form = new Game(Username);//creates the new form
                open_form.Visible = true;//shows the new form
                this.Hide();//hides current form

            }
            else {
                continueText.Text = "Not logged In";
            }

        }//What happens when the Game button is clicked
    }//The actual Form
}//The program I think
