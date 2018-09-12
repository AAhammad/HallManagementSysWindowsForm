using System;
using System.Windows.Forms;
using HallManagement1.checking;
using HallManagement1.DataAccess;
using HallManagement1.Domain;

namespace HallManagement1.UI
{
    public partial class LoginFormUI : Form
    {
        public LoginFormUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



  

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ResetLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPasswordUI obj=new ResetPasswordUI();
            obj.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
             UserLogin userObj = new UserLogin()
            {
                username = userLoginNameTextBox.Text,
                userpassword =userLoginPasswordTextBox.Text
            };

            LoginChecking obj=new LoginChecking();
            obj.loginCheck(userObj,this);
        }
        }
    }

