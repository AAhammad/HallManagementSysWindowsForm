using System;
using System.Net.Mime;
using System.Windows.Forms;
using HallManagement1.checking;
using HallManagement1.DataAccess;
using HallManagement1.Domain;

namespace HallManagement1.UI
{
    public partial class ResetPasswordUI : Form
    {
        public ResetPasswordUI()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            UserLogin userObj = new UserLogin()
            {
                username = resetPasswordNameTextBox.Text,
                userpassword = resetOldPasswordTextBox.Text,
                resetNewPassword =resetNewPasswordTextBox.Text

            };

            ResetPasswordCheck obj=new ResetPasswordCheck();
            obj.check(userObj);

            
            
                
            

        }

        private void loginPageButton_Click(object sender, EventArgs e)
        {
            //LoginFormUI obj=new LoginFormUI();
            //obj.Show();
            //this.Close();
            
            LoginFormUI obj = new LoginFormUI();
            obj.Show();
            obj.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
            
           



        }
    }
}
