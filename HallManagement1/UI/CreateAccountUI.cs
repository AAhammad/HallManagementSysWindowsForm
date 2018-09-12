using System;
using System.Windows.Forms;
using HallManagement1.checking;
using HallManagement1.DataAccess;
using HallManagement1.Domain;

namespace HallManagement1.UI
{
    public partial class CreateAccountUI : Form
    {
        public CreateAccountUI()
        {
            InitializeComponent();
        }

        private void createAnotherAccountPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void createAnotherAccountnameLabel_Click(object sender, EventArgs e)
        {

        }




        private void createButton_Click(object sender, EventArgs e)
        {
             UserLogin userObj = new UserLogin()
            {
                username = createAccountNameTextBox.Text,
                userpassword =createAccountPasswordTextBox.Text
            };

            CheckAccountmanager obj=new CheckAccountmanager();
            obj.checkAccount(userObj);
            createAccountNameTextBox.Clear();
            createAccountPasswordTextBox.Clear();
     
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
