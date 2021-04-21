using SimplePhotoDiary.Service_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePhotoDiary.Presentation_Layer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SignUpB_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            if (userNameBox.Text == "")
            {
                MessageBox.Show("Put a valid Username..");
            }
            else if (passwordBox.Text == "")
            {
                MessageBox.Show("Put a valid Password..");
            }
            else
            {
                UserDataService userDataService = new UserDataService();
                int result = userDataService.UserAuthentication(userNameBox.Text, passwordBox.Text);
                if (result > 0)
                {
                    int userid = userDataService.GetUserId(userNameBox.Text, passwordBox.Text);
                    this.Hide();
                    EventActions eventActions = new EventActions(userid);
                    eventActions.Show();
                    
                }
                else
                {
                    MessageBox.Show("User Doesn't Exist!");
                }


            }
            }

        
    }
}
