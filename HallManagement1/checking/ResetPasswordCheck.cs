using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HallManagement1.DataAccess;
using HallManagement1.Domain;

namespace HallManagement1.checking
{
    class ResetPasswordCheck
    {
        public void check(UserLogin user)
        {
            if (user.resetNewPassword == "")
            {
                MessageBox.Show("please enter some characters!!!");
            }
            else
            {
                ResetPasswordDataAccess obj = new ResetPasswordDataAccess();
                int i = obj.updtpassword(user);
                if (i == 1)
                {

                    MessageBox.Show("update successfully.");


                }
                else
                {
                    MessageBox.Show("your name or old password don't match!!!!.");
                    
                }
          
            }
            
        }
    }
}
