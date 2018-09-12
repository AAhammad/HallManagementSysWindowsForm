using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HallManagement1.DataAccess;
using HallManagement1.Domain;
using HallManagement1.UI;

namespace HallManagement1.checking
{
    class LoginChecking
    {
        public void loginCheck(UserLogin userObj,LoginFormUI ob)
        {
            LoginDataAccess dataAccess = new LoginDataAccess();

            int i = dataAccess.haveAnyUserId(userObj);
            if (i == 1)
            {
                HomePageUI obj = new HomePageUI();
                obj.Show();
                ob.Hide();
                
            }
            else
            {
                MessageBox.Show("Invalid Username and password!!!\n please try again.");
                //userLoginNameTextBox.Clear();
                //userLoginPasswordTextBox.Clear();
            }
        }
    }
}
