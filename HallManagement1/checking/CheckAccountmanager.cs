using System.Windows.Forms;
using HallManagement1.DataAccess;
using HallManagement1.Domain;
using HallManagement1.UI;

namespace HallManagement1.checking
{
    internal class CheckAccountmanager

{
    public void checkAccount(UserLogin userObj)
    {



        if (userObj.username == "" || userObj.userpassword == "")
        {
            MessageBox.Show("please enter some characters.");

        }



        else
        {
            LoginDataAccess dataAccess = new LoginDataAccess();

            int i = dataAccess.haveAnyUserId(userObj);
            if (i == 0)
            {
                CreateAccountDataAccess dataAcs = new CreateAccountDataAccess();

                int j = dataAcs.saveAccount(userObj);

                string Message = j > 0 ? "create successfully" : "data not saved";
                MessageBox.Show(Message);

            }
            else
            {
                MessageBox.Show("there is exit another account has same name and same password!!!\n please try again.");

            }


        }







    }
}
}