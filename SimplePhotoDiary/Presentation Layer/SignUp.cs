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
    public partial class SignUp : Form
    {
        
        public SignUp()
        {
            
            InitializeComponent();

        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void submitB_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "")
            {
                MessageBox.Show("Put a valid Username..");
            }
            else if (passwordBox.Text == "")
            {
                MessageBox.Show("Put a valid Password..");
            }
            else
            {
                if (cpBox.Text != passwordBox.Text)
                {
                    MessageBox.Show("Password and Confirm Password Doesnt Match!");
                }
                else
                {
                    UserDataService userDataService = new UserDataService();
                    int result = userDataService.AddUser(usernameBox.Text, passwordBox.Text);
                    if (result > 0)
                    {
                        MessageBox.Show("User Added Succesfully!");
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sorry There Was An Error!");
                    }
                }
            }
        }

        
    }
}
